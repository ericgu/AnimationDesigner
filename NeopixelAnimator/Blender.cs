﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Blender
{
    private uint16_t _totalSize;
    private Chunk _chunk;
    private uint16_t _offset;

    public Blender(uint16_t totalSize)
    {
        _totalSize = totalSize;

        _chunk = new Chunk(_totalSize);
    }

    public Chunk getChunk()
    {
        return _chunk;
    }

    public void addBlend(RGBColor color1, RGBColor color2, uint16_t steps)
    {
        uint16_t redDelta = (uint16_t) (((color2.red - color1.red) << 8)/steps);
        uint16_t greenDelta = (uint16_t) (((color2.green - color1.green) << 8)/steps);
        uint16_t blueDelta = (uint16_t) (((color2.blue - color1.blue) << 8)/steps);

        uint16_t red = (uint16_t) (color1.red << 8);
        uint16_t green = (uint16_t) (color1.green << 8);
        uint16_t blue = (uint16_t) (color1.blue << 8);

        for (uint16_t i = _offset; i < _offset + steps; i++)
        {
            _chunk.setPixel(i, (byte) (red >> 8), (byte) (green >> 8), (byte) (blue >> 8));
            red = (uint16_t) (red + redDelta);
            green = (uint16_t) (green + greenDelta);
            blue = (uint16_t) (blue + blueDelta);
        }

        _offset = (uint16_t) (_offset + steps);
    }

}


