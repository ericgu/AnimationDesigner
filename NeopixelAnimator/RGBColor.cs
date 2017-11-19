using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


struct RGBColor
{
    public RGBColor(uint8_t red, uint8_t green, uint8_t blue)
    {
        this.red = red;
        this.green = green;
        this.blue = blue;
    }

    public uint8_t red;
    public uint8_t green;
    public uint8_t blue;

    public override string ToString()
    {
        return string.Format("({0}, {1}, {2}", red, green, blue);
    }
}

