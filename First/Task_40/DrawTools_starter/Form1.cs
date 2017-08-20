using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrawTools;

namespace DrawTools_starter
{
    public partial class Form1 : Form
    {
        private const int RECT_SIZE = 4;
        public Form1()
        {
            InitializeComponent();
            button1.Text = "Draw";
            label1.Text = "R:";
            textBox1.Text = "10";
        }

        private void DrawCircle(Graphics g)
        {
            int R = int.Parse(textBox1.Text);
            Pen pen1 = new Pen(Color.Blue, 1);
            List<Pixel> list = DrawTools.DrawTools.DrawCircle(R);

            foreach (Pixel p in list)
            {
                Rectangle rect = new Rectangle((p.X + R) * RECT_SIZE + 13, (p.Y + R) * RECT_SIZE + 13, RECT_SIZE, RECT_SIZE);
                g.DrawRectangle(pen1, rect);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Refresh();
            int R = int.Parse(textBox1.Text);
            DrawCircle(CreateGraphics());

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawCircle(e.Graphics);

        }
    }
}
