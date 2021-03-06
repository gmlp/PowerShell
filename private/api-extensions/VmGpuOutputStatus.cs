namespace Nutanix.Powershell.Models
{

    /// <summary>Graphics resource status information for the Virtual Machine.</summary>
    [System.ComponentModel.TypeConverter(typeof(VmGpuOutputStatusTypeConverter))]
    public partial class VmGpuOutputStatus
    {

        /// <summary>
        /// Creates a new instance of <see cref="VmGpuOutputStatus" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Nutanix.Powershell.Models.IVmGpuOutputStatus FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Graphics resource status information for the Virtual Machine.
    [System.ComponentModel.TypeConverter(typeof(VmGpuOutputStatusTypeConverter))]
    public partial interface IVmGpuOutputStatus {

    }
}