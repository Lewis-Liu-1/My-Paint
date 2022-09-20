﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

using LePaint.MainPart;
using LePaint.Basic;

namespace LePaint.Shapes
{
    public class Octagon : LePolyGon 
    {
        public Octagon(Point pt)
            : base(pt)
        {
            InitShape(8); 
        }
        private Octagon() { }
    }
}
