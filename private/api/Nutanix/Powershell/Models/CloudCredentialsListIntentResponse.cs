namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>Response object for intentful operation of cloud_credentialss</summary>
    public partial class CloudCredentialsListIntentResponse : Nutanix.Powershell.Models.ICloudCredentialsListIntentResponse, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="ApiVersion" /> property.</summary>
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
        /// <summary>Backing field for <see cref="Entities" /> property.</summary>
        private Nutanix.Powershell.Models.ICloudCredentialsIntentResource[] _entities;

        public Nutanix.Powershell.Models.ICloudCredentialsIntentResource[] Entities
        {
            get
            {
                return this._entities;
            }
            set
            {
                this._entities = value;
            }
        }
        /// <summary>Backing field for <see cref="Metadata" /> property.</summary>
        private Nutanix.Powershell.Models.ICloudCredentialsListMetadataOutput _metadata;

        /// <summary>
        /// All api calls that return a list will have this metadata block
        /// </summary>
        public Nutanix.Powershell.Models.ICloudCredentialsListMetadataOutput Metadata
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
        /// <summary>Creates an new <see cref="CloudCredentialsListIntentResponse" /> instance.</summary>
        public CloudCredentialsListIntentResponse()
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
            await eventListener.AssertNotNull(nameof(ApiVersion),ApiVersion);
            if (Entities != null ) {
                    for (int __i = 0; __i < Entities.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"Entities[{__i}]", Entities[__i]);
                    }
                  }
            await eventListener.AssertNotNull(nameof(Metadata), Metadata);
            await eventListener.AssertObjectIsValid(nameof(Metadata), Metadata);
        }
    }
    /// Response object for intentful operation of cloud_credentialss
    public partial interface ICloudCredentialsListIntentResponse : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string ApiVersion { get; set; }
        Nutanix.Powershell.Models.ICloudCredentialsIntentResource[] Entities { get; set; }
        Nutanix.Powershell.Models.ICloudCredentialsListMetadataOutput Metadata { get; set; }
    }
}