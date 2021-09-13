using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

class Sprite {
    public Texture2D SpriteTexture {set; get;}
    private Rectangle SpriteRect {set; get;}

    public Sprite(Texture2D texture, Rectangle rect) {
        SpriteTexture=texture;
        SpriteRect=rect;
    }
}