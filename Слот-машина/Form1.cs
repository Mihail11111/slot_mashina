using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Слот_машина
{
    public partial class Form1 : Form
    {
        private Pen Pen = new Pen(Color.Black, 1);
        static int credits = 100;
        static int bet = 10;
        static int v1;
        static int v2;
        static int v3;
        public static class SlotRandom
        {
            static Random rnd;

            private static void Init()
            {
                if (rnd == null) rnd = new Random();
            }
            public static int Random(int min, int max)
            {
                Init();
                return rnd.Next(min, max);
            }
        }
        public Form1()
        {
            InitializeComponent();
            Refresh();
            Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            credits = credits - bet;
            label1.Text = "Ваши монеты: " + credits.ToString();
            for (var i = 0; i < 10; i++)
            {
                v1 = SlotRandom.Random(1, 4);
                v2 = SlotRandom.Random(1, 4);
                v3 = SlotRandom.Random(1, 4);
            }
            if(v1 == 1)
            {
                textBox1.Text = "10";
            }
            if (v1 == 2)
            {
                textBox1.Text = "100";
            }
            if (v1 == 3)
            {
                textBox1.Text = "1000";
            }
            if (v2 == 1)
            {
                textBox2.Text = "10";
            }
            if (v2 == 2)
            {
                textBox2.Text = "100";
            }
            if (v2 == 3)
            {
                textBox2.Text = "1000";
            }
            if (v3 == 1)
            {
                textBox3.Text = "10";
            }
            if (v3 == 2)
            {
                textBox3.Text = "100";
            }
            if (v3 == 3)
            {
                textBox3.Text = "1000";
            }
            if (v1 == 1 && v2 == 1 && v3 == 1)
            {
                credits = credits + 10;
            }
            if (v1 == 2 && v2 == 2 && v3 == 2)
            {
                credits = credits + 100;
            }
            if (v1 == 3 && v2 == 3 && v3 == 3)
            {
                credits = credits + 1000;
            }
            if(credits <= 0)
            {
                MessageBox.Show("Вы проиграли");
                throw new ArgumentException();
            }
        }
    }
}
