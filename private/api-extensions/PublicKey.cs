namespace Nutanix.Powershell.Models
{

    /// <summary>Public Key</summary>
    [System.ComponentModel.TypeConverter(typeof(PublicKeyTypeConverter))]
    public partial class PublicKey
    {

        /// <summary>
        /// Creates a new instance of <see cref="PublicKey" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Nutanix.Powershell.Models.IPublicKey FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Public Key
    [System.ComponentModel.TypeConverter(typeof(PublicKeyTypeConverter))]
    public partial interface IPublicKey {

    }
}