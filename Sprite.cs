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
                this.SpriteRect.Y-=6;
            } 
            if(Keyboard.GetState().IsKeyDown(Keys.Right)) {
                this.SpriteRect.X++;
            }
            if(Keyboard.GetState().IsKeyDown(Keys.Left)) {
                this.SpriteRect.X--;
            }
        }
    }
}