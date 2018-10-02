using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ColorBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int blue, red, green;
        
        private Color ColorProduce()
        {
            Color randomColor = new Color();
            blue = rnd.Next(0, 256);
            red = rnd.Next(0, 256);
            green = rnd.Next(0, 256);
            randomColor = Color.FromArgb(blue, red, green);

            return randomColor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           
            
            for (int i = 0; i < 8; i++)
            {
                Button btn = new Button();
                btn.Width = 50;
                btn.Height = 50;
                btn.Left = 50+50*i;
                btn.Top = 50;
                btn.BackColor = ColorProduce();
                btn.Tag = ColorProduce();
                this.Controls.Add(btn);
                btn.Click += Btn_Click;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            this.BackColor = (Color)clickedButton.Tag;
        }
    }
}
