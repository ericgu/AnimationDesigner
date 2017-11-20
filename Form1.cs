using System.Drawing;
using System.Windows.Forms;

namespace AnimationDesigner
{
    public partial class Form1 : Form
    {
        private readonly Timer _timer;
        private IAnimate _animation;
        private readonly SnowflakeLeds _snowflakeLeds;

        public Form1()
        {
            InitializeComponent();

            _animation = new AnimateAngular();
            _animation = new AnimateDistance();

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
            Graphics graphics = CreateGraphics();

            _snowflakeLeds.UpdateColors(_animation);
            _snowflakeLeds.Draw(Bounds, graphics);
        }
    }
}
