using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.Modell
{
    class Pass
    {
        public uint ClassesId { get; private set; }
        public uint Id { get; private set; }
        public bool IsNormal { get; private set; }
        public decimal Price { get; private set; }
        public string Type { get; private set; }
    }
}
