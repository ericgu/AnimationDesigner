
    using System;

class Pixel
    {
        RGBColor _color;

        PixelAnimator _pixelAnimator;

        public Pixel(RGBColor color)
        {
            _color = color;
        }

        public void animateToNewColor(RGBColor newColor, int steps)
        {
            _pixelAnimator = new PixelAnimator(_color, newColor, steps);
        }

        public void update()
        {
            if (_pixelAnimator != null)
            {
                _color = _pixelAnimator.getNextColor();

                if (_pixelAnimator.isDone())
                {
                    _pixelAnimator = null;
                }
            }
        }

        public RGBColor RGBColor
        {
            get { return _color; }
        }
    }

internal class PixelAnimator
{
    private RGBColor _targetColor;
    private int _steps;
    private uint16_t _redDelta;
    private uint16_t _greenDelta;
    private uint16_t _blueDelta;
    private uint16_t _red;
    private uint16_t _green;
    private uint16_t _blue;

    public PixelAnimator(RGBColor currentColor, RGBColor targetColor, int steps)
    {
        _steps = steps;
        _targetColor = targetColor;

        _red = (uint16_t) (currentColor.red << 8);
        _green = (uint16_t) (currentColor.green << 8);
        _blue = (uint16_t) (currentColor.blue << 8);

        _redDelta = (uint16_t) (((targetColor.red - currentColor.red) << 8)/steps);
        _greenDelta = (uint16_t) (((targetColor.green - currentColor.green) << 8)/steps);
        _blueDelta = (uint16_t) (((targetColor.blue - currentColor.blue) << 8)/steps);
    }

    public RGBColor getNextColor()
    {
        _steps--;
        _red = (uint16_t) (_red + _redDelta);
        _green = (uint16_t) (_green + _greenDelta);
        _blue = (uint16_t) (_blue + _blueDelta);

        return new RGBColor((uint8_t) (_red >> 8), (uint8_t) (_green >> 8), (uint8_t) (_blue >> 8));
    }

    public bool isDone()
    {
        return _steps == 0;
    }
}

