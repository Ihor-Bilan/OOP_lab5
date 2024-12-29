using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Square square = new Square(90, 90, 60);
            square.MoveRight();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle(120, 120, 50);
            circle.MoveRight();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rhomb romb = new Rhomb(150, 150,100, 100); 
            romb.MoveRight();
        }
    }
}
