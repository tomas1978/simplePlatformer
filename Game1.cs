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
        Texture2D player;

        Texture2D platform;
        Rectangle platform1Rect;

        Texture2D platform2;
        Rectangle platform2Rect;

        List<Sprite> platformList = new List<Sprite>();

        public Game1()
        {
            platform1Rect=new Rectangle(50,200,300,20);
            platform2Rect=new Rectangle(430, 150, 200, 20);
            
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
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            player=Content.Load<Texture2D>("player");
            platform=Content.Load<Texture2D>("platform");
            platform2=Content.Load<Texture2D>("platform");
            playerSprite=new Sprite(player, new Rectangle(100,80,50,50));
            platformList.Add(new Sprite(platform, new Rectangle(50,200,300,20)));
            platformList.Add(new Sprite(platform, new Rectangle(430, 150, 200, 20)));
        }

        protected override void Update(GameTime gameTime)
        {
            bool onPlatform=true;
            foreach(Sprite p in platformList) {
                 if(!playerSprite.SpriteRect.Intersects(p.SpriteRect))
                    onPlatform=false;
            }

            //if(!playerSprite.SpriteRect.Intersects(platform1Rect) && ! playerSprite.SpriteRect.Intersects(platform2Rect)) {
            if(!onPlatform) {   
                playerSprite.SpriteRect=new Rectangle(playerSprite.SpriteRect.X,
                    playerSprite.SpriteRect.Y+2,playerSprite.SpriteRect.Width,playerSprite.SpriteRect.Height);

            }
                //playerSprite.SpriteRect.Y+=2;

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

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            playerSprite.Draw(_spriteBatch);
            //_spriteBatch.Draw(playerSprite.SpriteTexture, playerSprite.SpriteRect, Color.White);
            //_spriteBatch.Draw(platform, platform1Rect, Color.White);
            //_spriteBatch.Draw(platform2, platform2Rect, Color.White);
            foreach(Sprite p in platformList) {
                _spriteBatch.Draw(p.SpriteTexture, p.SpriteRect, Color.White);
            }
            
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
