namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>IP config.</summary>
    public partial class IpConfig
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
        /// Deserializes a <see cref="Carbon.Json.JsonNode"/> into an instance of Nutanix.Powershell.Models.IIpConfig.
        /// </summary>
        /// <param name="node">a <see cref="Carbon.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Nutanix.Powershell.Models.IIpConfig.</returns>
        public static Nutanix.Powershell.Models.IIpConfig FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new IpConfig(json) : null;
        }
        /// <summary>
        /// Deserializes a Carbon.Json.JsonObject into a new instance of <see cref="IpConfig" />.
        /// </summary>
        /// <param name="json">A Carbon.Json.JsonObject instance to deserialize from.</param>
        internal IpConfig(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            _defaultGatewayIp = If( json?.PropertyT<Carbon.Json.JsonString>("default_gateway_ip"), out var __jsonDefaultGatewayIp) ? (string)__jsonDefaultGatewayIp : (string)DefaultGatewayIp;
            _dhcpOptions = If( json?.PropertyT<Carbon.Json.JsonObject>("dhcp_options"), out var __jsonDhcpOptions) ? Nutanix.Powershell.Models.DhcpOptions.FromJson(__jsonDhcpOptions) : DhcpOptions;
            _dhcpServerAddress = If( json?.PropertyT<Carbon.Json.JsonObject>("dhcp_server_address"), out var __jsonDhcpServerAddress) ? Nutanix.Powershell.Models.Address.FromJson(__jsonDhcpServerAddress) : DhcpServerAddress;
            _poolList = If( json?.PropertyT<Carbon.Json.JsonArray>("pool_list"), out var __jsonPoolList) ? If( __jsonPoolList, out var __v) ? new System.Func<Nutanix.Powershell.Models.IIpPool[]>(()=> System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Select( __v, (__u)=> Nutanix.Powershell.Models.IpPool.FromJson(__u)  ) ) )() : null : PoolList;
            _prefixLength = If( json?.PropertyT<Carbon.Json.JsonNumber>("prefix_length"), out var __jsonPrefixLength) ? (int?)__jsonPrefixLength : PrefixLength;
            _subnetIp = If( json?.PropertyT<Carbon.Json.JsonString>("subnet_ip"), out var __jsonSubnetIp) ? (string)__jsonSubnetIp : (string)SubnetIp;
            AfterFromJson(json);
        }
        /// <summary>
        /// Serializes this instance of <see cref="IpConfig" /> into a <see cref="Carbon.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Carbon.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Rest.ClientRuntime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="IpConfig" /> as a <see cref="Carbon.Json.JsonNode" />.
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
            AddIf( null != DefaultGatewayIp ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(DefaultGatewayIp) : null, "default_gateway_ip" ,container.Add );
            AddIf( null != DhcpOptions ? (Carbon.Json.JsonNode) DhcpOptions.ToJson(null) : null, "dhcp_options" ,container.Add );
            AddIf( null != DhcpServerAddress ? (Carbon.Json.JsonNode) DhcpServerAddress.ToJson(null) : null, "dhcp_server_address" ,container.Add );
            if (null != PoolList)
            {
                var __w = new Carbon.Json.XNodeArray();
                foreach( var __x in PoolList )
                {
                    AddIf(__x?.ToJson(null) ,__w.Add);
                }
                container.Add("pool_list",__w);
            }
            AddIf( null != PrefixLength ? (Carbon.Json.JsonNode)new Carbon.Json.JsonNumber((int)PrefixLength) : null, "prefix_length" ,container.Add );
            AddIf( null != SubnetIp ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(SubnetIp) : null, "subnet_ip" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}