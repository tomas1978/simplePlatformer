using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace simplePlatformer {
    class Sprite {
        public Texture2D SpriteTexture {set; get;}
        public Rectangle SpriteRect {set; get;}
        public int Distance{get; set;}

        public Sprite(Texture2D texture, Rectangle rect) {
            SpriteTexture=texture;
            SpriteRect=rect;
            Distance=0;
        }

        public void Move(Vector2 direction) {
            SpriteRect=new Rectangle(SpriteRect.X+(int)direction.X, SpriteRect.Y+(int)direction.Y,
                SpriteRect.Width, SpriteRect.Height);
        }

        public void Update() {
            if(Keyboard.GetState().IsKeyDown(Keys.Up)) {
                this.SpriteRect=new Rectangle(this.SpriteRect.X, this.SpriteRect.Y-6, this.SpriteRect.Width, this.SpriteRect.Height);
            } 
            if(Keyboard.GetState().IsKeyDown(Keys.Right)) {
                this.SpriteRect=new Rectangle(this.SpriteRect.X+1, this.SpriteRect.Y, this.SpriteRect.Width, this.SpriteRect.Height);
            }
            if(Keyboard.GetState().IsKeyDown(Keys.Left)) {
                this.SpriteRect=new Rectangle(this.SpriteRect.X-1, this.SpriteRect.Y, this.SpriteRect.Width, this.SpriteRect.Height);
            }
        }

        public void Draw(SpriteBatch sb) {
            sb.Draw(this.SpriteTexture, this.SpriteRect, Color.CornflowerBlue);

        }
    }
}