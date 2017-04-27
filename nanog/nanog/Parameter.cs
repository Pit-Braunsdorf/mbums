using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nanog
{
    class Parameter
    {
        public string Name { get; set; }
        public double MinValue { get; set; }
        public double MaxValue { get; set; }
        public double currentValue { get; set; }
        public bool IsFixed { get; set; }
    }
}
