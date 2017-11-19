using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeopixelAnimator
{
    class Adafruit_NeoPixel
    {
        private ushort _numPixels;
        private uint[] pixels;

        // Constructor: number of LEDs, pin number, LED type
        public Adafruit_NeoPixel(uint16_t numPixels)
        {
            _numPixels = numPixels;
            pixels = new uint[numPixels];
        }

        public void show()
        {
            for (ushort i = 0; i < _numPixels; i++)
            {
                byte red = (byte) (pixels[i] >> 16);
                byte green = (byte) ((pixels[i] >> 8) % 256);
                byte blue = (byte) (pixels[i] % 256);
                Console.Write("({0},{1},{2}) ", red, green, blue);
            }
            Console.WriteLine();
        }

        public ushort numPixels()
        {
            return _numPixels;
        }

        public void setPixelColor(uint16_t n, uint8_t r, uint8_t g, uint8_t b)
        {
            pixels[n] = (uint) (r << 16 | g << 8 | b);
        }

        public void setPixelColor(uint16_t n, uint8_t r, uint8_t g, uint8_t b, uint8_t w)
        {
        }

        public void setPixelColor(uint16_t n, uint32_t c)
        {
            pixels[n] = c;
        }


        public void setBrightness(byte brightness)
        {
        }

        public void clear()
        {
            for (ushort i = 0; i < _numPixels; i++)
            {
                pixels[i] = 0;
            }
        }

        //     * getPixels(void) const,

        public static uint Color(byte r, byte g, byte b)
        {
            return 0;
        }
    }
}