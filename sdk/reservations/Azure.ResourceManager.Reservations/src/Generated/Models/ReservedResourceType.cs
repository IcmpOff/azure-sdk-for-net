// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> The type of the resource that is being reserved. </summary>
    public readonly partial struct ReservedResourceType : IEquatable<ReservedResourceType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ReservedResourceType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ReservedResourceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string VirtualMachinesValue = "VirtualMachines";
        private const string SqlDatabasesValue = "SqlDatabases";
        private const string SuseLinuxValue = "SuseLinux";
        private const string CosmosDbValue = "CosmosDb";
        private const string RedHatValue = "RedHat";
        private const string SqlDataWarehouseValue = "SqlDataWarehouse";
        private const string VMwareCloudSimpleValue = "VMwareCloudSimple";
        private const string RedHatOsaValue = "RedHatOsa";
        private const string DatabricksValue = "Databricks";
        private const string AppServiceValue = "AppService";
        private const string ManagedDiskValue = "ManagedDisk";
        private const string BlockBlobValue = "BlockBlob";
        private const string RedisCacheValue = "RedisCache";
        private const string AzureDataExplorerValue = "AzureDataExplorer";
        private const string MySqlValue = "MySql";
        private const string MariaDbValue = "MariaDb";
        private const string PostgreSqlValue = "PostgreSql";
        private const string DedicatedHostValue = "DedicatedHost";
        private const string SapHanaValue = "SapHana";
        private const string SqlAzureHybridBenefitValue = "SqlAzureHybridBenefit";
        private const string AVSValue = "AVS";
        private const string DataFactoryValue = "DataFactory";
        private const string NetAppStorageValue = "NetAppStorage";
        private const string AzureFilesValue = "AzureFiles";
        private const string SqlEdgeValue = "SqlEdge";
        private const string VirtualMachineSoftwareValue = "VirtualMachineSoftware";

        /// <summary> VirtualMachines. </summary>
        public static ReservedResourceType VirtualMachines { get; } = new ReservedResourceType(VirtualMachinesValue);
        /// <summary> SqlDatabases. </summary>
        public static ReservedResourceType SqlDatabases { get; } = new ReservedResourceType(SqlDatabasesValue);
        /// <summary> SuseLinux. </summary>
        public static ReservedResourceType SuseLinux { get; } = new ReservedResourceType(SuseLinuxValue);
        /// <summary> CosmosDb. </summary>
        public static ReservedResourceType CosmosDb { get; } = new ReservedResourceType(CosmosDbValue);
        /// <summary> RedHat. </summary>
        public static ReservedResourceType RedHat { get; } = new ReservedResourceType(RedHatValue);
        /// <summary> SqlDataWarehouse. </summary>
        public static ReservedResourceType SqlDataWarehouse { get; } = new ReservedResourceType(SqlDataWarehouseValue);
        /// <summary> VMwareCloudSimple. </summary>
        public static ReservedResourceType VMwareCloudSimple { get; } = new ReservedResourceType(VMwareCloudSimpleValue);
        /// <summary> RedHatOsa. </summary>
        public static ReservedResourceType RedHatOsa { get; } = new ReservedResourceType(RedHatOsaValue);
        /// <summary> Databricks. </summary>
        public static ReservedResourceType Databricks { get; } = new ReservedResourceType(DatabricksValue);
        /// <summary> AppService. </summary>
        public static ReservedResourceType AppService { get; } = new ReservedResourceType(AppServiceValue);
        /// <summary> ManagedDisk. </summary>
        public static ReservedResourceType ManagedDisk { get; } = new ReservedResourceType(ManagedDiskValue);
        /// <summary> BlockBlob. </summary>
        public static ReservedResourceType BlockBlob { get; } = new ReservedResourceType(BlockBlobValue);
        /// <summary> RedisCache. </summary>
        public static ReservedResourceType RedisCache { get; } = new ReservedResourceType(RedisCacheValue);
        /// <summary> AzureDataExplorer. </summary>
        public static ReservedResourceType AzureDataExplorer { get; } = new ReservedResourceType(AzureDataExplorerValue);
        /// <summary> MySql. </summary>
        public static ReservedResourceType MySql { get; } = new ReservedResourceType(MySqlValue);
        /// <summary> MariaDb. </summary>
        public static ReservedResourceType MariaDb { get; } = new ReservedResourceType(MariaDbValue);
        /// <summary> PostgreSql. </summary>
        public static ReservedResourceType PostgreSql { get; } = new ReservedResourceType(PostgreSqlValue);
        /// <summary> DedicatedHost. </summary>
        public static ReservedResourceType DedicatedHost { get; } = new ReservedResourceType(DedicatedHostValue);
        /// <summary> SapHana. </summary>
        public static ReservedResourceType SapHana { get; } = new ReservedResourceType(SapHanaValue);
        /// <summary> SqlAzureHybridBenefit. </summary>
        public static ReservedResourceType SqlAzureHybridBenefit { get; } = new ReservedResourceType(SqlAzureHybridBenefitValue);
        /// <summary> AVS. </summary>
        public static ReservedResourceType AVS { get; } = new ReservedResourceType(AVSValue);
        /// <summary> DataFactory. </summary>
        public static ReservedResourceType DataFactory { get; } = new ReservedResourceType(DataFactoryValue);
        /// <summary> NetAppStorage. </summary>
        public static ReservedResourceType NetAppStorage { get; } = new ReservedResourceType(NetAppStorageValue);
        /// <summary> AzureFiles. </summary>
        public static ReservedResourceType AzureFiles { get; } = new ReservedResourceType(AzureFilesValue);
        /// <summary> SqlEdge. </summary>
        public static ReservedResourceType SqlEdge { get; } = new ReservedResourceType(SqlEdgeValue);
        /// <summary> VirtualMachineSoftware. </summary>
        public static ReservedResourceType VirtualMachineSoftware { get; } = new ReservedResourceType(VirtualMachineSoftwareValue);
        /// <summary> Determines if two <see cref="ReservedResourceType"/> values are the same. </summary>
        public static bool operator ==(ReservedResourceType left, ReservedResourceType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ReservedResourceType"/> values are not the same. </summary>
        public static bool operator !=(ReservedResourceType left, ReservedResourceType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ReservedResourceType"/>. </summary>
        public static implicit operator ReservedResourceType(string value) => new ReservedResourceType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ReservedResourceType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ReservedResourceType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
