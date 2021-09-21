using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace simplePlatformer {
    class Sprite {
        public Texture2D SpriteTexture {set; get;}
        public Rectangle SpriteRect {set; get;}

        public Sprite(Texture2D texture, Rectangle rect) {
            SpriteTexture=texture;
            SpriteRect=rect;
        }

        public void Update() {
            if(Keyboard.GetState().IsKeyDown(Keys.Up)) {
                this.SpriteRect=new Rectangle(this.SpriteRect.X, this.SpriteRect.Y-6, this.SpriteRect.Width, this.SpriteRect.Height);
            } 
            if(Keyboard.GetState().IsKeyDown(Keys.Right)) {
                this.SpriteRect=new Rectangle(this.SpriteRect.X+1, this.SpriteRect.Y, this.SpriteRect.Width, this.SpriteRect.Height);
            }
            if(Keyboard.GetState().IsKeyDown(Keys.Left)) {
                this.SpriteRect=new Rectangle(this.SpriteRect.X, this.SpriteRect.Y+1, this.SpriteRect.Width, this.SpriteRect.Height);
            }
        }
    }
}