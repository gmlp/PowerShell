namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>An intentful representation of a subnet status</summary>
    public partial class SubnetDefStatus
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
        /// Deserializes a <see cref="Carbon.Json.JsonNode"/> into an instance of Nutanix.Powershell.Models.ISubnetDefStatus.
        /// </summary>
        /// <param name="node">a <see cref="Carbon.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Nutanix.Powershell.Models.ISubnetDefStatus.</returns>
        public static Nutanix.Powershell.Models.ISubnetDefStatus FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new SubnetDefStatus(json) : null;
        }
        /// <summary>
        /// Deserializes a Carbon.Json.JsonObject into a new instance of <see cref="SubnetDefStatus" />.
        /// </summary>
        /// <param name="json">A Carbon.Json.JsonObject instance to deserialize from.</param>
        internal SubnetDefStatus(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            _name = If( json?.PropertyT<Carbon.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)Name;
            _description = If( json?.PropertyT<Carbon.Json.JsonString>("description"), out var __jsonDescription) ? (string)__jsonDescription : (string)Description;
            _availabilityZoneReference = If( json?.PropertyT<Carbon.Json.JsonObject>("availability_zone_reference"), out var __jsonAvailabilityZoneReference) ? Nutanix.Powershell.Models.AvailabilityZoneReference.FromJson(__jsonAvailabilityZoneReference) : AvailabilityZoneReference;
            _clusterReference = If( json?.PropertyT<Carbon.Json.JsonObject>("cluster_reference"), out var __jsonClusterReference) ? Nutanix.Powershell.Models.ClusterReference.FromJson(__jsonClusterReference) : ClusterReference;
            _messageList = If( json?.PropertyT<Carbon.Json.JsonArray>("message_list"), out var __jsonMessageList) ? If( __jsonMessageList, out var __v) ? new System.Func<Nutanix.Powershell.Models.IMessageResource[]>(()=> System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Select( __v, (__u)=> Nutanix.Powershell.Models.MessageResource.FromJson(__u)  ) ) )() : null : MessageList;
            _resources = If( json?.PropertyT<Carbon.Json.JsonObject>("resources"), out var __jsonResources) ? Nutanix.Powershell.Models.SubnetResourcesDefStatus.FromJson(__jsonResources) : Resources;
            _state = If( json?.PropertyT<Carbon.Json.JsonString>("state"), out var __jsonState) ? (string)__jsonState : (string)State;
            AfterFromJson(json);
        }
        /// <summary>
        /// Serializes this instance of <see cref="SubnetDefStatus" /> into a <see cref="Carbon.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Carbon.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Rest.ClientRuntime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="SubnetDefStatus" /> as a <see cref="Carbon.Json.JsonNode" />.
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
            AddIf( null != Name ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(Name) : null, "name" ,container.Add );
            AddIf( null != Description ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(Description) : null, "description" ,container.Add );
            AddIf( null != AvailabilityZoneReference ? (Carbon.Json.JsonNode) AvailabilityZoneReference.ToJson(null) : null, "availability_zone_reference" ,container.Add );
            AddIf( null != ClusterReference ? (Carbon.Json.JsonNode) ClusterReference.ToJson(null) : null, "cluster_reference" ,container.Add );
            if (null != MessageList)
            {
                var __w = new Carbon.Json.XNodeArray();
                foreach( var __x in MessageList )
                {
                    AddIf(__x?.ToJson(null) ,__w.Add);
                }
                container.Add("message_list",__w);
            }
            AddIf( null != Resources ? (Carbon.Json.JsonNode) Resources.ToJson(null) : null, "resources" ,container.Add );
            AddIf( null != State ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(State) : null, "state" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}