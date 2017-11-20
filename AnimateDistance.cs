using System;

namespace AnimationDesigner
{
    public class AnimateDistance : IAnimate
    {
        private int _distance;
        private readonly Rainbow _rainbow = new Rainbow(255);

        public void UpdateColors(LedCollection ledCollection)
        {
            _distance -= 1;
            if (_distance < 0)
            {
                _distance = Int32.MaxValue;
            }

            foreach (Led led in ledCollection.Items)
            {
                int distance = (led.Distance + _distance) % 600;

                _rainbow.HandleRainbow(led, distance, 100);
            }
        }
    }
}