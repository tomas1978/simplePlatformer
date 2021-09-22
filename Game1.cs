using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace simplePlatformer
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Sprite playerSprite;
        Texture2D player;

        Texture2D platform1;
        Rectangle platform1Rect;

        Texture2D platform2;
        Rectangle platform2Rect;

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
            platform1=Content.Load<Texture2D>("platform");
            platform2=Content.Load<Texture2D>("platform");
            playerSprite=new Sprite(player, new Rectangle(100,80,50,50));
        }

        protected override void Update(GameTime gameTime)
        {
            if(!playerSprite.SpriteRect.Intersects(platform1Rect) && ! playerSprite.SpriteRect.Intersects(platform2Rect)) {
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
            _spriteBatch.Draw(playerSprite.SpriteTexture, playerSprite.SpriteRect, Color.White);
            _spriteBatch.Draw(platform1, platform1Rect, Color.White);
            _spriteBatch.Draw(platform2, platform2Rect, Color.White);

            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
