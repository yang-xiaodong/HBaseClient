// Copyright (c) Geekbuying Corporation
// All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License"); you may not
// use this file except in compliance with the License.  You may obtain a copy
// of the License at http://www.apache.org/licenses/LICENSE-2.0
// 
// THIS CODE IS PROVIDED *AS IS* BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION ANY IMPLIED
// WARRANTIES OR CONDITIONS OF TITLE, FITNESS FOR A PARTICULAR PURPOSE,
// MERCHANTABLITY OR NON-INFRINGEMENT.
// 
// See the Apache Version 2.0 License for specific language governing
// permissions and limitations under the License.

using System;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Geekbuying.HBaseClient.Tests.Utilities;
using org.apache.hadoop.hbase.rest.protobuf.generated;
using Xunit;

namespace Geekbuying.HBaseClient.Tests.Clients
{
    public abstract class HBaseClientTestBase : DisposableContextSpecification
    {
        // TEST TODOS:
        // TODO: add test for ModifyTableSchema

        private const string TestTablePrefix = "marlintest";
        private readonly Random _random = new Random();

        public string testTableName;
        private TableSchema _testTableSchema;

        protected override void Context()
        {
            var client = CreateClient();

            // ensure tables from previous tests are cleaned up
            var tables = client.ListTablesAsync().GetAwaiter().GetResult();
            foreach (var name in tables.name)
                if (name.StartsWith(TestTablePrefix, StringComparison.Ordinal))
                    client.DeleteTableAsync(name).Wait();

            // add a table specific to this test
            testTableName = TestTablePrefix + _random.Next(10000);
            _testTableSchema = new TableSchema();
            _testTableSchema.name = testTableName;
            _testTableSchema.columns.Add(new ColumnSchema {name = "d", maxVersions = 3});

            client.CreateTableAsync(_testTableSchema).Wait();
        }

        public abstract IHBaseClient CreateClient();

#pragma warning disable xUnit1013 // Public method should be marked as test
        public void StoreTestData(IHBaseClient hbaseClient)
#pragma warning restore xUnit1013 // Public method should be marked as test
        {
            // we are going to insert the keys 0 to 100 and then do some range queries on that
            const string testValue = "the force is strong in this column";
            var set = new CellSet();
            for (var i = 0; i < 100; i++)
            {
                var row = new CellSet.Row {key = BitConverter.GetBytes(i)};
                var value = new Cell
                {
                    column = Encoding.UTF8.GetBytes("d:starwars"),
                    data = Encoding.UTF8.GetBytes(testValue)
                };
                row.values.Add(value);
                set.rows.Add(row);
            }

            hbaseClient.StoreCellsAsync(testTableName, set).Wait();
        }

        [Fact]
        public void TestCellsDeletion()
        {
            const string testKey = "content";
            const string testValue = "the force is strong in this column";
            var client = CreateClient();
            var set = new CellSet();
            var row = new CellSet.Row {key = Encoding.UTF8.GetBytes(testKey)};
            set.rows.Add(row);

            var value = new Cell
            {
                column = Encoding.UTF8.GetBytes("d:starwars"),
                data = Encoding.UTF8.GetBytes(testValue)
            };
            row.values.Add(value);

            client.StoreCellsAsync(testTableName, set).Wait();
            var cell = client.GetCellsAsync(testTableName, testKey).Result;
            // make sure the cell is in the table
            Assert.Equal(Encoding.UTF8.GetString(cell.rows[0].key), testKey);
            // delete cell
            client.DeleteCellsAsync(testTableName, testKey).Wait();
            // get cell again, 404 exception expected
            client.GetCellsAsync(testTableName, testKey).Wait();
        }

        [Fact]
        public abstract void TestFullScan();

        [Fact]
        public void TestGetCellsWithMultiGetRequest()
        {
            var testKey1 = Guid.NewGuid().ToString();
            var testKey2 = Guid.NewGuid().ToString();
            var testValue1 = "the force is strong in this column " + testKey1;
            var testValue2 = "the force is strong in this column " + testKey2;

            var client = CreateClient();
            var set = new CellSet();
            var row1 = new CellSet.Row {key = Encoding.UTF8.GetBytes(testKey1)};
            var row2 = new CellSet.Row {key = Encoding.UTF8.GetBytes(testKey2)};
            set.rows.Add(row1);
            set.rows.Add(row2);

            var value1 = new Cell
            {
                column = Encoding.UTF8.GetBytes("d:starwars"),
                data = Encoding.UTF8.GetBytes(testValue1)
            };
            var value2 = new Cell
            {
                column = Encoding.UTF8.GetBytes("d:starwars"),
                data = Encoding.UTF8.GetBytes(testValue2)
            };
            row1.values.Add(value1);
            row2.values.Add(value2);

            client.StoreCellsAsync(testTableName, set).Wait();

            var cells = client.GetCellsAsync(testTableName, new[] {testKey1, testKey2}).Result;
            Assert.Equal(2, cells.rows.Count);
            Assert.Single(cells.rows[0].values);
            Assert.Equal(testValue1, Encoding.UTF8.GetString(cells.rows[0].values[0].data));
            Assert.Single(cells.rows[1].values);
            Assert.Equal(testValue2, Encoding.UTF8.GetString(cells.rows[1].values[0].data));
        }

        [Fact]
        public void TestGetStorageClusterStatus()
        {
            var client = CreateClient();
            var status = client.GetStorageClusterStatusAsync().Result;
            // TODO not really a good test
            Assert.True(status.requests >= 0, "number of requests is negative");
            Assert.True(status.liveNodes.Count >= 1, "number of live nodes is zero or negative");
            Assert.True(status.liveNodes[0].requests >= 0, "number of requests to the first node is negative");
        }

        [Fact]
        public void TestGetVersion()
        {
            var client = CreateClient();
            var version = client.GetVersionAsync().Result;

            Trace.WriteLine(version);

            version.jvmVersion.ShouldNotBeNullOrEmpty();
            version.jerseyVersion.ShouldNotBeNullOrEmpty();
            version.osVersion.ShouldNotBeNullOrEmpty();
            version.restVersion.ShouldNotBeNullOrEmpty();
        }

        [Fact]
        public void TestListTables()
        {
            var client = CreateClient();

            var tables = client.ListTablesAsync().Result;
            var testtables = tables.name.Where(item => item.StartsWith("marlintest", StringComparison.Ordinal))
                .ToList();
            Assert.Single(testtables);
            Assert.Equal(testTableName, testtables[0]);
        }

        [Fact]
        public void TestStoreSingleCell()
        {
            const string testKey = "content";
            const string testValue = "the force is strong in this column";
            var client = CreateClient();
            var set = new CellSet();
            var row = new CellSet.Row {key = Encoding.UTF8.GetBytes(testKey)};
            set.rows.Add(row);

            var value = new Cell
            {
                column = Encoding.UTF8.GetBytes("d:starwars"),
                data = Encoding.UTF8.GetBytes(testValue)
            };
            row.values.Add(value);

            client.StoreCellsAsync(testTableName, set).Wait();

            var cells = client.GetCellsAsync(testTableName, testKey).Result;
            Assert.Single(cells.rows);
            Assert.Single(cells.rows[0].values);
            Assert.Equal(testValue, Encoding.UTF8.GetString(cells.rows[0].values[0].data));
        }

        [Fact]
        public abstract void TestSubsetScan();

        [Fact]
        public void TestTableSchema()
        {
            var client = CreateClient();
            var schema = client.GetTableSchemaAsync(testTableName).Result;
            Assert.Equal(testTableName, schema.name);
            Assert.Equal(_testTableSchema.columns.Count, schema.columns.Count);
            Assert.Equal(_testTableSchema.columns[0].name, schema.columns[0].name);
        }
    }
}