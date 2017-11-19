using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimationDesigner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Paint += Form1_Paint;


        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = this.CreateGraphics();

            Pen pen = Pens.Yellow;
            Brush brush = Brushes.Yellow;
            graphics.FillEllipse(brush, 100, 100, 100, 100);
        }
    }
}
