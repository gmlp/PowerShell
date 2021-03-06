namespace Nutanix.Powershell.Models
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    /// <summary>
    /// Specify the cluster and image(s) from the cluster to migrate to PC
    /// </summary>
    public partial class ImageMigrateInput : Nutanix.Powershell.Models.IImageMigrateInput, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for <see cref="ClusterReference" /> property.</summary>
        private Nutanix.Powershell.Models.IClusterReference _clusterReference;

        /// <summary>
        /// Reference to the PE cluster that currently owns images to be migrated.
        /// </summary>
        public Nutanix.Powershell.Models.IClusterReference ClusterReference
        {
            get
            {
                return this._clusterReference;
            }
            set
            {
                this._clusterReference = value;
            }
        }
        /// <summary>Backing field for <see cref="ImageReferenceList" /> property.</summary>
        private Nutanix.Powershell.Models.IImageReference[] _imageReferenceList;

        /// <summary>
        /// Reference to the images from PE cluster to be migrated
        /// </summary>
        public Nutanix.Powershell.Models.IImageReference[] ImageReferenceList
        {
            get
            {
                return this._imageReferenceList;
            }
            set
            {
                this._imageReferenceList = value;
            }
        }
        /// <summary>Creates an new <see cref="ImageMigrateInput" /> instance.</summary>
        public ImageMigrateInput()
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
            await eventListener.AssertNotNull(nameof(ClusterReference), ClusterReference);
            await eventListener.AssertObjectIsValid(nameof(ClusterReference), ClusterReference);
            if (ImageReferenceList != null ) {
                    for (int __i = 0; __i < ImageReferenceList.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"ImageReferenceList[{__i}]", ImageReferenceList[__i]);
                    }
                  }
        }
    }
    /// Specify the cluster and image(s) from the cluster to migrate to PC
    public partial interface IImageMigrateInput : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Nutanix.Powershell.Models.IClusterReference ClusterReference { get; set; }
        Nutanix.Powershell.Models.IImageReference[] ImageReferenceList { get; set; }
    }
}