
namespace Geo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hexagono = new System.Windows.Forms.Panel();
            this.pentagono = new System.Windows.Forms.Panel();
            this.quadrado = new System.Windows.Forms.Panel();
            this.triangulo = new System.Windows.Forms.Panel();
            this.box = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Selecione o polígono para o cálculo:  ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(50, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(729, 222);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // hexagono
            // 
            this.hexagono.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hexagono.BackgroundImage")));
            this.hexagono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hexagono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hexagono.Location = new System.Drawing.Point(556, 256);
            this.hexagono.Margin = new System.Windows.Forms.Padding(4);
            this.hexagono.Name = "hexagono";
            this.hexagono.Size = new System.Drawing.Size(135, 141);
            this.hexagono.TabIndex = 5;
            this.hexagono.Visible = false;
            // 
            // pentagono
            // 
            this.pentagono.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pentagono.BackgroundImage")));
            this.pentagono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pentagono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pentagono.Location = new System.Drawing.Point(413, 256);
            this.pentagono.Margin = new System.Windows.Forms.Padding(4);
            this.pentagono.Name = "pentagono";
            this.pentagono.Size = new System.Drawing.Size(135, 141);
            this.pentagono.TabIndex = 4;
            this.pentagono.Visible = false;
            // 
            // quadrado
            // 
            this.quadrado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("quadrado.BackgroundImage")));
            this.quadrado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quadrado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quadrado.Location = new System.Drawing.Point(270, 256);
            this.quadrado.Margin = new System.Windows.Forms.Padding(4);
            this.quadrado.Name = "quadrado";
            this.quadrado.Size = new System.Drawing.Size(135, 141);
            this.quadrado.TabIndex = 3;
            this.quadrado.Visible = false;
            // 
            // triangulo
            // 
            this.triangulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("triangulo.BackgroundImage")));
            this.triangulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.triangulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.triangulo.Location = new System.Drawing.Point(125, 256);
            this.triangulo.Margin = new System.Windows.Forms.Padding(4);
            this.triangulo.Name = "triangulo";
            this.triangulo.Size = new System.Drawing.Size(135, 141);
            this.triangulo.TabIndex = 2;
            this.triangulo.Visible = false;
            this.triangulo.Paint += new System.Windows.Forms.PaintEventHandler(this.triangulo_Paint);
            // 
            // box
            // 
            this.box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.box.Image = global::Geo.Properties.Resources.poligonos;
            this.box.Location = new System.Drawing.Point(109, 256);
            this.box.Margin = new System.Windows.Forms.Padding(4);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(592, 141);
            this.box.TabIndex = 0;
            this.box.TabStop = false;
            this.box.Click += new System.EventHandler(this.box_Click);
            this.box.MouseMove += new System.Windows.Forms.MouseEventHandler(this.box_MouseMove);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(-4, 324);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(142, 147);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(-56, 185);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(142, 147);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(607, 185);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(142, 147);
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(698, 309);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(142, 147);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(-98, -30);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(142, 147);
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(785, 90);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(142, 147);
            this.pictureBox7.TabIndex = 13;
            this.pictureBox7.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(215)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(823, 410);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.hexagono);
            this.Controls.Add(this.pentagono);
            this.Controls.Add(this.quadrado);
            this.Controls.Add(this.triangulo);
            this.Controls.Add(this.box);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculador de área - GeoArea";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox box;
        private System.Windows.Forms.Panel triangulo;
        private System.Windows.Forms.Panel quadrado;
        private System.Windows.Forms.Panel pentagono;
        private System.Windows.Forms.Panel hexagono;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}

