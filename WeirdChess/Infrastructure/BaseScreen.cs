using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using WeirdChess.Core;
using WeirdChess.Enums;
using WeirdChess.Interfaces;

namespace WeirdChess.Infrastructure
{
    public abstract class BaseScreen : DrawableGameComponent, IGameScreen
    {

        protected BaseScreen(Game game, GameScreenType type) 
            : base(game)
        {
            this.Type = type;
            this.Engine = game as GameEngine;
        }

        public GameEngine Engine { get; private set; }

        public GameScreenType Type { get; private set; }

        public bool Displayed { get; set; }

        public override void Initialize()
        {
            base.Initialize();
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }
    }
}
