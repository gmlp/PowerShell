namespace Nutanix.Powershell.Models
{

    /// <summary>
    /// The status of a REST API call. Only used when there is a failure to
    /// report.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(CloudCredentialsStatusTypeConverter))]
    public partial class CloudCredentialsStatus
    {

        /// <summary>
        /// Creates a new instance of <see cref="CloudCredentialsStatus" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Nutanix.Powershell.Models.ICloudCredentialsStatus FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The status of a REST API call. Only used when there is a failure to
    /// report.
    [System.ComponentModel.TypeConverter(typeof(CloudCredentialsStatusTypeConverter))]
    public partial interface ICloudCredentialsStatus {

    }
}