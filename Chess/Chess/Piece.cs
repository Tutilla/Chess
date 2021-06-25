using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Chess
{
    class Piece
    {
       private PieceTexture texture;
       private Vector2 location { get; set;}
       private int id {get; set;}
        
       public Piece(Vector2 location, int id)
        {
            this.location = location;
            this.id = id;
        }
        public void setTexture(Texture2D texture)
        {
            this.texture = new PieceTexture(texture, 2, 6, id);
        }
        public void Draw(SpriteBatch spritebatch)
        {
            texture.Draw(spritebatch, location);
        }
    }

}
