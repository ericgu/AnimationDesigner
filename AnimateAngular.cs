namespace AnimationDesigner
{
    public class AnimateAngular : IAnimate
    {
        private int _rotation;
        private readonly Rainbow _rainbow = new Rainbow(255);

        public void UpdateColors(LedCollection ledCollection)
        {
            _rotation += 1;

            foreach (Led led in ledCollection.Items)
            {
                int angle = (led.Angle + _rotation) % 360;

                if (led.Distance != 0)
                {
                    _rainbow.HandleRainbow(led, angle, 60);
                }
            }
        }
    }
}