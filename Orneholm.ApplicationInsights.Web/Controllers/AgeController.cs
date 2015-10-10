using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace Orneholm.ApplicationInsights.Web.Controllers
{
    public class AgeController : ApiController
    {
        private readonly IPoAiDemoApi _poAiDemoApi;

        public AgeController()
        {
            _poAiDemoApi = new PoAiDemoApi();
        }

        public async Task<double> Get(DateTime dateOfBirth)
        {
            var age = await _poAiDemoApi.AgeCalculator.GetByDateofbirthWithOperationResponseAsync(dateOfBirth);
            return age.Body.Days ?? 0;
        }
    }
}