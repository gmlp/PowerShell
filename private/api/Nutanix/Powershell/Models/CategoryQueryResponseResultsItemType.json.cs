namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    public partial class CategoryQueryResponseResultsItemType
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
        /// Deserializes a Carbon.Json.JsonObject into a new instance of <see cref="CategoryQueryResponseResultsItemType" />.
        /// </summary>
        /// <param name="json">A Carbon.Json.JsonObject instance to deserialize from.</param>
        internal CategoryQueryResponseResultsItemType(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            _entityAnyReferenceList = If( json?.PropertyT<Carbon.Json.JsonArray>("entity_any_reference_list"), out var __jsonEntityAnyReferenceList) ? If( __jsonEntityAnyReferenceList, out var __v) ? new System.Func<Nutanix.Powershell.Models.IEntityReference[]>(()=> System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Select( __v, (__u)=> Nutanix.Powershell.Models.EntityReference.FromJson(__u)  ) ) )() : null : EntityAnyReferenceList;
            _filteredEntityCount = If( json?.PropertyT<Carbon.Json.JsonNumber>("filtered_entity_count"), out var __jsonFilteredEntityCount) ? (long?)__jsonFilteredEntityCount : FilteredEntityCount;
            _kind = If( json?.PropertyT<Carbon.Json.JsonString>("kind"), out var __jsonKind) ? (string)__jsonKind : (string)Kind;
            _totalEntityCount = If( json?.PropertyT<Carbon.Json.JsonNumber>("total_entity_count"), out var __jsonTotalEntityCount) ? (long?)__jsonTotalEntityCount : TotalEntityCount;
            AfterFromJson(json);
        }
        /// <summary>
        /// Deserializes a <see cref="Carbon.Json.JsonNode"/> into an instance of Nutanix.Powershell.Models.ICategoryQueryResponseResultsItemType.
        /// </summary>
        /// <param name="node">a <see cref="Carbon.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Nutanix.Powershell.Models.ICategoryQueryResponseResultsItemType.</returns>
        public static Nutanix.Powershell.Models.ICategoryQueryResponseResultsItemType FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new CategoryQueryResponseResultsItemType(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="CategoryQueryResponseResultsItemType" /> into a <see cref="Carbon.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Carbon.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Rest.ClientRuntime."/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="CategoryQueryResponseResultsItemType" /> as a <see cref="Carbon.Json.JsonNode" />.
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
            if (null != EntityAnyReferenceList)
            {
                var __w = new Carbon.Json.XNodeArray();
                foreach( var __x in EntityAnyReferenceList )
                {
                    AddIf(__x?.ToJson(null) ,__w.Add);
                }
                container.Add("entity_any_reference_list",__w);
            }
            AddIf( null != FilteredEntityCount ? (Carbon.Json.JsonNode)new Carbon.Json.JsonNumber((long)FilteredEntityCount) : null, "filtered_entity_count" ,container.Add );
            AddIf( null != Kind ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(Kind) : null, "kind" ,container.Add );
            AddIf( null != TotalEntityCount ? (Carbon.Json.JsonNode)new Carbon.Json.JsonNumber((long)TotalEntityCount) : null, "total_entity_count" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}