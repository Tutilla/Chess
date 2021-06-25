using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Chess
{
    class Board
    {
        private Square[,] squares;
        private int DIMENSION;
        private Piece piece;
        public Board(int squaresize,GraphicsDevice device)
        {
            piece = new Piece(new Vector2(0, 0), 0);
            DIMENSION = 8;
            squares = new Square[DIMENSION, DIMENSION];
            Vector2 location = new Vector2(0, 0);
            for (int i = 0; i < DIMENSION; i++)
            {
                for (int j = 0; j < DIMENSION; j++)
                {
                    location.X = j * squaresize;
                    location.Y = i * squaresize;
                    if ((i + j) % 2 == 0) squares[j, i] = new Square(squaresize,location, Color.White,device);
                    else squares[j, i] = new Square(squaresize,location, Color.Black, device);
                }
            }
        }
        public void InitialisePieces(Texture2D pieceTexture)
        {
            piece.setTexture(pieceTexture); 
        }
        public void Draw(SpriteBatch spritebatch)
        {
            for (int i = 0; i < DIMENSION; i++)
            {
                for (int j = 0; j < DIMENSION; j++)
                {
                    squares[j, i].Draw(spritebatch);
                }
            }
            piece.Draw(spritebatch);
        }
    }
}
