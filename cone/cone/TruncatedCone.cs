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
    class TruncatedCone : Cone
    {

        public TruncatedCone(int pointx, int pointy, int radius, int heigth) : base (pointx, pointy, radius, heigth)
        {
            base._pointx = pointx;
            base._pointy = pointy;
            base._radius = radius;
            base._heigth = heigth;
        }

        public void TruncatedConeDraw(PictureBox conepicture, int pointx, int pointy, int radius, int heigth)
        {
            Bitmap bmp = new Bitmap(conepicture.Width, conepicture.Height);

            Graphics conedraw = Graphics.FromImage(bmp);

            Pen pen = new Pen(Brushes.Black);

            conedraw.DrawLine(pen, pointx, pointy, pointx + radius / 2, pointy - heigth / 2);

            conedraw.DrawLine(pen, pointx + radius * 2, pointy, (pointx + radius / 2) + radius, pointy - heigth / 2);

            Rectangle rect = new Rectangle(pointx, pointy - heigth / 4, radius * 2, heigth / 2);

            Rectangle rect2 = new Rectangle(pointx + radius / 2, pointy - heigth + heigth / 3, radius, heigth / 4);

            conedraw.DrawEllipse(pen, rect);

            conedraw.DrawEllipse(pen, rect2);

            conepicture.Image = bmp;
        }

        public void outValue (int radius, int heigth)
        {
            const double pi = 3.14;

            var value = ((pi * heigth * (Math.Pow(radius, 2) + radius * (radius / 2) + Math.Pow((radius / 2),2))) / 3) / 10;

            MessageBox.Show("Value " + Convert.ToString(value) + " cm");
        }

        public void outSpace (int radius)
        {
            const double pi = 3.14;

            var space = (pi * Math.Pow(radius, 2)) / 10;

            MessageBox.Show("Space of base" + Convert.ToString(space) + " cm");
        }
    }
}
