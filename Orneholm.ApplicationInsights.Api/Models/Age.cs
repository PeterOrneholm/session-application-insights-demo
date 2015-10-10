using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Orneholm.ApplicationInsights.Api.Models
{
    public class Age
    {
        public Age(double days, double hours)
        {
            Days = days;
            Hours = hours;
        }

        public double Days { get; private set; }
        public double Hours { get; private set; }
    }
}