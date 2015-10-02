using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            double t = Convert.ToDouble(BillBox.Text);
            t *= 1.2;
            CalcBox.Text = t.ToString();
        }

        private void CalcButton_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void CalcButton_MouseMove(object sender, MouseEventArgs e)
        {
            
            Random rand = new Random();
            CalcButton.Location = new Point(rand.Next(0, Form1.ActiveForm.Size.Width - CalcButton.Size.Width), rand.Next(0, Form1.ActiveForm.Size.Height - CalcButton.Size.Height));
            CalcBox.Text = "Button x: " + CalcButton.Location.X + "  Button y: " + CalcButton.Location.Y;
            BillBox.Text = "Width: " + Form1.ActiveForm.Size.Width + "  Height: " + Form1.ActiveForm.Size.Height;
        }

        
    }
}
