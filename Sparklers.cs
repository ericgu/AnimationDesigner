using System;
using System.Collections.Generic;

namespace AnimationDesigner
{
    public class Sparklers
    {
        private readonly Dictionary<Led, Sparkler> _sparklers = new Dictionary<Led, Sparkler>();
        private readonly Random _random = new Random();
        private readonly int _threshold;

        public Sparklers(int threshold)
        {
            _threshold = threshold;
        }

        public void HandleSparkle(Led led)
        {
            Sparkler sparkler;
            _sparklers.TryGetValue(led, out sparkler);

            if (sparkler != null)
            {
                led.Color = RgbColor.Blend(led.Color, new RgbColor(255, 255, 255), sparkler.Count, Sparkler.Max);

                sparkler.Count--;
                if (sparkler.Count == 0)
                {
                    _sparklers.Remove(led);
                }
            }
            else
            {
                if (_random.Next(10000) > _threshold)
                {
                    sparkler = new Sparkler();
                    _sparklers.Add(led, sparkler);
                }
            }
        }
    }
}