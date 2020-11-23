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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
                SquareDraw.Width = Convert.ToInt32(Width1.Text) + 1;
                SquareDraw.Height = Convert.ToInt32(Width1.Text) + 1;
                Square coord = new Square(Convert.ToInt32(Width1.Text), Convert.ToInt32(pointx.Text), Convert.ToInt32(pointy.Text));
                Bitmap bmp = new Bitmap(SquareDraw.Width, SquareDraw.Height);
                coord.DrawingSquare(Convert.ToInt32(pointx.Text), Convert.ToInt32(pointy.Text), Convert.ToInt32(Width1.Text), bmp);
                SquareDraw.Image = bmp;
                Refresh();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Switch.Checked == true)
            {
                Square move = new Square(Convert.ToInt32(Width1.Text), Convert.ToInt32(pointx.Text), Convert.ToInt32(pointy.Text));
                move.MoveButton(SquareDraw, e);
            }
            else if (Switch.Checked == false)
            {
                Turn myTurn = new Turn(Convert.ToInt32(Width1.Text), Convert.ToInt32(pointx.Text), Convert.ToInt32(pointy.Text));
                myTurn.TurnButton(e, SquareDraw);
            }
        }

        private void CooordTimer_Tick(object sender, EventArgs e)
        {
            if (CooordTimer.Enabled)
            {
                TopLeft.Text = $"Top Left: {SquareDraw.Location.X}, {SquareDraw.Location.Y}";
                TopLeft.Refresh();
                TopRight.Text = $"Top Right: {SquareDraw.Location.X - Convert.ToInt32(Width1.Text)}, {SquareDraw.Location.Y}";
                TopRight.Refresh();
                LowLeft.Text = $"Top Right: {SquareDraw.Location.X}, {SquareDraw.Location.Y - Convert.ToInt32(Width1.Text)}";
                LowLeft.Refresh();
                LowRight.Text = $"Low Right: {SquareDraw.Location.X - Convert.ToInt32(Width1.Text)}, {SquareDraw.Location.Y - Convert.ToInt32(Width1.Text)}";
                LowRight.Refresh();
            }
            else
            {

            }
        }
    }

}
