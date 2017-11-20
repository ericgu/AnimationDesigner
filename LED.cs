using System;
using System.Drawing;

namespace AnimationDesigner
{
    public class Led
    {
        private const int Size = 20;
        private const double DegreesPerRadian = (Math.PI / 180);

        private int _angle;
        private int _distance;

        public Led(int angle, int distance)
        {
            _angle = angle;
            _distance = distance;
        }

        public int Angle { get { return _angle; } }
        public int Distance { get { return _distance; } }

        public RgbColor Color { get; set; }

        internal void Draw(Graphics graphics, Rectangle bounds)
        {
            Color color = System.Drawing.Color.FromArgb(Color.Red, Color.Green, Color.Blue);

            int xCenter = bounds.Width / 2;
            int yCenter = bounds.Height / 2;

            int boundingSize = xCenter > yCenter ? yCenter : xCenter;

            int o = (_distance * boundingSize) / 110;

            var angleInRadians = _angle * DegreesPerRadian;
            int x = (int)(Math.Cos(angleInRadians) * o) + xCenter - Size / 2 - 10;
            int y = (int)(Math.Sin(angleInRadians) * o) + yCenter - Size / 2 - 10;

            Brush brush = new SolidBrush(color);
            graphics.FillEllipse(brush, x, y, Size, Size);
        }
    }
}
