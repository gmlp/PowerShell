namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Range of TCP/UDP ports.</summary>
    public partial class PortRange : Nutanix.Powershell.Models.IPortRange
    {
        /// <summary>Backing field for <see cref="EndPort" /> property.</summary>
        private int? _endPort;

        public int? EndPort
        {
            get
            {
                return this._endPort;
            }
            set
            {
                this._endPort = value;
            }
        }
        /// <summary>Backing field for <see cref="StartPort" /> property.</summary>
        private int? _startPort;

        public int? StartPort
        {
            get
            {
                return this._startPort;
            }
            set
            {
                this._startPort = value;
            }
        }
        /// <summary>Creates an new <see cref="PortRange" /> instance.</summary>
        public PortRange()
        {
        }
    }
    /// Range of TCP/UDP ports.
    public partial interface IPortRange : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        int? EndPort { get; set; }
        int? StartPort { get; set; }
    }
}