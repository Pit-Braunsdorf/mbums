using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nanog
{
    class MappingHelper
    {
        public static List<ParameterViewModel> Map(IEnumerable source)
        {
            List<ParameterViewModel> result = new List<ParameterViewModel>();

            foreach (var element in source)
            {
                result.Add(element as ParameterViewModel);
            }

            return result;
        }
    }
}
