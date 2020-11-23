using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cone
{
    class Cone
    {

        protected int _pointx;
        protected int _pointy;
        protected int _radius;
        protected int _heigth;
        public Cone(int pointx, int pointy, int radius, int heigth)
        {
            this._pointx = pointx;
            this._pointy = pointy;
            this._radius = radius;
            this._heigth = heigth;
        }

        public void ConeDraw (PictureBox conepicture, int pointx, int pointy, int radius, int heigth)
        {
            Bitmap bmp = new Bitmap(conepicture.Width, conepicture.Height);

            Graphics conedraw = Graphics.FromImage(bmp);

            Pen pen = new Pen(Brushes.Black);

            conedraw.DrawLine(pen, pointx, pointy, pointx + radius, pointy - heigth);

            conedraw.DrawLine(pen, pointx + radius * 2, pointy, pointx + radius, pointy - heigth);

            Rectangle rect = new Rectangle(pointx, pointy - heigth / 4, radius * 2, heigth / 2);

            conedraw.DrawEllipse(pen, rect);

            conepicture.Image = bmp;
        }

        public void Value(int heigth, int radius)
        {
            const double pi = 3.14;

            var value = ((pi * heigth * Math.Pow(radius, 2)) / 3) / 10;

            MessageBox.Show("Value " + Convert.ToString(value) + " cm");
        }

        public void Space(int radius)
        {
            const double pi = 3.14;

            var space = (pi * Math.Pow(radius, 2)) / 10;

            MessageBox.Show("Space of base" + Convert.ToString(space) + " cm");
        }
    }
}
