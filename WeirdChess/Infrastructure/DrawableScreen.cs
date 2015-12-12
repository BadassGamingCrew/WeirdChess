﻿// <auto-generated />
namespace WeirdChess.Infrastructure
{
    using System;
    using Microsoft.Xna.Framework.Graphics;
    using Interfaces;
    /// <summary>
    /// Abstract class for Drawable Screen objects. Implements IDrawable
    /// </summary>
    public abstract class DrawableScreen : IDrawable
    {
        private readonly IGameScreen gameScreen;
        private SpriteBatch spriteBatch;
        /// <summary>
        /// Constructor for the Drawable Screen objects. Takes IGameScreen and SpriteBatch as arguments
        /// </summary>
        /// <param name="gameScreen">The IGameScreen object associated with this DrawableScreen</param>
        /// <param name="spriteBatch">The SpriteBatch used for the Draw method</param>
        protected DrawableScreen(IGameScreen gameScreen, SpriteBatch spriteBatch)
        {
            this.gameScreen = gameScreen;
            this.UpdateSpriteBatch(spriteBatch);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="spriteBatch"></param>
        public void UpdateSpriteBatch(SpriteBatch spriteBatch)
        {
            this.spriteBatch = spriteBatch;
        }

        public void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
