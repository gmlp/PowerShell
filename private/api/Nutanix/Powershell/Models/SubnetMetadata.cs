namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>The subnet kind metadata</summary>
    public partial class SubnetMetadata : Nutanix.Powershell.Models.ISubnetMetadata, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="Categories" /> property.</summary>
        private System.Collections.Generic.IDictionary<string,string> _categories;

        /// <summary>Categories for the subnet</summary>
        public System.Collections.Generic.IDictionary<string,string> Categories
        {
            get
            {
                return this._categories;
            }
            set
            {
                this._categories = value;
            }
        }
        /// <summary>Backing field for <see cref="CreationTime" /> property.</summary>
        private System.DateTime? _creationTime;

        /// <summary>
        /// UTC date and time in RFC-3339 format when subnet was created
        /// </summary>
        public System.DateTime? CreationTime
        {
            get
            {
                return this._creationTime;
            }
            set
            {
                this._creationTime = value;
            }
        }
        /// <summary>Backing field for <see cref="Kind" /> property.</summary>
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
        /// <summary>Backing field for <see cref="LastUpdateTime" /> property.</summary>
        private System.DateTime? _lastUpdateTime;

        /// <summary>
        /// UTC date and time in RFC-3339 format when subnet was last updated
        /// </summary>
        public System.DateTime? LastUpdateTime
        {
            get
            {
                return this._lastUpdateTime;
            }
            set
            {
                this._lastUpdateTime = value;
            }
        }
        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>subnet name</summary>
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
        /// <summary>Backing field for <see cref="OwnerReference" /> property.</summary>
        private Nutanix.Powershell.Models.IUserReference _ownerReference;

        /// <summary>The reference to a user</summary>
        public Nutanix.Powershell.Models.IUserReference OwnerReference
        {
            get
            {
                return this._ownerReference;
            }
            set
            {
                this._ownerReference = value;
            }
        }
        /// <summary>Backing field for <see cref="ProjectReference" /> property.</summary>
        private Nutanix.Powershell.Models.IProjectReference _projectReference;

        /// <summary>The project the subnet is in.</summary>
        public Nutanix.Powershell.Models.IProjectReference ProjectReference
        {
            get
            {
                return this._projectReference;
            }
            set
            {
                this._projectReference = value;
            }
        }
        /// <summary>Backing field for <see cref="SpecHash" /> property.</summary>
        private string _specHash;

        /// <summary>
        /// Hash of the spec. This will be returned from server.
        /// </summary>
        public string SpecHash
        {
            get
            {
                return this._specHash;
            }
            set
            {
                this._specHash = value;
            }
        }
        /// <summary>Backing field for <see cref="SpecVersion" /> property.</summary>
        private int? _specVersion;

        /// <summary>Version number of the latest spec.</summary>
        public int? SpecVersion
        {
            get
            {
                return this._specVersion;
            }
            set
            {
                this._specVersion = value;
            }
        }
        /// <summary>Backing field for <see cref="Uuid" /> property.</summary>
        private string _uuid;

        /// <summary>subnet uuid</summary>
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
        /// <summary>Creates an new <see cref="SubnetMetadata" /> instance.</summary>
        public SubnetMetadata()
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
            await eventListener.AssertMaximumLength(nameof(Name),Name,64);
            await eventListener.AssertNotNull(nameof(Kind),Kind);
            await eventListener.AssertObjectIsValid(nameof(OwnerReference), OwnerReference);
            await eventListener.AssertObjectIsValid(nameof(ProjectReference), ProjectReference);
            await eventListener.AssertRegEx(nameof(Uuid),Uuid,@"^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$");
        }
    }
    /// The subnet kind metadata
    public partial interface ISubnetMetadata : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        System.Collections.Generic.IDictionary<string,string> Categories { get; set; }
        System.DateTime? CreationTime { get; set; }
        string Kind { get; set; }
        System.DateTime? LastUpdateTime { get; set; }
        string Name { get; set; }
        Nutanix.Powershell.Models.IUserReference OwnerReference { get; set; }
        Nutanix.Powershell.Models.IProjectReference ProjectReference { get; set; }
        string SpecHash { get; set; }
        int? SpecVersion { get; set; }
        string Uuid { get; set; }
    }
}