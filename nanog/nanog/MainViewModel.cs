using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using OxyPlot.Series;

namespace nanog
{
    class MainViewModel
    {
        public PlotModel MyModel { get; private set; }

        public MainViewModel()
        {
            this.MyModel = new PlotModel { Title = "Example 1" };
            this.MyModel.Series.Add(new FunctionSeries(x => x, 0, 10, 0.1, "x"));
        }

        public void Calculate()
        {
            MyModel.Series.Clear();
            MyModel.Series.Add(new FunctionSeries(Math.Cos, 0, 0.1, 10, "cos(x)"));
        }
    }
}
