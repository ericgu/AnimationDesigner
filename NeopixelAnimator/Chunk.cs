using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Chunk
{
    private uint16_t _numPixels;
    private RGBColor[] _pixels;
    private uint16_t _offset;

    public Chunk(ushort numPixels)
    {
        _numPixels = numPixels;
        _pixels = new RGBColor[numPixels];
    }

    public ushort numPixels()
    {
        return _numPixels;
    }

    public void setPixel(uint16_t index, uint8_t r, uint8_t g, uint8_t b)
    {
        Console.WriteLine("{0}, {1}, {2}", r, g, b);

        _pixels[index] = new RGBColor(r, g, b);
    }

    public RGBColor getNextPixel()
    {
        RGBColor pixel = _pixels[_offset];

        _offset = (ushort) ((_offset + 1)%_numPixels);

        return pixel;
    }

    public void setOffset(uint16_t offset)
    {
        _offset = offset;
    }
}

