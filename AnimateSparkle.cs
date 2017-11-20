namespace AnimationDesigner
{
    public class AnimateSparkle : IAnimate
    {
        private const int Slowness = 1000;
        private int _distance;
        private readonly Rainbow _rainbow = new Rainbow(128);
        private readonly Sparklers _sparklers = new Sparklers(9990);

        public void UpdateColors(LedCollection ledCollection)
        {
            _distance += 1;

            foreach (Led led in ledCollection.Items)
            {
                int distance = _distance % (6 * Slowness);

                _rainbow.HandleRainbow(led, distance, Slowness);

                _sparklers.HandleSparkle(led);
            }
        }
    }
}