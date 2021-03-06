namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>VM Resources Definition.</summary>
    public partial class VmResources
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
        /// Deserializes a <see cref="Carbon.Json.JsonNode"/> into an instance of Nutanix.Powershell.Models.IVmResources.
        /// </summary>
        /// <param name="node">a <see cref="Carbon.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Nutanix.Powershell.Models.IVmResources.</returns>
        public static Nutanix.Powershell.Models.IVmResources FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new VmResources(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="VmResources" /> into a <see cref="Carbon.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Carbon.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Rest.ClientRuntime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="VmResources" /> as a <see cref="Carbon.Json.JsonNode" />.
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
            AddIf( null != BootConfig ? (Carbon.Json.JsonNode) BootConfig.ToJson(null) : null, "boot_config" ,container.Add );
            if (null != DiskList)
            {
                var __x = new Carbon.Json.XNodeArray();
                foreach( var __y in DiskList )
                {
                    AddIf(__y?.ToJson(null) ,__x.Add);
                }
                container.Add("disk_list",__x);
            }
            if (null != GpuList)
            {
                var __s = new Carbon.Json.XNodeArray();
                foreach( var __t in GpuList )
                {
                    AddIf(__t?.ToJson(null) ,__s.Add);
                }
                container.Add("gpu_list",__s);
            }
            AddIf( null != GuestCustomization ? (Carbon.Json.JsonNode) GuestCustomization.ToJson(null) : null, "guest_customization" ,container.Add );
            AddIf( null != GuestOsId ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(GuestOsId) : null, "guest_os_id" ,container.Add );
            AddIf( null != GuestTools ? (Carbon.Json.JsonNode) GuestTools.ToJson(null) : null, "guest_tools" ,container.Add );
            AddIf( null != HardwareClockTimezone ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(HardwareClockTimezone) : null, "hardware_clock_timezone" ,container.Add );
            AddIf( null != MemorySizeMib ? (Carbon.Json.JsonNode)new Carbon.Json.JsonNumber((int)MemorySizeMib) : null, "memory_size_mib" ,container.Add );
            if (null != NicList)
            {
                var __n = new Carbon.Json.XNodeArray();
                foreach( var __o in NicList )
                {
                    AddIf(__o?.ToJson(null) ,__n.Add);
                }
                container.Add("nic_list",__n);
            }
            AddIf( null != NumSockets ? (Carbon.Json.JsonNode)new Carbon.Json.JsonNumber((int)NumSockets) : null, "num_sockets" ,container.Add );
            AddIf( null != NumVcpusPerSocket ? (Carbon.Json.JsonNode)new Carbon.Json.JsonNumber((int)NumVcpusPerSocket) : null, "num_vcpus_per_socket" ,container.Add );
            AddIf( null != ParentReference ? (Carbon.Json.JsonNode) ParentReference.ToJson(null) : null, "parent_reference" ,container.Add );
            AddIf( null != PowerState ? (Carbon.Json.JsonNode) new Carbon.Json.JsonString(PowerState) : null, "power_state" ,container.Add );
            AddIf( null != PowerStateMechanism ? (Carbon.Json.JsonNode) PowerStateMechanism.ToJson(null) : null, "power_state_mechanism" ,container.Add );
            AddIf( null != VgaConsoleEnabled ? (Carbon.Json.JsonNode)new Carbon.Json.JsonBoolean((bool)VgaConsoleEnabled) : null, "vga_console_enabled" ,container.Add );
            AddIf( null != VnumaConfig ? (Carbon.Json.JsonNode) VnumaConfig.ToJson(null) : null, "vnuma_config" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
        /// <summary>
        /// Deserializes a Carbon.Json.JsonObject into a new instance of <see cref="VmResources" />.
        /// </summary>
        /// <param name="json">A Carbon.Json.JsonObject instance to deserialize from.</param>
        internal VmResources(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            _bootConfig = If( json?.PropertyT<Carbon.Json.JsonObject>("boot_config"), out var __jsonBootConfig) ? Nutanix.Powershell.Models.VmBootConfig.FromJson(__jsonBootConfig) : BootConfig;
            _diskList = If( json?.PropertyT<Carbon.Json.JsonArray>("disk_list"), out var __jsonDiskList) ? If( __jsonDiskList, out var __w) ? new System.Func<Nutanix.Powershell.Models.IVmDisk[]>(()=> System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Select( __w, (__v)=> Nutanix.Powershell.Models.VmDisk.FromJson(__v)  ) ) )() : null : DiskList;
            _gpuList = If( json?.PropertyT<Carbon.Json.JsonArray>("gpu_list"), out var __jsonGpuList) ? If( __jsonGpuList, out var __r) ? new System.Func<Nutanix.Powershell.Models.IVmGpu[]>(()=> System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Select( __r, (__q)=> Nutanix.Powershell.Models.VmGpu.FromJson(__q)  ) ) )() : null : GpuList;
            _guestCustomization = If( json?.PropertyT<Carbon.Json.JsonObject>("guest_customization"), out var __jsonGuestCustomization) ? Nutanix.Powershell.Models.GuestCustomization.FromJson(__jsonGuestCustomization) : GuestCustomization;
            _guestOsId = If( json?.PropertyT<Carbon.Json.JsonString>("guest_os_id"), out var __jsonGuestOsId) ? (string)__jsonGuestOsId : (string)GuestOsId;
            _guestTools = If( json?.PropertyT<Carbon.Json.JsonObject>("guest_tools"), out var __jsonGuestTools) ? Nutanix.Powershell.Models.GuestToolsSpec.FromJson(__jsonGuestTools) : GuestTools;
            _hardwareClockTimezone = If( json?.PropertyT<Carbon.Json.JsonString>("hardware_clock_timezone"), out var __jsonHardwareClockTimezone) ? (string)__jsonHardwareClockTimezone : (string)HardwareClockTimezone;
            _memorySizeMib = If( json?.PropertyT<Carbon.Json.JsonNumber>("memory_size_mib"), out var __jsonMemorySizeMib) ? (int?)__jsonMemorySizeMib : MemorySizeMib;
            _nicList = If( json?.PropertyT<Carbon.Json.JsonArray>("nic_list"), out var __jsonNicList) ? If( __jsonNicList, out var __m) ? new System.Func<Nutanix.Powershell.Models.IVmNic[]>(()=> System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Select( __m, (__l)=> Nutanix.Powershell.Models.VmNic.FromJson(__l)  ) ) )() : null : NicList;
            _numSockets = If( json?.PropertyT<Carbon.Json.JsonNumber>("num_sockets"), out var __jsonNumSockets) ? (int?)__jsonNumSockets : NumSockets;
            _numVcpusPerSocket = If( json?.PropertyT<Carbon.Json.JsonNumber>("num_vcpus_per_socket"), out var __jsonNumVcpusPerSocket) ? (int?)__jsonNumVcpusPerSocket : NumVcpusPerSocket;
            _parentReference = If( json?.PropertyT<Carbon.Json.JsonObject>("parent_reference"), out var __jsonParentReference) ? Nutanix.Powershell.Models.Reference.FromJson(__jsonParentReference) : ParentReference;
            _powerState = If( json?.PropertyT<Carbon.Json.JsonString>("power_state"), out var __jsonPowerState) ? (string)__jsonPowerState : (string)PowerState;
            _powerStateMechanism = If( json?.PropertyT<Carbon.Json.JsonObject>("power_state_mechanism"), out var __jsonPowerStateMechanism) ? Nutanix.Powershell.Models.VmPowerStateMechanism.FromJson(__jsonPowerStateMechanism) : PowerStateMechanism;
            _vgaConsoleEnabled = If( json?.PropertyT<Carbon.Json.JsonBoolean>("vga_console_enabled"), out var __jsonVgaConsoleEnabled) ? (bool?)__jsonVgaConsoleEnabled : VgaConsoleEnabled;
            _vnumaConfig = If( json?.PropertyT<Carbon.Json.JsonObject>("vnuma_config"), out var __jsonVnumaConfig) ? Nutanix.Powershell.Models.VmVnumaConfig.FromJson(__jsonVnumaConfig) : VnumaConfig;
            AfterFromJson(json);
        }
    }
}