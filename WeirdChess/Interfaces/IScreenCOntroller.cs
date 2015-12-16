﻿// <auto-generated />
namespace WeirdChess.Interfaces
{
    using Enums;
    using Exceptions;
    /// <summary>
    /// Interface for Screen Controller objects.
    /// Provides methods for managing the IGameScreen collection.
    /// Extends IComponent.
    /// Also provides an iterator for navigating between the different IGameScreen objects.
    /// </summary>
    public interface IScreenController : IComponent, IIterable<IGameScreen>
    {
        /// <summary>
        /// Changes the value for the GameScreenType argument, to the IGameScreen argument.
        /// </summary>
        /// <exception cref="GameScreenTypeException">Thrown if screenType value does not match the gameScreen.Type value</exception>
        /// <param name="screenType">The screen type for the IGameScreen that's to be replaced.</param>
        /// <param name="gameScreen">The new IGameScreen object</param>
        void SetScreen(GameScreenType screenType, IGameScreen gameScreen);
        /// <summary>
        /// Adds a new GameScreenType/IGameScreen pair to the IGameScreen collection.
        /// </summary>
        /// <exception cref="GameScreenTypeException">Thrown if the a pair with the same GameScreenType already exists.</exception>
        /// <param name="screenType">The GameScreenType value for the new pair.</param>
        /// <param name="gameScreen">The IGameScreen object for the new pair.</param>
        void AddScreen(GameScreenType screenType, IGameScreen gameScreen);
        /// <summary>
        /// Deletes the GameScreenType/IGameScreen pair, described by the screenType argument.
        /// </summary>
        /// <param name="screenType">The GameScreenType for the GameScreenType/IGameScreen pair that will be deleted.</param>
        /// <exception cref="GameScreenTypeException">Thrown if method is called and Contains(screenType) returns FALSE.</exception>
        /// <returns>Returns the IGameScreen object, from the deleted GameScreenType/IGameScreen pair.</returns>
        IGameScreen DeleteScreen(GameScreenType screenType);
        /// <summary>
        /// Attempts to get the IGameScreen object, paired with the GameScreenType argument.
        /// </summary>
        /// <exception cref="GameScreenTypeException">
        /// Thrown if the method is called and Contains(screenType) returns FALSE.
        /// </exception>
        /// <param name="screenType">The GameScreenType of the IGameScreen that's to be retrieved.</param>
        /// <returns>The IGameScreen object that's paired with the screenType argument.</returns>
        IGameScreen GetScreen(GameScreenType screenType);
        /// <summary>
        /// Checks whether the IGameScreen collection contains a pair, with the provided GameScreenType.
        /// </summary>
        /// <param name="screenType">The GameScreenType for the GameScreenType/IGameScreen pair.</param>
        /// <returns>
        /// True if the pair is found.
        /// False if the pair is not found. 
        /// </returns>
        bool Contains(GameScreenType screenType);
    }
}
