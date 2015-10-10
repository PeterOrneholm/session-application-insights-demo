using System;
using System.Threading.Tasks;
using System.Web.Http;
using Orneholm.ApplicationInsights.Api.Models;

namespace Orneholm.ApplicationInsights.Api.Controllers
{
    public class AgeCalculatorController : ApiController
    {
        public async Task<Age> Get(DateTime dateOfBirth)
        {
            var age = DateTime.Now.Subtract(dateOfBirth);

            await Task.Delay(TimeSpan.FromMilliseconds(age.TotalDays / 2));

            return new Age(age.TotalDays, age.TotalHours);
        }
    }
}
