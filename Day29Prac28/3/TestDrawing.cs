﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace _3
{
    internal class TestDrawing : Control
    {

        protected override void OnRender(System.Windows.Media.DrawingContext drawingContext)
        {
            var rect = new Rect(new Point(0, 0), new Point(100, 200));
            drawingContext.DrawRectangle(Brushes.Red, new Pen(Brushes.Red, 12), rect);
            drawingContext.DrawEllipse(Brushes.Yellow, new Pen(), new Point(400, 200), 200, 50);
            var points = new List<Point>()
            {
                new Point(150,150),
                new Point(150,50)
            };
            var segments = new List<PathSegment>()
            {
                new PolyLineSegment(points,true)
            };
            var figures = new List<PathFigure>()
            {
                new PathFigure(new Point(200,50),segments,true)

            };
            drawingContext.DrawGeometry(Brushes.Black, new Pen(), new PathGeometry(figures));
            
            base.OnRender(drawingContext);


        }
    }
}
