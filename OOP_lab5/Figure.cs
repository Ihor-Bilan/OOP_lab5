using System;
using System.Drawing;

namespace OOP_lab5
{
    abstract class Figure
    {
        protected int centerX;
        protected int centerY;

        public Figure(int centerX, int centerY)
        {
            this.centerX = centerX;
            this.centerY = centerY;
        }

        public abstract void DrawBlack();
        public abstract void HideDrawingBackGround();

        public void MoveRight()
        {
            for (int i = 0; i < 300; i++)
            {
                DrawBlack();
                System.Threading.Thread.Sleep(1);
                HideDrawingBackGround();
                centerX++;
            }
        }
    }
}
