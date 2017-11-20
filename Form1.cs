using System.Drawing;
using System.Windows.Forms;

namespace AnimationDesigner
{
    public partial class Form1 : Form
    {
        private readonly Timer _timer;
        private readonly IAnimate _animation;
        private readonly SnowflakeLeds _snowflakeLeds;
        private readonly Graphics _graphics;

        public Form1()
        {
            InitializeComponent();
            _graphics = CreateGraphics();

            //_animation = new AnimateAngular();
            //_animation = new AnimateDistance();
            _animation = new AnimateSparkle();

            _timer = new Timer();
            _timer.Tick += Timer_Tick;
            _timer.Interval = 10;
            _timer.Start();

            Paint += Form1_Paint;
            _snowflakeLeds = new SnowflakeLeds();
        }

        private void Timer_Tick(object sender, System.EventArgs e)
        {
            Form1_Paint(sender, null);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            _snowflakeLeds.UpdateColors(_animation);
            _snowflakeLeds.Draw(Bounds, _graphics);
        }
    }
}
