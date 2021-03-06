namespace Nutanix.Powershell.Models
{

    /// <summary>
    /// A PowerShell PSTypeConverter to support converting to an instance of <see cref="CitrixResourceLocation" />
    /// </summary>
    public class CitrixResourceLocationTypeConverter : System.Management.Automation.PSTypeConverter
    {

        /// <summary>
        /// Determines if the converter can convert the <see cref="sourceValue"/> parameter to the <see cref="destinationType" />
        /// parameter.
        /// </summary>
        /// <param name="sourceValue">the <see cref="System.Object"/> to convert from</param>
        /// <param name="destinationType">the <see cref="System.Type" /> to convert to</param>
        /// <returns>
        /// <c>true</c> if the converter can convert the <see cref="sourceValue"/> parameter to the <see cref="destinationType" />
        /// parameter, otherwise <c>false</c>.
        /// </returns>
        public override bool CanConvertFrom(object sourceValue, System.Type destinationType) => CanConvertFrom(sourceValue);
        /// <summary>
        /// Determines if the converter can convert the <see cref="sourceValue"/> parameter to the <see cref="destinationType" />
        /// parameter.
        /// </summary>
        /// <param name="sourceValue">the <see cref="System.Object" /> instance to check if it can be converted to the <see cref="CitrixResourceLocation"
        /// /> type.</param>
        /// <returns>
        /// <c>true</c> if the instance could be converted to a <see cref="CitrixResourceLocation" /> type, otherwise <c>false</c>
        /// </returns>
        public static bool CanConvertFrom(dynamic sourceValue)
        {
            if (null == sourceValue)
            {
                return true;
            }
            try
            {
                if (sourceValue.GetType() == typeof(System.Management.Automation.PSObject))
                {
                    // does it have the properties we need
                }
                else if (sourceValue.GetType() == typeof(System.Collections.Hashtable))
                {
                    // a hashtable?
                }
                else
                {
                    // object
                }
            }
            catch
            {
                // Unable to use JSON pattern
            }
            return false;
        }
        /// <summary>
        /// Determines if the <see cref="sourceValue" /> parameter can be converted to the <see cref="destinationType" /> parameter
        /// </summary>
        /// <param name="sourceValue">the <see cref="System.Object"/> to convert from</param>
        /// <param name="destinationType">the <see cref="System.Type" /> to convert to</param>
        /// <returns>
        /// <c>true</c> if the converter can convert the <see cref="sourceValue" /> parameter to the <see cref="destinationType" />
        /// parameter, otherwise <c>false</c>
        /// </returns>
        public override bool CanConvertTo(object sourceValue, System.Type destinationType) => false;
        /// <summary>
        /// Converts the <see cref="sourceValue" /> parameter to the <see cref="destinationType" /> parameter using <see cref="formatProvider"
        /// /> and <see cref="ignoreCase" />
        /// </summary>
        /// <param name="sourceValue">the <see cref="System.Object"/> to convert from</param>
        /// <param name="destinationType">the <see cref="System.Type" /> to convert to</param>
        /// <param name="formatProvider">not used by this TypeConverter.</param>
        /// <param name="ignoreCase">when set to <c>true</c>, will ignore the case when converting.</param>
        /// <returns>
        /// an instance of <see cref="CitrixResourceLocation" />, or <c>null</c> if there is no suitable conversion.
        /// </returns>
        public override object ConvertFrom(object sourceValue, System.Type destinationType, System.IFormatProvider formatProvider, bool ignoreCase) => ConvertFrom(sourceValue);
        /// <summary>
        /// Converts the <see cref="sourceValue" /> parameter to the <see cref="destinationType" /> parameter using <see cref="formatProvider"
        /// /> and <see cref="ignoreCase" />
        /// </summary>
        /// <param name="sourceValue">the value to convert into an instance of <see cref="CitrixResourceLocation" />.</param>
        /// <returns>
        /// an instance of <see cref="CitrixResourceLocation" />, or <c>null</c> if there is no suitable conversion.
        /// </returns>
        public static object ConvertFrom(dynamic sourceValue)
        {
            if (null == sourceValue)
            {
                return null;
            }
            try
            {
                CitrixResourceLocation.FromJsonString(typeof(string) == sourceValue.GetType() ? sourceValue : sourceValue.ToJsonString());
            }
            catch
            {
                // Unable to use JSON pattern
            }
            try
            {
                return new CitrixResourceLocation
                {
                Name = sourceValue.Name,
                Id = sourceValue.Id,
                };
            }
            catch
            {
            }
            return null;
        }
        /// <summary>NotImplemented -- this will return <c>null</c></summary>
        /// <param name="sourceValue">the <see cref="System.Object"/> to convert from</param>
        /// <param name="destinationType">the <see cref="System.Type" /> to convert to</param>
        /// <param name="formatProvider">not used by this TypeConverter.</param>
        /// <param name="ignoreCase">when set to <c>true</c>, will ignore the case when converting.</param>
        /// <returns>will always return <c>null</c>.</returns>
        public override object ConvertTo(object sourceValue, System.Type destinationType, System.IFormatProvider formatProvider, bool ignoreCase) => null;
    }
}