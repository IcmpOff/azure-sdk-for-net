// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The properties of a DataTransfer Job
    /// </summary>
    public partial class DataTransferJobProperties
    {
        /// <summary>
        /// Initializes a new instance of the DataTransferJobProperties class.
        /// </summary>
        public DataTransferJobProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataTransferJobProperties class.
        /// </summary>
        /// <param name="source">Source DataStore details</param>
        /// <param name="destination">Destination DataStore details</param>
        /// <param name="jobName">Job Name</param>
        /// <param name="status">Job Status</param>
        /// <param name="percentageComplete">Percentage of completion.</param>
        /// <param name="lastUpdatedUtcTime">Last Updated Time (ISO-8601
        /// format).</param>
        /// <param name="workerCount">Worker count</param>
        /// <param name="error">Error response for Faulted job</param>
        public DataTransferJobProperties(DataTransferDataSourceSink source, DataTransferDataSourceSink destination, string jobName = default(string), string status = default(string), double? percentageComplete = default(double?), System.DateTime? lastUpdatedUtcTime = default(System.DateTime?), int? workerCount = default(int?), ErrorResponse error = default(ErrorResponse))
        {
            JobName = jobName;
            Source = source;
            Destination = destination;
            Status = status;
            PercentageComplete = percentageComplete;
            LastUpdatedUtcTime = lastUpdatedUtcTime;
            WorkerCount = workerCount;
            Error = error;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets job Name
        /// </summary>
        [JsonProperty(PropertyName = "jobName")]
        public string JobName { get; private set; }

        /// <summary>
        /// Gets or sets source DataStore details
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public DataTransferDataSourceSink Source { get; set; }

        /// <summary>
        /// Gets or sets destination DataStore details
        /// </summary>
        [JsonProperty(PropertyName = "destination")]
        public DataTransferDataSourceSink Destination { get; set; }

        /// <summary>
        /// Gets job Status
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; private set; }

        /// <summary>
        /// Gets percentage of completion.
        /// </summary>
        [JsonProperty(PropertyName = "percentageComplete")]
        public double? PercentageComplete { get; private set; }

        /// <summary>
        /// Gets last Updated Time (ISO-8601 format).
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdatedUtcTime")]
        public System.DateTime? LastUpdatedUtcTime { get; private set; }

        /// <summary>
        /// Gets or sets worker count
        /// </summary>
        [JsonProperty(PropertyName = "workerCount")]
        public int? WorkerCount { get; set; }

        /// <summary>
        /// Gets error response for Faulted job
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public ErrorResponse Error { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Source == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Source");
            }
            if (Destination == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Destination");
            }
            if (WorkerCount != null)
            {
                if (WorkerCount < 0)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "WorkerCount", 0);
                }
            }
        }
    }
}
