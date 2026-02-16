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
    public partial class Form2 : Form
    {
        int forma = 0;
        Form1 main;
        public Form2(int forma_, Form1 old)
        {
            forma = forma_;
            main = old;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            switch (forma)
            {
                case 1:
                    imagem.Image = Properties.Resources.triangulo;
                    imagem.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                case 2:
                    imagem.Image = Properties.Resources.quadrado;
                    imagem.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                case 3:
                    lblv1.Text = "Lado";
                    lblv2.Text = "Altura";
                    imagem.Image = Properties.Resources.pentagono;
                    imagem.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                case 4:
                    lblv1.Text = "Lado";
                    lblv2.Visible = false;
                    txv2.Visible = false;
                    imagem.Image = Properties.Resources.hexagono;
                    imagem.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float v1 = float.Parse(txv1.Text);
            float v2;
            float.TryParse(txv2.Text, out v2);
            switch (forma)
            {
                case 1:
                    MessageBox.Show("A área da forma é: " + (v1 * v2 * 0.5).ToString());
                    break;
                case 2:
                    MessageBox.Show("A área da forma é: " + (v1 * v2).ToString());
                    break;
                case 3:
                    MessageBox.Show("A área da forma é: " + (5 * v1 * v2).ToString());
                    break;
                case 4:
                    MessageBox.Show("A área da forma é: " + Math.Round(((3 * Math.Pow(v1,2) * Math.Sqrt(3))/2), 2).ToString());
                    break;
            }
        }

        private void imagem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
