using System.Drawing;

namespace AnimationDesigner
{
    public class SnowflakeLeds
    {
        private readonly LedCollection _ledCollection;

        public SnowflakeLeds()
        {
            _ledCollection = new LedCollection();

            CreateArm(0);
            CreateArm(60);
            CreateArm(120);

            Led led = new Led(0, 0);
            led.SetColor(new RgbColor(255, 255, 255));
            _ledCollection.Add(led);

            CreateArm(180);
            CreateArm(240);
            CreateArm(300);
        }

        private void CreateArm(int angle)
        {
            AddLed(angle, 20);
            AddLed(angle, 40);
            AddLed(angle, 60);
            AddLed(angle - 13, 74);
            AddLed(angle - 22, 89);
            AddLed(angle, 80);
            AddLed(angle, 100);
            AddLed(angle + 13, 74);
            AddLed(angle + 22, 89);
        }

        private void AddLed(int angle, int distance)
        {
            Led led2 = new Led(angle, distance);
            led2.SetColor(new RgbColor(0, 0, 255));
            _ledCollection.Add(led2);
        }

        public void Draw(Rectangle bounds, Graphics graphics)
        {
            _ledCollection.Draw(bounds, graphics);
        }

        public void UpdateColors(IAnimate animateAngular)
        {
            animateAngular.UpdateColors(_ledCollection);
        }
    }
}