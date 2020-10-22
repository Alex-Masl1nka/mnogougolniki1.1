using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace многоугольники
{
    public partial class Form1 : Form

    {
        Draw[] body = new Draw[3];
        
        int i;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Окружность");
            comboBox1.Items.Add("Квадрат");
            comboBox1.Items.Add("Треугольник");
        }
        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            body[0] = new circle(e.X, e.Y);
            body[1] = new square(e.X, e.Y);
            body[3] = new triangle(e.X, e.Y);
            i = ((ComboBox)sender).SelectedIndex;
            this.Invalidate();
        }
    }
}
