namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// These rules govern what flows are allowed. Target group is a required attribute. Empty inbound_allow_list will not anything
    /// into target group. Empty outbound_allow_list will allow everything from target group.
    /// </summary>
    public partial class NetworkSecurityRuleResourcesAppRule : Nutanix.Powershell.Models.INetworkSecurityRuleResourcesAppRule, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="Action" /> property.</summary>
        private string _action;

        /// <summary>Type of deployment of the rule.</summary>
        public string Action
        {
            get
            {
                return this._action;
            }
            set
            {
                this._action = value;
            }
        }
        /// <summary>Backing field for <see cref="InboundAllowList" /> property.</summary>
        private Nutanix.Powershell.Models.INetworkRule[] _inboundAllowList;

        public Nutanix.Powershell.Models.INetworkRule[] InboundAllowList
        {
            get
            {
                return this._inboundAllowList;
            }
            set
            {
                this._inboundAllowList = value;
            }
        }
        /// <summary>Backing field for <see cref="OutboundAllowList" /> property.</summary>
        private Nutanix.Powershell.Models.INetworkRule[] _outboundAllowList;

        public Nutanix.Powershell.Models.INetworkRule[] OutboundAllowList
        {
            get
            {
                return this._outboundAllowList;
            }
            set
            {
                this._outboundAllowList = value;
            }
        }
        /// <summary>Backing field for <see cref="TargetGroup" /> property.</summary>
        private Nutanix.Powershell.Models.ITargetGroup _targetGroup;

        /// <summary>Target group</summary>
        public Nutanix.Powershell.Models.ITargetGroup TargetGroup
        {
            get
            {
                return this._targetGroup;
            }
            set
            {
                this._targetGroup = value;
            }
        }
        /// <summary>Creates an new <see cref="NetworkSecurityRuleResourcesAppRule" /> instance.</summary>
        public NetworkSecurityRuleResourcesAppRule()
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
            if (InboundAllowList != null ) {
                    for (int __i = 0; __i < InboundAllowList.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"InboundAllowList[{__i}]", InboundAllowList[__i]);
                    }
                  }
            if (OutboundAllowList != null ) {
                    for (int __i = 0; __i < OutboundAllowList.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"OutboundAllowList[{__i}]", OutboundAllowList[__i]);
                    }
                  }
            await eventListener.AssertObjectIsValid(nameof(TargetGroup), TargetGroup);
        }
    }
    /// These rules govern what flows are allowed. Target group is a required attribute. Empty inbound_allow_list will not anything
    /// into target group. Empty outbound_allow_list will allow everything from target group.
    public partial interface INetworkSecurityRuleResourcesAppRule : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string Action { get; set; }
        Nutanix.Powershell.Models.INetworkRule[] InboundAllowList { get; set; }
        Nutanix.Powershell.Models.INetworkRule[] OutboundAllowList { get; set; }
        Nutanix.Powershell.Models.ITargetGroup TargetGroup { get; set; }
    }
}