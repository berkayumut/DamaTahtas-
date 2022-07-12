using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DamaTahtası
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] buttons = new Button[8,8]; 
            int top = 10;
            int left = 10;
            this.Width = 660; //form genişliği
            this.Height = 660; // form yüksekliği
            this.Text = "Dama Tahtası";

            for (int i = 0; i <= buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Height = 70;
                    buttons[i, j].Width = 70;
                    buttons[i, j].Top = top;
                    buttons[i, j].Left = left;
                    left += 70;
                    if ((i + j) % 2 == 0)
                        buttons[i, j].BackColor = Color.Black;
                    else
                        buttons[i, j].BackColor = Color.White;



                    this.Controls.Add(buttons[i, j]);
                }
                left = 10;
                top += 70;
            }
            
        }
    }
}
