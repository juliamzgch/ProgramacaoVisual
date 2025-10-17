using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A02_Slides_JM
{
    // por omissão: tipo subjacente é byte e começa em 0
    enum Season2 : byte
    {
        Spring, Summer, Fall, Autumn = Fall, Winter
    };
}
