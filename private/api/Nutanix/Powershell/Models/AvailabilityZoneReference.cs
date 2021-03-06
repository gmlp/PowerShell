namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>The reference to a availability_zone</summary>
    public partial class AvailabilityZoneReference : Nutanix.Powershell.Models.IAvailabilityZoneReference, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for Kind property</summary>
        private string _kind;

        /// <summary>The kind name</summary>
        public string Kind
        {
            get
            {
                return this._kind;
            }
            set
            {
                this._kind = value;
            }
        }
        /// <summary>Backing field for Name property</summary>
        private string _name;

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        /// <summary>Backing field for Uuid property</summary>
        private string _uuid;

        public string Uuid
        {
            get
            {
                return this._uuid;
            }
            set
            {
                this._uuid = value;
            }
        }
        /// <summary>Creates an new <see cref="AvailabilityZoneReference" /> instance.</summary>
        public AvailabilityZoneReference()
        {
        }
        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Rest.ClientRuntime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async System.Threading.Tasks.Task Validate(Microsoft.Rest.ClientRuntime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(Kind),Kind);
            await eventListener.AssertNotNull(nameof(Uuid),Uuid);
            await eventListener.AssertRegEx(nameof(Uuid),Uuid,@"^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$");
        }
    }
    /// The reference to a availability_zone
    public partial interface IAvailabilityZoneReference : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string Kind { get; set; }
        string Name { get; set; }
        string Uuid { get; set; }
    }
}