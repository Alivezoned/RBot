using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace RBot
{
    public partial class LinearMouse : Form
    {
        MouseMove move;
        StringBuilder yo;
        Random random;

        public LinearMouse()
        {
            InitializeComponent();

            move = new MouseMove();
            yo = new StringBuilder();
            random = new Random();
        }

        private void LinearMouse_Load(object sender, EventArgs e)
        {

        }

        public void MainMouse()
        {
            Point a = new Point();
            a.X = 200;
            a.Y = 200;

            Point b = new Point();
            b.X = 700;
            b.Y = 700;

            // Current Mouse
            Point c = new Point();
            c.X = System.Windows.Forms.Cursor.Position.X;
            c.Y = System.Windows.Forms.Cursor.Position.Y;

            Point RanPoint = new Point();

            for (int i = 0; i < 2; i++)
            {
                RanPoint.X = random.Next(10, 1200);
                RanPoint.Y = random.Next(10, 500);

                // Point A to Random Point
                int g = SmoothMouseMove(RanPoint, 200, a);
                if (g == 1)
                {
                    // Current Point to Point B
                    c.X = System.Windows.Forms.Cursor.Position.X;
                    c.Y = System.Windows.Forms.Cursor.Position.Y;

                    int g2 = SmoothMouseMove(a, 200, c);
                    if (g2 == 1)
                    {
                        // Current Point to Random Point
                        c.X = System.Windows.Forms.Cursor.Position.X;
                        c.Y = System.Windows.Forms.Cursor.Position.Y;

                        RanPoint.X = random.Next(10, 1200);
                        RanPoint.Y = random.Next(10, 500);

                        int g3 = SmoothMouseMove(RanPoint, 200, c);
                        if (g3 == 1)
                        {
                            // Current Point to Point A
                            c.X = System.Windows.Forms.Cursor.Position.X;
                            c.Y = System.Windows.Forms.Cursor.Position.Y;

                            SmoothMouseMove(a, 200, c);
                        }
                    }
                }
            }
        }

        public double[] CurveMove(double x1, double y1, double x2, double y2, double x3, double y3)
        {

            double denom = (x1 - x2) * (x1 - x3) * (x2 - x3);
            double A = (x3 * (y2 - y1) + x2 * (y1 - y3) + x1 * (y3 - y2)) / denom;
            double B = (x3 * x3 * (y1 - y2) + x2 * x2 * (y3 - y1) + x1 * x1 * (y2 - y3)) / denom;
            double C = (x2 * x3 * (x2 - x3) * y1 + x3 * x1 * (x3 - x1) * y2 + x1 * x2 * (x1 - x2) * y3) / denom;
            double xv = -B / (2 * A);
            double yv = C - B * B / (4 * A);

            double new_x3 = Math.Round(xv, 0);
            double new_y3 = Math.Round(yv, 0);
            yo.AppendLine(new_x3 + "," + new_y3 + " - ");

            CurveMove(x1, y1, x2, y2, new_x3, new_y3);

            return new double[] { xv, yv };
        }

        public int SmoothMouseMove(Point newPosition, int steps, Point currentPosition)
        {
            Point start = currentPosition;
            PointF iterPoint = start;

            // Find the slope of the line segment defined by start and newPosition
            PointF slope = new PointF(newPosition.X - start.X, newPosition.Y - start.Y);

            // Divide by the number of steps
            slope.X = slope.X / steps;
            slope.Y = slope.Y / steps;

            // Move the mouse to each iterative point.
            for (int i = 0; i < steps; i++)
            {
                iterPoint = new PointF(iterPoint.X + slope.X, iterPoint.Y + slope.Y);

                int tx = Point.Round(iterPoint).X;
                int ty = Point.Round(iterPoint).Y;

                move.MoveMouse(tx, ty);

                int sleep = random.Next(1,10);
                Thread.Sleep(sleep);
            }
            // Move the mouse to the final destination.
            //SetCursorPosition(newPosition);

            return 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMouse();
        }
    }
}
