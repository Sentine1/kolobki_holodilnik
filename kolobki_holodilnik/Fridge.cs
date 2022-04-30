using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kolobki_holodilnik
{
    public partial class Fridge : Form
    {
        public Fridge()
        {
            InitializeComponent();
            this.Size = new Size(540, 400);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }



        private void Refresh_Progress()
        {
            var keyOpen = "|";
            if (button11.Text == keyOpen &&
                button21.Text == keyOpen &&
                button31.Text == keyOpen &&
                button41.Text == keyOpen)
                progressBar1.Value = 100;
            else progressBar1.Value = 0;

            if (button12.Text == keyOpen &&
                button22.Text == keyOpen &&
                button32.Text == keyOpen &&
                button42.Text == keyOpen)
                progressBar2.Value = 100;
            else progressBar2.Value = 0;

            if (button13.Text == keyOpen &&
                button23.Text == keyOpen &&
                button33.Text == keyOpen &&
                button43.Text == keyOpen)
                progressBar3.Value = 100;
            else progressBar3.Value = 0;

            if (button14.Text == keyOpen &&
                button24.Text == keyOpen &&
                button34.Text == keyOpen &&
                button44.Text == keyOpen)
                progressBar4.Value = 100;
            else progressBar4.Value = 0;
        }

        private void Change_Progress_Line1()
        {
            Change(button11);
            Change(button12);
            Change(button13);
            Change(button14);
        }

        private void Change_Progress_Line2()
        {
            Change(button21);
            Change(button22);
            Change(button23);
            Change(button24);
        }

        private void Change_Progress_Line3()
        {
            Change(button31);
            Change(button32);
            Change(button33);
            Change(button34);
        }

        private void Change_Progress_Line4()
        {
            Change(button41);
            Change(button42);
            Change(button43);
            Change(button44);
        }

        private void Change_Progress_Row1()
        {
            Change(button11);
            Change(button21);
            Change(button31);
            Change(button41);
        }

        private void Change_Progress_Row2()
        {
            Change(button12);
            Change(button22);
            Change(button32);
            Change(button42);
        }

        private void Change_Progress_Row3()
        {
            Change(button13);
            Change(button23);
            Change(button33);
            Change(button43);
        }

        private void Change_Progress_Row4()
        {
            Change(button14);
            Change(button24);
            Change(button34);
            Change(button44);
        }

        private static void Change(Button button)
        {
            button.Text = button.Text == "-" ? "|" : "-";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Change_Progress_Line1();
            Change_Progress_Row1();
            Change(button11);
            Refresh_Progress();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Change_Progress_Line1();
            Change_Progress_Row2();
            Change(button12);
            Refresh_Progress();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Change_Progress_Line1();
            Change_Progress_Row3();
            Change(button13);
            Refresh_Progress();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Change_Progress_Line1();
            Change_Progress_Row4();
            Change(button14);
            Refresh_Progress();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Change_Progress_Line2();
            Change_Progress_Row1();
            Change(button21);
            Refresh_Progress();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Change_Progress_Line2();
            Change_Progress_Row2();
            Change(button22);
            Refresh_Progress();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Change_Progress_Line2();
            Change_Progress_Row3();
            Change(button23);
            Refresh_Progress();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Change_Progress_Line2();
            Change_Progress_Row4();
            Change(button24);
            Refresh_Progress();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Change_Progress_Line3();
            Change_Progress_Row1();
            Change(button31);
            Refresh_Progress();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Change_Progress_Line3();
            Change_Progress_Row2();
            Change(button32);
            Refresh_Progress();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Change_Progress_Line3();
            Change_Progress_Row3();
            Change(button33);
            Refresh_Progress();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Change_Progress_Line3();
            Change_Progress_Row4();
            Change(button34);
            Refresh_Progress();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            Change_Progress_Line4();
            Change_Progress_Row1();
            Change(button41);
            Refresh_Progress();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            Change_Progress_Line4();
            Change_Progress_Row2();
            Change(button42);
            Refresh_Progress();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            Change_Progress_Line4();
            Change_Progress_Row3();
            Change(button43);
            Refresh_Progress();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            Change_Progress_Line4();
            Change_Progress_Row4();
            Change(button44);
            Refresh_Progress();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Random_Click(object sender, EventArgs e)
        {
            var random = new Random(DateTime.UtcNow.Second);
            button11.Text = random.Next(1, 43) % 2 == 0 ? "-" : "|";
            button12.Text = random.Next(1, 43) % 2 == 0 ? "-" : "|";
            button13.Text = random.Next(1, 43) % 2 == 0 ? "-" : "|";
            button14.Text = random.Next(1, 43) % 2 == 0 ? "-" : "|";
            button21.Text = random.Next(1, 43) % 2 == 0 ? "-" : "|";
            button22.Text = random.Next(1, 43) % 2 == 0 ? "-" : "|";
            button23.Text = random.Next(1, 43) % 2 == 0 ? "-" : "|";
            button24.Text = random.Next(1, 43) % 2 == 0 ? "-" : "|";
            button31.Text = random.Next(1, 43) % 2 == 0 ? "-" : "|";
            button32.Text = random.Next(1, 43) % 2 == 0 ? "-" : "|";
            button33.Text = random.Next(1, 43) % 2 == 0 ? "-" : "|";
            button34.Text = random.Next(1, 43) % 2 == 0 ? "-" : "|";
            button41.Text = random.Next(1, 43) % 2 == 0 ? "-" : "|";
            button42.Text = random.Next(1, 43) % 2 == 0 ? "-" : "|";
            button43.Text = random.Next(1, 43) % 2 == 0 ? "-" : "|";
            button44.Text = random.Next(1, 43) % 2 == 0 ? "-" : "|";

        }
    }
}
