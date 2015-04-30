using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace BrickOut
{
    public class Row : GameObject
    {
        public const int kNumberOfBricks = 7;
        private Brick[] Bricks = new Brick[kNumberOfBricks];
        int RowPosition = 0;
        int BrickHeight = 5;
        int BrickWidth = 5;
        public int BrickOut = 0;

        public Row(int nRow)
            : base("brick.gif")
        {
            RowPosition = nRow;
            for (int i = 0; i < kNumberOfBricks; i++)
            {
                Bricks[i] = new Brick();
                Bricks[i].Position.X = i * Bricks[i].GetImage().Width;
                Bricks[i].Position.Y = i * Bricks[i].GetImage().Width;
                BrickHeight = Bricks[i].Height;
                BrickWidth = Bricks[i].Width;
            }
        }

        public override void Draw(Graphics g)
        {
            for (int i = 0; i < kNumberOfBricks; i++)
            {
                if (Bricks[i] != null)
                    Bricks[i].Draw(g);
            }
        }

        public override int GetWidth()
        {
            return ImageBounds.Width * kNumberOfBricks;
        }

        public override Rectangle GetBounds()
        {
            Rectangle rRow = new Rectangle();
            rRow.X = 0;
            rRow.Y = RowPosition * BrickWidth;
            rRow.Width = kNumberOfBricks * BrickWidth;
            rRow.Height = BrickHeight;
            return rRow;
        }

        public bool Collides(Rectangle TheBallRect)
        {
            for (int i = 0; i < kNumberOfBricks; i++)
            {
                if (Bricks[i] != null)
                {
                    if ((Bricks[i].GetBounds().Left < TheBallRect.Left) && (Bricks[i].GetBounds().Right < TheBallRect.Right))
                    {
                        if (TheBallRect.Top - 7 < Bricks[i].GetBounds().Bottom)
                        {
                            Bricks[i] = null;
                            BrickOut++;
                            return true;
                        }
                    }
                }
            }

            return false;
        
        }
    }
}
