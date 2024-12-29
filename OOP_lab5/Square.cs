using System;
using System.Drawing;

namespace OOP_lab5
{
    class Square : Figure
    {
        private int size;

        public Square(int centerX, int centerY, int size) : base(centerX, centerY)
        {
            this.size = size;
        }

        private Point[] GetCurrPoints()
        {
            return new Point[]
            {
                new Point(centerX - size, centerY - size),
                new Point(centerX - size, centerY + size),
                new Point(centerX + size, centerY + size),
                new Point(centerX + size, centerY - size),
            };
        }

        public override void DrawBlack()
        {
            Graphics graphics = Form1.ActiveForm.CreateGraphics();
            graphics.DrawPolygon(Pens.Black, GetCurrPoints());
        }

        public override void HideDrawingBackGround()
        {
            Graphics graphics = Form1.ActiveForm.CreateGraphics();
            graphics.DrawPolygon(new Pen(Form1.ActiveForm.BackColor), GetCurrPoints());
        }
    }
}
