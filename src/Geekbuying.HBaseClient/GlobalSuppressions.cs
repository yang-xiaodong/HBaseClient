// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Code Analysis results, point to "Suppress Message", and click 
// "In Suppression File".
// You do not need to add suppressions to this file manually.

using System.Diagnostics.CodeAnalysis;

[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "hadoop",
        Scope = "namespace", Target = "org.apache.hadoop.hbase.rest.protobuf.generated")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "org",
        Scope = "namespace", Target = "org.apache.hadoop.hbase.rest.protobuf.generated")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "rest",
        Scope = "namespace", Target = "org.apache.hadoop.hbase.rest.protobuf.generated")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "hbase",
        Scope = "namespace", Target = "org.apache.hadoop.hbase.rest.protobuf.generated")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "protobuf",
        Scope = "namespace", Target = "org.apache.hadoop.hbase.rest.protobuf.generated")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "hadoop",
        Scope = "namespace", Target = "org.apache.hadoop.hbase.rest.protobuf.generated")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "protobuf",
        Scope = "namespace", Target = "org.apache.hadoop.hbase.rest.protobuf.generated")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "hbase",
        Scope = "namespace", Target = "org.apache.hadoop.hbase.rest.protobuf.generated")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "generated",
        Scope = "namespace", Target = "org.apache.hadoop.hbase.rest.protobuf.generated")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "apache",
        Scope = "namespace", Target = "org.apache.hadoop.hbase.rest.protobuf.generated")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "column",
        Scope = "member", Target = "org.apache.hadoop.hbase.rest.protobuf.generated.Cell.#column")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "timestamp",
        Scope = "member", Target = "org.apache.hadoop.hbase.rest.protobuf.generated.Cell.#timestamp")]
[assembly:
    SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.Cell.#data")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "data",
        Scope = "member", Target = "org.apache.hadoop.hbase.rest.protobuf.generated.Cell.#data")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member",
        Target =
            "org.apache.hadoop.hbase.rest.protobuf.generated.Cell.#ProtoBuf.IExtensible.GetExtensionObject(System.Boolean)")]
[assembly:
    SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.Cell.#row")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "row", Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.Cell.#row")]
[assembly:
    SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.Cell.#column")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "rows",
        Scope = "member", Target = "org.apache.hadoop.hbase.rest.protobuf.generated.CellSet.#rows")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.CellSet.#rows")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.CellSet+Row")]
[assembly:
    SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.CellSet+Row.#key")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "key", Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.CellSet+Row.#key")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "values",
        Scope = "member", Target = "org.apache.hadoop.hbase.rest.protobuf.generated.CellSet+Row.#values")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.CellSet+Row.#values")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member",
        Target =
            "org.apache.hadoop.hbase.rest.protobuf.generated.CellSet+Row.#ProtoBuf.IExtensible.GetExtensionObject(System.Boolean)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member",
        Target =
            "org.apache.hadoop.hbase.rest.protobuf.generated.CellSet.#ProtoBuf.IExtensible.GetExtensionObject(System.Boolean)")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "name",
        Scope = "member", Target = "org.apache.hadoop.hbase.rest.protobuf.generated.ColumnSchema.#name")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "attrs",
        Scope = "member", Target = "org.apache.hadoop.hbase.rest.protobuf.generated.ColumnSchema.#attrs")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "attrs",
        Scope = "member", Target = "org.apache.hadoop.hbase.rest.protobuf.generated.ColumnSchema.#attrs")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.ColumnSchema.#attrs")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "ttl",
        Scope = "member", Target = "org.apache.hadoop.hbase.rest.protobuf.generated.ColumnSchema.#ttl")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "ttl", Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.ColumnSchema.#ttl")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "max", Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.ColumnSchema.#maxVersions")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "compression",
        Scope = "member", Target = "org.apache.hadoop.hbase.rest.protobuf.generated.ColumnSchema.#compression")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.ColumnSchema+Attribute")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix", Scope = "type",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.ColumnSchema+Attribute")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "name",
        Scope = "member", Target = "org.apache.hadoop.hbase.rest.protobuf.generated.ColumnSchema+Attribute.#name")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "value",
        Scope = "member", Target = "org.apache.hadoop.hbase.rest.protobuf.generated.ColumnSchema+Attribute.#value")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member",
        Target =
            "org.apache.hadoop.hbase.rest.protobuf.generated.ColumnSchema+Attribute.#ProtoBuf.IExtensible.GetExtensionObject(System.Boolean)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member",
        Target =
            "org.apache.hadoop.hbase.rest.protobuf.generated.ColumnSchema.#ProtoBuf.IExtensible.GetExtensionObject(System.Boolean)")]
[assembly:
    SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.Scanner.#startRow")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "start",
        Scope = "member", Target = "org.apache.hadoop.hbase.rest.protobuf.generated.Scanner.#startRow")]
[assembly:
    SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.Scanner.#endRow")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "end", Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.Scanner.#endRow")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "columns",
        Scope = "member", Target = "org.apache.hadoop.hbase.rest.protobuf.generated.Scanner.#columns")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.Scanner.#columns")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "batch",
        Scope = "member", Target = "org.apache.hadoop.hbase.rest.protobuf.generated.Scanner.#batch")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "start",
        Scope = "member", Target = "org.apache.hadoop.hbase.rest.protobuf.generated.Scanner.#startTime")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "end", Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.Scanner.#endTime")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "max", Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.Scanner.#maxVersions")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "filter",
        Scope = "member", Target = "org.apache.hadoop.hbase.rest.protobuf.generated.Scanner.#filter")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "caching",
        Scope = "member", Target = "org.apache.hadoop.hbase.rest.protobuf.generated.Scanner.#caching")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member",
        Target =
            "org.apache.hadoop.hbase.rest.protobuf.generated.Scanner.#ProtoBuf.IExtensible.GetExtensionObject(System.Boolean)")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "live",
        Scope = "member", Target = "org.apache.hadoop.hbase.rest.protobuf.generated.StorageClusterStatus.#liveNodes")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.StorageClusterStatus.#liveNodes")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "dead",
        Scope = "member", Target = "org.apache.hadoop.hbase.rest.protobuf.generated.StorageClusterStatus.#deadNodes")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.StorageClusterStatus.#deadNodes")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "regions",
        Scope = "member", Target = "org.apache.hadoop.hbase.rest.protobuf.generated.StorageClusterStatus.#regions")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "requests",
        Scope = "member", Target = "org.apache.hadoop.hbase.rest.protobuf.generated.StorageClusterStatus.#requests")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "average",
        Scope = "member", Target = "org.apache.hadoop.hbase.rest.protobuf.generated.StorageClusterStatus.#averageLoad")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.StorageClusterStatus+Region")]
[assembly:
    SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.StorageClusterStatus+Region.#name")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "name",
        Scope = "member", Target = "org.apache.hadoop.hbase.rest.protobuf.generated.StorageClusterStatus+Region.#name")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "stores",
        Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.StorageClusterStatus+Region.#stores")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "storefiles",
        Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.StorageClusterStatus+Region.#storefiles")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "storefiles",
        Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.StorageClusterStatus+Region.#storefiles")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "storefile",
        Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.StorageClusterStatus+Region.#storefileSizeMB")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "storefile",
        Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.StorageClusterStatus+Region.#storefileSizeMB")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "memstore",
        Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.StorageClusterStatus+Region.#memstoreSizeMB")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "memstore",
        Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.StorageClusterStatus+Region.#memstoreSizeMB")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "storefile",
        Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.StorageClusterStatus+Region.#storefileIndexSizeMB")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "storefile",
        Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.StorageClusterStatus+Region.#storefileIndexSizeMB")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "read",
        Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.StorageClusterStatus+Region.#readRequestsCount")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "write",
        Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.StorageClusterStatus+Region.#writeRequestsCount")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "root",
        Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.StorageClusterStatus+Region.#rootIndexSizeKB")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "total",
        Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.StorageClusterStatus+Region.#totalStaticIndexSizeKB")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "total",
        Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.StorageClusterStatus+Region.#totalStaticBloomSizeKB")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "total",
        Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.StorageClusterStatus+Region.#totalCompactingKVs")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "current",
        Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.StorageClusterStatus+Region.#currentCompactedKVs")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member",
        Target =
            "org.apache.hadoop.hbase.rest.protobuf.generated.StorageClusterStatus+Region.#ProtoBuf.IExtensible.GetExtensionObject(System.Boolean)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.StorageClusterStatus+Node")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "name",
        Scope = "member", Target = "org.apache.hadoop.hbase.rest.protobuf.generated.StorageClusterStatus+Node.#name")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "start",
        Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.StorageClusterStatus+Node.#startCode")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "requests",
        Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.StorageClusterStatus+Node.#requests")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "heap",
        Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.StorageClusterStatus+Node.#heapSizeMB")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "max", Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.StorageClusterStatus+Node.#maxHeapSizeMB")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "regions",
        Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.StorageClusterStatus+Node.#regions")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.StorageClusterStatus+Node.#regions")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member",
        Target =
            "org.apache.hadoop.hbase.rest.protobuf.generated.StorageClusterStatus+Node.#ProtoBuf.IExtensible.GetExtensionObject(System.Boolean)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member",
        Target =
            "org.apache.hadoop.hbase.rest.protobuf.generated.StorageClusterStatus.#ProtoBuf.IExtensible.GetExtensionObject(System.Boolean)")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "name",
        Scope = "member", Target = "org.apache.hadoop.hbase.rest.protobuf.generated.TableInfo.#name")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "regions",
        Scope = "member", Target = "org.apache.hadoop.hbase.rest.protobuf.generated.TableInfo.#regions")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.TableInfo.#regions")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.TableInfo+Region")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "name",
        Scope = "member", Target = "org.apache.hadoop.hbase.rest.protobuf.generated.TableInfo+Region.#name")]
[assembly:
    SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.TableInfo+Region.#startKey")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "start",
        Scope = "member", Target = "org.apache.hadoop.hbase.rest.protobuf.generated.TableInfo+Region.#startKey")]
[assembly:
    SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays", Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.TableInfo+Region.#endKey")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "end", Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.TableInfo+Region.#endKey")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "id", Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.TableInfo+Region.#id")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "location",
        Scope = "member", Target = "org.apache.hadoop.hbase.rest.protobuf.generated.TableInfo+Region.#location")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member",
        Target =
            "org.apache.hadoop.hbase.rest.protobuf.generated.TableInfo+Region.#ProtoBuf.IExtensible.GetExtensionObject(System.Boolean)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member",
        Target =
            "org.apache.hadoop.hbase.rest.protobuf.generated.TableInfo.#ProtoBuf.IExtensible.GetExtensionObject(System.Boolean)")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "name",
        Scope = "member", Target = "org.apache.hadoop.hbase.rest.protobuf.generated.TableList.#name")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.TableList.#name")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member",
        Target =
            "org.apache.hadoop.hbase.rest.protobuf.generated.TableList.#ProtoBuf.IExtensible.GetExtensionObject(System.Boolean)")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "name",
        Scope = "member", Target = "org.apache.hadoop.hbase.rest.protobuf.generated.TableSchema.#name")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "attrs",
        Scope = "member", Target = "org.apache.hadoop.hbase.rest.protobuf.generated.TableSchema.#attrs")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "attrs",
        Scope = "member", Target = "org.apache.hadoop.hbase.rest.protobuf.generated.TableSchema.#attrs")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.TableSchema.#attrs")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "columns",
        Scope = "member", Target = "org.apache.hadoop.hbase.rest.protobuf.generated.TableSchema.#columns")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.TableSchema.#columns")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "in", Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.TableSchema.#inMemory")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "read",
        Scope = "member", Target = "org.apache.hadoop.hbase.rest.protobuf.generated.TableSchema.#readOnly")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible", Scope = "type",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.TableSchema+Attribute")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix", Scope = "type",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.TableSchema+Attribute")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "name",
        Scope = "member", Target = "org.apache.hadoop.hbase.rest.protobuf.generated.TableSchema+Attribute.#name")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "value",
        Scope = "member", Target = "org.apache.hadoop.hbase.rest.protobuf.generated.TableSchema+Attribute.#value")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member",
        Target =
            "org.apache.hadoop.hbase.rest.protobuf.generated.TableSchema+Attribute.#ProtoBuf.IExtensible.GetExtensionObject(System.Boolean)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member",
        Target =
            "org.apache.hadoop.hbase.rest.protobuf.generated.TableSchema.#ProtoBuf.IExtensible.GetExtensionObject(System.Boolean)")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "rest",
        Scope = "member", Target = "org.apache.hadoop.hbase.rest.protobuf.generated.Version.#restVersion")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "jvm",
        Scope = "member", Target = "org.apache.hadoop.hbase.rest.protobuf.generated.Version.#jvmVersion")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "jvm", Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.Version.#jvmVersion")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "os",
        Scope = "member", Target = "org.apache.hadoop.hbase.rest.protobuf.generated.Version.#osVersion")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "os", Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.Version.#osVersion")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "server",
        Scope = "member", Target = "org.apache.hadoop.hbase.rest.protobuf.generated.Version.#serverVersion")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "jersey",
        Scope = "member", Target = "org.apache.hadoop.hbase.rest.protobuf.generated.Version.#jerseyVersion")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member",
        Target =
            "org.apache.hadoop.hbase.rest.protobuf.generated.Version.#ProtoBuf.IExtensible.GetExtensionObject(System.Boolean)")]
[assembly:
    SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider",
        MessageId = "System.String.Format(System.String,System.Object[])", Scope = "member",
        Target = "org.apache.hadoop.hbase.rest.protobuf.generated.Version.#ToString()")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "num",
        Scope = "member",
        Target = "Geekbuying.HBaseClient.LoadBalancing.LoadBalancerRoundRobin.#.ctor(System.Int32,System.Int32)")]
[assembly:
    SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider",
        MessageId = "System.String.Format(System.String,System.Object,System.Object)", Scope = "member",
        Target = "Geekbuying.HBaseClient.LoadBalancing.LoadBalancerRoundRobin.#.ctor(System.Int32,System.Int32)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member",
        Target =
            "Geekbuying.HBaseClient.LoadBalancing.LoadBalancerRoundRobin.#.ctor(System.Collections.Generic.List`1<System.String>,System.Int32)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0",
        Scope = "member",
        Target =
            "Geekbuying.HBaseClient.LoadBalancing.LoadBalancerRoundRobin.#.ctor(System.Collections.Generic.List`1<System.String>,System.Int32)")]
[assembly:
    SuppressMessage("Microsoft.Performance", "CA1804:RemoveUnusedLocals", MessageId = "e", Scope = "member",
        Target =
            "Geekbuying.HBaseClient.LoadBalancing.LoadBalancerRoundRobin.#ReadFromConfig`1(System.String,System.Func`2<System.String,!!0>,!!0)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member",
        Target =
            "Geekbuying.HBaseClient.LoadBalancing.LoadBalancerRoundRobin.#ReadFromConfig`1(System.String,System.Func`2<System.String,!!0>,!!0)")]
[assembly:
    SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider",
        MessageId = "System.String.Format(System.String,System.Object,System.Object)", Scope = "member",
        Target =
            "Geekbuying.HBaseClient.LoadBalancing.LoadBalancerRoundRobin.#PopulateCandidates(System.Collections.Generic.List`1<System.String>,System.TimeSpan)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1053:StaticHolderTypesShouldNotHaveConstructors", Scope = "type",
        Target = "Geekbuying.HBaseClient.LoadBalancing.LoadBalancingHelper")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "num",
        Scope = "member",
        Target =
            "Geekbuying.HBaseClient.LoadBalancing.LoadBalancingHelper.#Execute(System.Action,Geekbuying.HBaseClient.IRetryPolicy,Geekbuying.HBaseClient.IBackOffScheme,System.Int32)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0",
        Scope = "member",
        Target =
            "Geekbuying.HBaseClient.LoadBalancing.LoadBalancingHelper.#Execute(System.Action,Geekbuying.HBaseClient.IRetryPolicy,Geekbuying.HBaseClient.IBackOffScheme,System.Int32)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "1",
        Scope = "member",
        Target =
            "Geekbuying.HBaseClient.LoadBalancing.LoadBalancingHelper.#Execute(System.Action,Geekbuying.HBaseClient.IRetryPolicy,Geekbuying.HBaseClient.IBackOffScheme,System.Int32)")]
[assembly:
    SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "2",
        Scope = "member",
        Target =
            "Geekbuying.HBaseClient.LoadBalancing.LoadBalancingHelper.#Execute(System.Action,Geekbuying.HBaseClient.IRetryPolicy,Geekbuying.HBaseClient.IBackOffScheme,System.Int32)")]
[assembly:
    SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "num",
        Scope = "member", Target = "Geekbuying.HBaseClient.HBaseClient.#.ctor(System.Int32)")]
[assembly:
    SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member",
        Target =
            "Geekbuying.HBaseClient.HBaseClient.#ExecuteWithVirtualNetworkLoadBalancing(System.Func`2<System.String,System.Threading.Tasks.Task>)")]