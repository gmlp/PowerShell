namespace Sample.API.Models
{

    /// <summary>Response object for intentful operations on a network_security_rule</summary>
    [System.ComponentModel.TypeConverter(typeof(NetworkSecurityRuleIntentResponseTypeConverter))]
    public partial class NetworkSecurityRuleIntentResponse
    {

        /// <summary>
        /// Creates a new instance of <see cref="NetworkSecurityRuleIntentResponse" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Sample.API.Models.INetworkSecurityRuleIntentResponse FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Response object for intentful operations on a network_security_rule
    [System.ComponentModel.TypeConverter(typeof(NetworkSecurityRuleIntentResponseTypeConverter))]
    public partial interface INetworkSecurityRuleIntentResponse {

    }
}