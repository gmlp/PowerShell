namespace Nutanix.Powershell.Models
{

    /// <summary>
    /// Indicates which device a VM should boot from.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(VmBootConfigTypeConverter))]
    public partial class VmBootConfig
    {

        /// <summary>
        /// Creates a new instance of <see cref="VmBootConfig" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Nutanix.Powershell.Models.IVmBootConfig FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Indicates which device a VM should boot from.
    [System.ComponentModel.TypeConverter(typeof(VmBootConfigTypeConverter))]
    public partial interface IVmBootConfig {

    }
}