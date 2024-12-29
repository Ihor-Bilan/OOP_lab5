using OOP_lab5;
using System.Drawing;

class Rhomb : Figure
{
    private int horDiagLen; 
    private int vertDiagLen; 

    public Rhomb(int centerX, int centerY, int horDiagLen, int vertDiagLen)
        : base(centerX, centerY) 
    {
        this.horDiagLen = horDiagLen;
        this.vertDiagLen = vertDiagLen;
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

    private Point[] GetCurrPoints()
    {
        return new Point[]
        {
            new Point(centerX, centerY - vertDiagLen / 2),
            new Point(centerX + horDiagLen / 2, centerY),
            new Point(centerX, centerY + vertDiagLen / 2),
            new Point(centerX - horDiagLen / 2, centerY),
        };
    }
}

