namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Response object for intentful operations on a vm</summary>
    public partial class VmIntentResource : Nutanix.Powershell.Models.IVmIntentResource, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for ApiVersion property</summary>
        private string _apiVersion;

        public string ApiVersion
        {
            get
            {
                return this._apiVersion;
            }
            set
            {
                this._apiVersion = value;
            }
        }
        /// <summary>Backing field for Metadata property</summary>
        private Nutanix.Powershell.Models.IVmMetadata _metadata;

        /// <summary>The vm kind metadata</summary>
        public Nutanix.Powershell.Models.IVmMetadata Metadata
        {
            get
            {
                return this._metadata;
            }
            set
            {
                this._metadata = value;
            }
        }
        /// <summary>Backing field for Spec property</summary>
        private Nutanix.Powershell.Models.IVm _spec;

        /// <summary>An intentful representation of a vm spec</summary>
        public Nutanix.Powershell.Models.IVm Spec
        {
            get
            {
                return this._spec;
            }
            set
            {
                this._spec = value;
            }
        }
        /// <summary>Backing field for Status property</summary>
        private Nutanix.Powershell.Models.IVmDefStatus _status;

        /// <summary>An intentful representation of a vm status</summary>
        public Nutanix.Powershell.Models.IVmDefStatus Status
        {
            get
            {
                return this._status;
            }
            set
            {
                this._status = value;
            }
        }
        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Rest.ClientRuntime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async System.Threading.Tasks.Task Validate(Microsoft.Rest.ClientRuntime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(Metadata), Metadata);
            await eventListener.AssertObjectIsValid(nameof(Metadata), Metadata);
            await eventListener.AssertObjectIsValid(nameof(Spec), Spec);
            await eventListener.AssertObjectIsValid(nameof(Status), Status);
        }
        /// <summary>Creates an new <see cref="VmIntentResource" /> instance.</summary>
        public VmIntentResource()
        {
        }
    }
    /// Response object for intentful operations on a vm
    public partial interface IVmIntentResource : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string ApiVersion { get; set; }
        Nutanix.Powershell.Models.IVmMetadata Metadata { get; set; }
        Nutanix.Powershell.Models.IVm Spec { get; set; }
        Nutanix.Powershell.Models.IVmDefStatus Status { get; set; }
    }
}