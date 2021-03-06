namespace Nutanix.Powershell.ModelCmdlets
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="VmRecoveryPointIntentInput" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"VmRecoveryPointIntentInputObject")]
    [System.Management.Automation.OutputType(typeof(Nutanix.Powershell.Models.IVmRecoveryPointIntentInput))]
    public class NewVmRecoveryPointIntentInputObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="VmRecoveryPointIntentInput" /></summary>
        private Nutanix.Powershell.Models.IVmRecoveryPointIntentInput _vmRecoveryPointIntentInput = new Nutanix.Powershell.Models.VmRecoveryPointIntentInput();
        /// <summary>HELP MESSAGE MISSING</summary>
        public string ApiVersion
        {
            set
            {
                _vmRecoveryPointIntentInput.ApiVersion = value;
            }
        }
        /// <summary>The vm_recovery_point kind metadata</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The vm_recovery_point kind metadata")]
        public Nutanix.Powershell.Models.IVmRecoveryPointMetadata Metadata
        {
            set
            {
                _vmRecoveryPointIntentInput.Metadata = value;
            }
        }
        /// <summary>The input object that defines a vm recovery point.</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The input object that defines a vm recovery point.")]
        public Nutanix.Powershell.Models.IVmRecoveryPoint Spec
        {
            set
            {
                _vmRecoveryPointIntentInput.Spec = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            _vmRecoveryPointIntentInput.ApiVersion = "3.1";
            WriteObject(_vmRecoveryPointIntentInput);
        }
    }
}