using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using NeopixelAnimator;


class Animator
{
    private Mapper _mapper;
    private Chunk _chunk;
    private uint16_t _offsetCount;
    private uint16_t _offsetMin;
    private uint16_t _offsetMax;

    private uint16_t _offset;
    private uint16_t _offsetWait;
    private uint16_t _offsetIncrement;

    public Animator(Mapper mapper, Chunk chunk)
    {
        _chunk = chunk;
        _mapper = mapper;
    }

    public void setOffset(uint16_t offsetMin, uint16_t offsetMax, uint16_t offsetCount, uint16_t offsetIncrement)
    {
        _offsetIncrement = offsetIncrement;
        _offsetMax = offsetMax;
        _offsetMin = offsetMin;
        _offsetCount = offsetCount;
        _offset = _offsetMin;
        _offsetWait = 0;
    }

    public bool Run()
    {
        Console.WriteLine(_offsetWait);
        if (_offsetWait == _offsetCount)
        {
            _offset += _offsetIncrement;
            if (_offset == _offsetMax)
            {
                return false;
            }

            Console.WriteLine("Render");
            _chunk.setOffset(_offset);
            _mapper.renderAndShow(_chunk);

            _offsetWait = 0;
        }
        _offsetWait++;

        return true;
    }

    // set
    // starting offset
    // ending offset
    // number of cycles between change in offset. 
    //
    // code will drive chunk offset and tell strip to show (maybe mapper should add show). 

}

