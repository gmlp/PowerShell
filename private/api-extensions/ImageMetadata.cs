namespace Nutanix.Powershell.Models
{

    /// <summary>The image kind metadata</summary>
    [System.ComponentModel.TypeConverter(typeof(ImageMetadataTypeConverter))]
    public partial class ImageMetadata
    {

        /// <summary>
        /// Creates a new instance of <see cref="ImageMetadata" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Nutanix.Powershell.Models.IImageMetadata FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The image kind metadata
    [System.ComponentModel.TypeConverter(typeof(ImageMetadataTypeConverter))]
    public partial interface IImageMetadata {

    }
}