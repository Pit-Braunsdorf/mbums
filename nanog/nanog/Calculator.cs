using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using OxyPlot.Series;

namespace nanog
{
    class Calculator
    {
        private static List<ParameterViewModel> _paramModel;

        public static PlotModel Calculate(List<ParameterViewModel> paramModel)
        {
            var plotModel = new PlotModel();

            _paramModel = paramModel;
            //Getting all Parameters
            //1(molecules * timeUnit)
            var u = paramModel.Single(x => x.Parameter == ParameterEnum.U).Value;

            //molecules / timeUnit
            var s1 = paramModel.Single(x => x.Parameter == ParameterEnum.S1).Value;
            var s2 = paramModel.Single(x => x.Parameter == ParameterEnum.S2).Value;
            var s3 = paramModel.Single(x => x.Parameter == ParameterEnum.S3).Value;
            var s4 = paramModel.Single(x => x.Parameter == ParameterEnum.S4).Value;

            var k1 = paramModel.Single(x => x.Parameter == ParameterEnum.K1).Value;
            var k2 = paramModel.Single(x => x.Parameter == ParameterEnum.K2).Value;
            var k3 = paramModel.Single(x => x.Parameter == ParameterEnum.K3).Value;
            var k4 = paramModel.Single(x => x.Parameter == ParameterEnum.K4).Value;

            var f = paramModel.Single(x => x.Parameter == ParameterEnum.F).Value;

            var d_o = paramModel.Single(x => x.Parameter == ParameterEnum.DO).Value;
            var d_s = paramModel.Single(x => x.Parameter == ParameterEnum.DS).Value;
            var d_os = paramModel.Single(x => x.Parameter == ParameterEnum.DOS).Value;
            var d_n = paramModel.Single(x => x.Parameter == ParameterEnum.DN).Value;

            var gamma_os = paramModel.Single(x => x.Parameter == ParameterEnum.GammaOS).Value;
            var gamma_n = paramModel.Single(x => x.Parameter == ParameterEnum.GammaN).Value;

            var sigma = paramModel.Single(x => x.Parameter == ParameterEnum.Sigma).Value;
            
            plotModel.Series.Add(new FunctionSeries(time => Calculate(time, u, s1, s2, s3, s4, k1, k2, k3, k4, f, d_o, d_s, d_os, d_n, gamma_os, gamma_n, sigma), 0, 10, 0.1, "Nanog Level per Time"));

            return plotModel;
        }

        private static double Calculate(double time, double u, double s1, double s2, double s3, double s4, double k1, double k2, double k3, double k4, double f, double d_o, double d_s, double d_os, double d_n, double gamma_os, double gamma_n, double sigma)
        {
            var cOS = CalculateOS(u, s1, gamma_os, k1, d_o, s2, k2, d_s, d_os);

            return CalculateNanog(s4, gamma_n, k4, s3, k3, d_n, sigma, cOS);
        }

        private static double CalculateNanog(double s4, double gamma_n, double k4, double s3, double k3, double d_n, double sigma, double cOS)
        {
            //TODO Implement
            return 1;
        }
        
        private static double CalculateOS(double u, double s1, double gammaOs, double k1, double dO, double s2, double k2, double dS, double dOs)
        {
            //TODO Implement
            return 0;
        }
    }
}
