using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Rob5._1
{
    class Turn : Square
    {
        public Turn(int width, int pointx, int pointy) : base(width, pointx, pointy)
        {
            base._width = width;
            base._pointx = pointx;
            base._pointy = pointy;
        }
        
        public void TurnButton(KeyEventArgs e, PictureBox square)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    square.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    square.Invalidate();
                    break;
                case Keys.Right:
                    square.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    square.Invalidate();
                    break;
            }
        }
    }
}
