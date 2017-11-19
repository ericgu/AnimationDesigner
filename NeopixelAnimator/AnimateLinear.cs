using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeopixelAnimator
{
    class AnimateLinear
    {


        public AnimateLinear(uint16_t offsetMin, uint16_t offsetMax, uint16_t offsetCount, uint16_t offsetIncrement)
        {
            _offsetIncrement = offsetIncrement;
            _offsetMax = offsetMax;
            _offsetMin = offsetMin;
            _offsetCount = offsetCount;
            _offset = _offsetMin;
            _offsetWait = 0;
        }

    }
}
