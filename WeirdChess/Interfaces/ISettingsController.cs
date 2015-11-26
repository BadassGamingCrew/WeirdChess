﻿// <auto-generated />
namespace WeirdChess.Interfaces
{
    /// <summary>
    /// Interface for Settings Controller objects
    /// </summary>
    public interface ISettingsController
    {
        /// <summary>
        /// Property containing the current settings, specified in the settings init file.
        /// If the init file does not exist, it is created with the default values and the same are loaded in the ISettings object.
        /// </summary>
        ISettings Settings { get; }
        /// <summary>
        /// Saves the current ISettings object, using the ISerialisationTool object.
        /// The save only occurs if the new settings are different than the old ones.
        /// </summary>
        void SaveSettings();
    }
}
