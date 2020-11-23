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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void start_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                start_Click(sender, e);
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            Cone myCone = new Cone(Convert.ToInt32(pointx.Text), Convert.ToInt32(pointy.Text), Convert.ToInt32(radius.Text), Convert.ToInt32(heigth.Text));

            if (checker.Checked == true)
            {
                myCone.ConeDraw(ConeDrawing, Convert.ToInt32(pointx.Text), Convert.ToInt32(pointy.Text), Convert.ToInt32(radius.Text), Convert.ToInt32(heigth.Text));
                myCone.Value(Convert.ToInt32(radius.Text), Convert.ToInt32(heigth.Text));
                myCone.Space(Convert.ToInt32(radius.Text));
            }
            else if (checker.Checked == false)
            {
                TruncatedCone myTruncatedCone = new TruncatedCone(Convert.ToInt32(pointx.Text), Convert.ToInt32(pointy.Text), Convert.ToInt32(radius.Text), Convert.ToInt32(heigth.Text));
                myTruncatedCone.TruncatedConeDraw(ConeDrawing, Convert.ToInt32(pointx.Text), Convert.ToInt32(pointy.Text), Convert.ToInt32(radius.Text), Convert.ToInt32(heigth.Text));
                myTruncatedCone.Value(Convert.ToInt32(radius.Text), Convert.ToInt32(heigth.Text));
                myTruncatedCone.Space(Convert.ToInt32(radius.Text));
            }
        }
    }
}
