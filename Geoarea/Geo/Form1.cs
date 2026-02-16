using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geo
{
    public partial class Form1 : Form
    {
        private bool isInside(Control control)
        {
            Rectangle area = new Rectangle(control.Location, control.Size);
            return area.Contains(PointToClient(MousePosition));
        }

        public Form1()
        {
            InitializeComponent();
        }


        private void box_Click(object sender, EventArgs e)
        {
            int forma = 0;
            if (isInside(triangulo))
            {
                forma = 1;
            }
            if (isInside(quadrado))
            {
                forma = 2;
            }
            if (isInside(pentagono))
            {
                forma = 3;
            }
            if (isInside(hexagono))
            {
                forma = 4;
            }
            if (forma != 0)
            {
                this.Hide();
                new Form2(forma, this).Show();
            }
        }

        private void box_MouseMove(object sender, MouseEventArgs e)
        {
            if (isInside(triangulo) || isInside(quadrado) || isInside(pentagono) || isInside(hexagono))
            {
                Cursor.Current = Cursors.Hand;
            }
            else
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void triangulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
