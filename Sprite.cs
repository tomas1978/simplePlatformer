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
            //this.Load(texture);
        }

        /*public void Load(Texture2D texture) {
            Game1.Content.LoadContent<Texture2D>(texture);
        }*/
    }
}