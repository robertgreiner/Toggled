using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toggled.Features;

namespace Toggled
{
    public static class NumberService
    {
        public static double ProcessNumber(double number)
        {
            var value = number;
            var roundUp = new RoundUp();
            if (roundUp.FeatureEnabled)
            {
                value = Math.Ceiling(value);
            }
            return value;
        }
    }
}
