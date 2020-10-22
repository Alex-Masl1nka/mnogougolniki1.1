using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace многоугольники
{
    public abstract class Draw
    {
        protected int x, y;
        public Draw(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public abstract void DrawFigure(Graphics graf);
    }
    public class circle : Draw
    {
        SolidBrush br = new SolidBrush(Color.Green);
        public circle(int x, int y) : base(x, y)
        {
        }
        public override void DrawFigure(Graphics graf)
        {
            graf.FillEllipse(br, x - 5, y + 5, 10, 10);
        }
    }
    public class square : Draw
    {
        SolidBrush br = new SolidBrush(Color.Green);
        public square(int x, int y) : base(x, y)
        {
        }
        public override void DrawFigure(Graphics graf)
        {
            graf.FillRectangle(br, x - 5, y + 5, 10, 10);
        }
    }
    public class triangle : Draw
    {
        SolidBrush br = new SolidBrush(Color.Green);
        public triangle(int x, int y) : base(x, y)
        {
        }
        public override void DrawFigure(Graphics graf)
        {
            //graf.FillRectangle(br, x - 5, y + 5, 10, 10);
        }
    }
}

