namespace AnimationDesigner
{
    public class AnimateAngular : IAnimate
    {
        private readonly RgbColor _red;
        private readonly RgbColor _yellow;
        private readonly RgbColor _green;
        private readonly RgbColor _cyan;
        private readonly RgbColor _blue;
        private readonly RgbColor _purple;
        private int _rotation;


        public AnimateAngular()
        {
            _red = new RgbColor(255, 0, 0);
            _yellow = new RgbColor(255, 255, 0);
            _green = new RgbColor(0, 255, 0);
            _cyan = new RgbColor(0, 255, 255);
            _blue = new RgbColor(0, 0, 255);
            _purple = new RgbColor(255, 0, 255);
        }

        public void UpdateColors(LedCollection ledCollection)
        {
            _rotation += 1;

            foreach (Led led in ledCollection.Items)
            {
                int angle = (led.Angle + _rotation) % 360;

                if (led.Distance != 0)
                {
                    int color = angle / 60;
                    int percentAmount = angle - color * 60;
                    var percentSize = 60;

                    switch (color)
                    {
                        case 0:
                            SetColor(led, _red, _yellow, percentAmount, percentSize);
                            break;

                        case 1:
                            SetColor(led, _yellow, _green, percentAmount, percentSize);
                            break;

                        case 2:
                            SetColor(led, _green, _cyan, percentAmount, percentSize);
                            break;

                        case 3:
                            SetColor(led, _cyan, _blue, percentAmount, percentSize);
                            break;

                        case 4:
                            SetColor(led, _blue, _purple, percentAmount, percentSize);
                            break;

                        case 5:
                            SetColor(led, _purple, _red, percentAmount, percentSize);
                            break;
                    }
                }
            }
        }

        private static void SetColor(Led led, RgbColor color1, RgbColor color2, int fraction, int denominator)
        {
            led.SetColor(RgbColor.Blend(color1, color2, fraction, denominator));
        }
    }
}