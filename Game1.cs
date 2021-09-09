using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace simplePlatformer
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D player;
        Rectangle playerRect;

        Texture2D platform1;
        Rectangle platform1Rect;

        Texture2D platform2;
        Rectangle platform2Rect;

        

        public Game1()
        {
            playerRect=new Rectangle(100,80,50,50);
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
            
        }

        protected override void Update(GameTime gameTime)
        {
            if(!playerRect.Intersects(platform1Rect) && ! playerRect.Intersects(platform2Rect))
                playerRect.Y+=2;
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            if(Keyboard.GetState().IsKeyDown(Keys.Up)) {
                playerRect.Y-=6;
            } 
            if(Keyboard.GetState().IsKeyDown(Keys.Right)) {
                playerRect.X++;
            }
            if(Keyboard.GetState().IsKeyDown(Keys.Left)) {
                playerRect.X--;
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(player, playerRect, Color.White);
            _spriteBatch.Draw(platform1, platform1Rect, Color.White);
            _spriteBatch.Draw(platform2, platform2Rect, Color.White);

            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
