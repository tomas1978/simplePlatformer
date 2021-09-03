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
        Vector2 playerPos;

        Texture2D platform1;
        Vector2 platform1Pos;

        Texture2D platform2;
        Vector2 platform2Pos;

        public Game1()
        {
            playerPos=new Vector2(100,100);
            platform1Pos=new Vector2(50, 200);
            platform2Pos=new Vector2(430, 150);
            
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
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(player, playerPos, Color.White);
            _spriteBatch.Draw(platform1, platform1Pos, Color.White);
            _spriteBatch.Draw(platform2, platform2Pos, Color.White);

            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
