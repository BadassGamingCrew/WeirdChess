﻿// <auto-generated/>
namespace WeirdChess.Interfaces
{
    /// <summary>
    /// An interface for Setting objects
    /// </summary>
    /// <typeparam name="T">The type for the object saved within the Value property</typeparam>
    public interface ISetting<T>
    {
        /// <summary>
        /// The name of the setting. Specified through the object constructor.
        /// </summary>
        string Name { get; }
        /// <summary>
        /// The value of the setting object.
        /// </summary>
        T Value { get; set; }
    }
}
