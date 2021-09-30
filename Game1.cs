using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace simplePlatformer
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Sprite playerSprite;

        List<Sprite> platformList = new List<Sprite>();

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            Texture2D platform=Content.Load<Texture2D>("platform");
            Texture2D player;
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            player=Content.Load<Texture2D>("player");
            
            playerSprite=new Sprite(player, new Rectangle(100,80,50,50));
            platformList.Add(new Sprite(platform, new Rectangle(50,200,300,20)));
            platformList.Add(new Sprite(platform, new Rectangle(430, 150, 200, 20)));
            platformList.Add(new Sprite(platform, new Rectangle(600, 100, 200, 20)));
            
        }

        protected override void Update(GameTime gameTime)
        {
            int fallSpeed=1;
            foreach(Sprite p in platformList) {
                if(playerSprite.SpriteRect.Intersects(p.SpriteRect)) {
                    fallSpeed=0;
                }
            }

            playerSprite.SpriteRect=new Rectangle(playerSprite.SpriteRect.X,
                    playerSprite.SpriteRect.Y+fallSpeed,playerSprite.SpriteRect.Width,playerSprite.SpriteRect.Height);

            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            if(playerSprite.SpriteRect.Y>800)
                Exit();

            playerSprite.Update();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();
            playerSprite.Draw(_spriteBatch);
            foreach(Sprite p in platformList) {
                _spriteBatch.Draw(p.SpriteTexture, p.SpriteRect, Color.White);
            }
            
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
