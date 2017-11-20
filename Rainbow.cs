namespace AnimationDesigner
{
    public class Rainbow
    {
        private readonly RgbColor _red;
        private readonly RgbColor _yellow;
        private readonly RgbColor _green;
        private readonly RgbColor _cyan;
        private readonly RgbColor _blue;
        private readonly RgbColor _purple;

        public Rainbow(byte intensity)
        {
            _red = new RgbColor(intensity, 0, 0);
            _yellow = new RgbColor(intensity, intensity, 0);
            _green = new RgbColor(0, intensity, 0);
            _cyan = new RgbColor(0, intensity, intensity);
            _blue = new RgbColor(0, 0, intensity);
            _purple = new RgbColor(intensity, 0, intensity);
        }

        public void SetRainbowColor(Led led, int color, int percentAmount, int percentSize)
        {
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

        private static void SetColor(Led led, RgbColor color1, RgbColor color2, int fraction, int denominator)
        {
            led.Color = RgbColor.Blend(color1, color2, fraction, denominator);
        }

        public void HandleRainbow(Led led, int distance, int size)
        {
            int color = distance / size;
            int percentAmount = distance - color * size;
            var percentSize = size;

            SetRainbowColor(led, color, percentAmount, percentSize);
        }
    }
}