using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace nanog
{
    class ParameterViewModel
    {
        public ParameterEnum Parameter { get; set; }
        public double Value { get; set; }
        public double? MinValue { get; set; }
        public double? MaxValue { get; set; }
        public double? Steps { get; set; }

        public static List<ParameterViewModel> InitTable()
        {
            var result = new List<ParameterViewModel>
            {
                new ParameterViewModel
                {
                    Parameter = ParameterEnum.U,
                    Value = 0.03
                },
                new ParameterViewModel
                {
                    Parameter = ParameterEnum.S1,
                    Value = 50
                },
                new ParameterViewModel()
                {
                    Parameter = ParameterEnum.S2,
                    Value = 50
                },
                new ParameterViewModel()
                {
                    Parameter = ParameterEnum.S3,
                    Value = 0.1
                },
                new ParameterViewModel()
                {
                    Parameter = ParameterEnum.S4,
                    Value = 14
                },
                new ParameterViewModel()
                {
                    Parameter = ParameterEnum.K1,
                    Value = 10
                },
                new ParameterViewModel()
                {
                    Parameter = ParameterEnum.K2,
                    Value = 10
                },
                new ParameterViewModel()
                {
                    Parameter = ParameterEnum.K3,
                    Value = 10
                },
                new ParameterViewModel()
                {
                    Parameter = ParameterEnum.K4,
                    Value = 10
                },
                new ParameterViewModel()
                {
                    Parameter = ParameterEnum.F,
                    Value = 270
                },
                new ParameterViewModel()
                {
                    Parameter = ParameterEnum.DO,
                    Value = 1
                },
                new ParameterViewModel()
                {
                    Parameter = ParameterEnum.DS,
                    Value = 1
                },
                new ParameterViewModel()
                {
                    Parameter = ParameterEnum.DOS,
                    Value = 1
                },
                new ParameterViewModel()
                {
                    Parameter = ParameterEnum.DN,
                    Value = 1
                },
                new ParameterViewModel()
                {
                    Parameter = ParameterEnum.GammaOS,
                    Value = 1
                },
                new ParameterViewModel()
                {
                    Parameter = ParameterEnum.GammaN,
                    Value = 2
                },
                new ParameterViewModel()
                {
                    Parameter = ParameterEnum.Sigma,
                    Value = 12
                }
            };

            return result;
        }
    }
}
