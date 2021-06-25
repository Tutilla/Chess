using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Chess
{
    class Square
    {
        private Vector2 location { get; set;}
        private Texture2D square;
        private int size { get; }
        public Square(int size,Vector2 location,Color color, GraphicsDevice device)
        {
            this.size = size;
            square = new Texture2D(device, size, size);
            this.location = location;
            Color[] data = new Color[size * size];
            for (int i = 0; i < data.Length; ++i) data[i] = color;
            square.SetData(data);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle rectangle = new Rectangle((int)location.X, (int)location.Y, size, size);
            spriteBatch.Begin();
            spriteBatch.Draw(square,rectangle,Color.White);
            spriteBatch.End();
        }
    }
}
