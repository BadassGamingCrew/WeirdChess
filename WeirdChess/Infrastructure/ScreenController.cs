using WeirdChess.Exceptions;
using WeirdChess.Utilities;

namespace WeirdChess.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using Microsoft.Xna.Framework;
    using WeirdChess.Enums;
    using WeirdChess.Interfaces;

    public class ScreenController : GameComponent, IScreenController
    {
        private readonly IDictionary<GameScreenType, IGameScreen> screens;  

        /// <summary>
        /// Screen controller, which handles all Game Screens.
        /// </summary>
        /// <param name="game">Game Engine</param>
        public ScreenController(Game game)
            : base(game)
        {
            this.screens = new Dictionary<GameScreenType, IGameScreen>();
        }

        public IIterator<IGameScreen> GetIterator()
        {
            return new Iterator<IGameScreen>(this.screens.Values);
        }

        public void SetScreen(GameScreenType screenType, IGameScreen gameScreen)
        {
            if (gameScreen.Type != screenType)
            {
                throw new GameScreenTypeException("gameScreen", "The screen is not the same type.");
            }
            this.screens[screenType] = gameScreen;
        }

        public void AddScreen(GameScreenType screenType, IGameScreen gameScreen)
        {
            if (this.Contains(screenType))
            {
                throw new GameScreenTypeException("gameScreen", "The screen already exists.");
            }

            this.screens[screenType] = gameScreen;
        }

        public IGameScreen DeleteScreen(GameScreenType screenType)
        {
            if (!this.Contains(screenType))
            {
                throw new GameScreenTypeException("screenType", "There is no such screen.");
            }

            var screen = this.screens[screenType];
            this.screens.Remove(screenType);
            return screen;
        }

        public IGameScreen GetScreen(GameScreenType screenType)
        {
            if (!this.Contains(screenType))
            {
                throw new GameScreenTypeException("screenType", "There is no such screen.");
            }

            return this.screens[screenType];
        }

        public bool Contains(GameScreenType screenType)
        {
            return this.screens.ContainsKey(screenType);
        }
    }
}
