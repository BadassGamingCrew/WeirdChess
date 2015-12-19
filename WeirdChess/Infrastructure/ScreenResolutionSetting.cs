// auto-generated />
namespace WeirdChess.Infrastructure
{
    using Enums;
    using Utilities;
    /// <summary>
    /// Concrete class for ScreenResolution ISetting objects
    /// </summary>
    public class ScreenResolutionSetting : Setting
    {
        private static readonly SettingType SettingType = SettingType.ScreenResolution;
        private static readonly string DefaultValue = AllowedSettings.ScreenResolutionValues[0];
        private static readonly string ValueErrorMessage = Messages.InvalidScreenResolutionSetting;
        /// <summary>
        /// Default constructor with no parameters.
        /// Creates an object using the DefaultValue constant.
        /// </summary>
        public ScreenResolutionSetting()
            : this(null)
        {
            // TODO: Remove null values from constructor to implement
        }
        /// <summary>
        /// Constructor which takes a value parameter.
        /// </summary>
        /// <param name="value">The value for the ScreenResolution object.</param>
        public ScreenResolutionSetting(string value)
            : base(default(SettingType), null, null, null)
        {
            // TODO: Remove null values from constructor to implement
        }
    }
}
