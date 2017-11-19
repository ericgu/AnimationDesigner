using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeopixelAnimator
{
    class Program
    {
        static void Main(string[] args)
        {
            Pixel pixel = new Pixel(new RGBColor(255, 0, 0));
            pixel.animateToNewColor(new RGBColor(0, 255, 0), 10);

            for (int i = 0; i < 10; i++)
            {
                RGBColor color = pixel.RGBColor;
                Console.WriteLine(color);
                pixel.update();
            }
            return;




            Adafruit_NeoPixel strip = new Adafruit_NeoPixel(5);

            Mapper mapper = new Mapper(strip);


            RGBColor red = new RGBColor(255, 0, 0);
            RGBColor green = new RGBColor(0, 255, 0);
            RGBColor blue = new RGBColor(0, 0, 255);
            
            Blender blender = new Blender(30);
            blender.addBlend(red, green, 10);
            blender.addBlend(green, blue, 10);
            blender.addBlend(blue, red, 10);

            var chunk2 = blender.getChunk();

            Animator animator = new Animator(mapper, chunk2);

            animator.setOffset(0, 30, 4, 1);

            while (animator.Run()) ;

            animator.setOffset(0, 30, 4, 1);

            while (animator.Run()) ;



            return;


            Chunk chunk = new Chunk(5);
            chunk.setPixel(0, 10, 11, 12);
            chunk.setPixel(1, 22, 23, 24);
            chunk.setPixel(2, 33, 33, 33);
            chunk.setPixel(3, 44, 44, 44);
            chunk.setPixel(4, 55, 55, 55);

            for (ushort i = 0; i < 5; i++)
            {
                chunk.setOffset(i);
                mapper.renderAndShow(chunk);
                strip.show();
            }
        }
    }
}
