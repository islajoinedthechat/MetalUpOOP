﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDraw
{
    class Ellipse : Shape
    {
        public Ellipse(Pen p, int x1, int y1, int x2, int y2) : base(p, x1, y1, x2, y2)
        {


        }
        public Ellipse(Pen p, int x1, int y1) : base(p, x1, y1)
        {

        }


        public override void Draw(Graphics g)
        {
            DrawingFunctions.DrawClosedArc(g, this);

        }
    }
}
