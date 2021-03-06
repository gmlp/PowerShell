namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>SMTP Server.</summary>
    public partial class SmtpServer : Nutanix.Powershell.Models.ISmtpServer, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="EmailAddress" /> property.</summary>
        private string _emailAddress;

        public string EmailAddress
        {
            get
            {
                return this._emailAddress;
            }
            set
            {
                this._emailAddress = value;
            }
        }
        /// <summary>Backing field for <see cref="Server" /> property.</summary>
        private Nutanix.Powershell.Models.IClusterNetworkEntity _server;

        /// <summary>Cluster network entity.</summary>
        public Nutanix.Powershell.Models.IClusterNetworkEntity Server
        {
            get
            {
                return this._server;
            }
            set
            {
                this._server = value;
            }
        }
        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        public string Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
        /// <summary>Creates an new <see cref="SmtpServer" /> instance.</summary>
        public SmtpServer()
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
            await eventListener.AssertNotNull(nameof(EmailAddress),EmailAddress);
            await eventListener.AssertNotNull(nameof(Server), Server);
            await eventListener.AssertObjectIsValid(nameof(Server), Server);
        }
    }
    /// SMTP Server.
    public partial interface ISmtpServer : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string EmailAddress { get; set; }
        Nutanix.Powershell.Models.IClusterNetworkEntity Server { get; set; }
        string Type { get; set; }
    }
}