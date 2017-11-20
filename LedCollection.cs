using System.Collections.Generic;
using System.Drawing;

namespace AnimationDesigner
{
    public class LedCollection
    {
        List<Led> _leds = new List<Led>();

        public List<Led> Items { get { return _leds; } }

        public void Draw(Rectangle rectangle, Graphics graphics)
        {
            foreach (Led led in _leds)
            {
                led.Draw(graphics, rectangle);
            }
        }

        public void Add(Led led)
        {
            _leds.Add(led);
        }
    }
}