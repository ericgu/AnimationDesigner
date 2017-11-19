using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeopixelAnimator
{
class Mapper
{
    private Adafruit_NeoPixel _strip;

    public Mapper(Adafruit_NeoPixel strip)
    {
        _strip = strip;
    }

    public void renderAndShow(Chunk chunk)
    {
        var numPixels = _strip.numPixels();

        for (uint16_t i = 0; i < numPixels; i++)
        {
            RGBColor color = chunk.getNextPixel();

            _strip.setPixelColor(i, color.red, color.green, color.blue);
        }

        _strip.show();
    }
}
}
