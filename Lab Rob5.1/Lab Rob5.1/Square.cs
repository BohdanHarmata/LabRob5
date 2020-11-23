using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Rob5._1
{
    class Square
    {
        protected int _width;
        protected int _pointx;
        protected int _pointy;

        public Square(int width, int pointx, int pointy)
        {
            this._width = width;
            this._pointx = pointx;
            this._pointy = pointy;
        }
        public void DrawingSquare(int pointx, int pointy, int width, Bitmap bmp)
        {
            Graphics square = Graphics.FromImage(bmp);
            Pen pen = new Pen(Brushes.Black);
            square.DrawRectangle(pen, pointx, pointy, width, width);
        }

        public void MoveButton(PictureBox squareDraw ,KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                squareDraw.Location = new Point(squareDraw.Location.X - 10, squareDraw.Location.Y);
              
            }
            else if (e.KeyCode == Keys.Right)
            {
                squareDraw.Location = new Point(squareDraw.Location.X + 10, squareDraw.Location.Y);

            }
            else if (e.KeyCode == Keys.Up)
            {
                squareDraw.Location = new Point(squareDraw.Location.X, squareDraw.Location.Y - 10);

            }
            else if (e.KeyCode == Keys.Down)
            {
                squareDraw.Location = new Point(squareDraw.Location.X, squareDraw.Location.Y + 10);

            }
        }
    }
}
