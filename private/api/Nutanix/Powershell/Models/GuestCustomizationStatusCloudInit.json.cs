namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// If this field is set, the guest will be customized using cloud-init. Either user_data or custom_key_values should be provided.
    /// If custom_key_ves are provided then the user data will be generated using these key-value pairs.
    /// </summary>
    public partial class GuestCustomizationStatusCloudInit
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        partial void AfterFromJson(Carbon.Json.JsonObject json);
        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Carbon.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        partial void AfterToJson(ref Carbon.Json.JsonObject container);
        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>
        partial void BeforeFromJson(Carbon.Json.JsonObject json, ref bool returnNow);
        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>
        partial void BeforeToJson(ref Carbon.Json.JsonObject container, ref bool returnNow);
        /// <summary>
        /// Deserializes a <see cref="Carbon.Json.JsonNode"/> into an instance of Nutanix.Powershell.Models.IGuestCustomizationStatusCloudInit.
        /// </summary>
        /// <param name="node">a <see cref="Carbon.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Nutanix.Powershell.Models.IGuestCustomizationStatusCloudInit.</returns>
        public static Nutanix.Powershell.Models.IGuestCustomizationStatusCloudInit FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new GuestCustomizationStatusCloudInit(json) : null;
        }
        /// <summary>
        /// Deserializes a Carbon.Json.JsonObject into a new instance of <see cref="GuestCustomizationStatusCloudInit" />.
        /// </summary>
        /// <param name="json">A Carbon.Json.JsonObject instance to deserialize from.</param>
        internal GuestCustomizationStatusCloudInit(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            _customKeyValues = null /* deserializeFromContainerMember (wildcard) doesn't support 'application/json' C:\Users\hugo1\Documents\autorest\autorest.incubator\dist\csharp\schema\wildcard.js*/;
            _metaData = If( json?.PropertyT<Carbon.Json.JsonString>("meta_data"), out var __jsonMetaData) ? (string)__jsonMetaData : (string)MetaData;
            _userData = If( json?.PropertyT<Carbon.Json.JsonString>("user_data"), out var __jsonUserData) ? (string)__jsonUserData : (string)UserData;
            AfterFromJson(json);
        }
        /// <summary>
        /// Serializes this instance of <see cref="GuestCustomizationStatusCloudInit" /> into a <see cref="Carbon.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Carbon.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Rest.ClientRuntime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="GuestCustomizationStatusCloudInit" /> as a <see cref="Carbon.Json.JsonNode" />.
        /// </returns>
        public Carbon.Json.JsonNode ToJson(Carbon.Json.JsonObject container, Microsoft.Rest.ClientRuntime.SerializationMode serializationMode)
        {
            container = container ?? new Carbon.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            /* serializeToContainerMember (wildcard) doesn't support 'application/json' C:\Users\hugo1\Documents\autorest\autorest.incubator\dist\csharp\schema\wildcard.js*/
            AddIf( null != MetaData ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(MetaData) : null, "meta_data" ,container.Add );
            AddIf( null != UserData ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(UserData) : null, "user_data" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}