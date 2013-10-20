﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Pacman
{
    public class TitelScreen : GameScreen
    {
        KeyboardState keyState;
        SpriteFont font;

        FadeAnimation fade;
        Texture2D image;

        public override void LoadContent(ContentManager Content)
        {
            base.LoadContent(Content);
            fade = new FadeAnimation();
            image = content.Load<Texture2D>("TitelScreen/PacTitel");
            fade.LoadContent(content, image, "", Vector2.Zero);
            fade.Scale = 1.0f;
            fade.Active = false;
            fade.FadeSpeed = 1.0f;
        }

        public override void UnloadContent()
        {
            base.UnloadContent();
        }

        public override void Update(GameTime gameTime)
        {
            fade.Update(gameTime);
            keyState = Keyboard.GetState();
            if (keyState.IsKeyDown(Keys.Enter))
                ScreenManager.Instance.AddScreen(new MainMenu());
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            fade.Draw(spriteBatch);
        }
    }
}
