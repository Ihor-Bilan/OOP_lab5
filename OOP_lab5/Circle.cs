using System;
using System.Drawing;

namespace OOP_lab5
{
    class Circle : Figure
    {
        private int radius;

        public Circle(int centerX, int centerY, int radius) : base(centerX, centerY)
        {
            this.radius = radius;
        }

        public override void DrawBlack()
        {
            Graphics graphics = Form1.ActiveForm.CreateGraphics();
            graphics.DrawEllipse(Pens.Black, centerX - radius, centerY - radius, radius * 2, radius * 2);
        }

        public override void HideDrawingBackGround()
        {
            Graphics graphics = Form1.ActiveForm.CreateGraphics();
            graphics.DrawEllipse(new Pen(Form1.ActiveForm.BackColor), centerX - radius, centerY - radius, radius * 2, radius * 2);
        }
    }
}
