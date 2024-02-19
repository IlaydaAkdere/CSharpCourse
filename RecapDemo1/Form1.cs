using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Button  button = new Button();
            //button.Width = 50;
            //button.Height = 50;
            //this.Controls.Add(button);

            //Button button1 = new Button();
            //button1.Width = 50;
            //button1.Height = 50;
            //this.Controls.Add(button);


            //Button button2 = new Button();
            //button2.Width = 50;
            //button2.Height = 50;
            //this.Controls.Add(button);

            // kaç buton istendiyse onun ıcın tek tek yaptık suan 3 button var kısa yolu için de döngü kullanacagız.

            //for (int i = 1; i <= 64; i++)
            //{
            //    Button button = new Button();
            //    button.Width = 50;
            //    button.Height = 50;
            //    this.Controls.Add(button);
            //    // burası bıze 64 tane button olusturacak ekranda bır tane göstrecek ama aslında 64 tane button ust uste koyulmus oldu
            //}


            GenerateButtons();

            // her bır nesneye ayrı ayrı ulasmak ıstersek bu sekılde yapmamız gerekır [array yöntemi ile]
        }

        private void GenerateButtons()
        {
            Button[,] buttons = new Button[8, 8];
            int top = 0;
            int left = 0;

            for (int i = 0; i < buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    Left += 50;
                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                    this.Controls.Add(buttons[i, j]);
                }
                top += 50;
                left = 0;
            }
            this.Controls.Add(button);
        }
    }
}
