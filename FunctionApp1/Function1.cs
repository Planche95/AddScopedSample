using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using System.Threading.Tasks;

namespace FunctionApp1
{
    public class Function1
    {
        private readonly Foo _foo;
        private readonly Bar _bar;
        public Function1(Foo foo, Bar bar)
        {
            _foo = foo;
            _bar = bar;
        }

        [FunctionName("Function1")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req)
        {
            return new OkObjectResult($"Hello");
        }
    }
}
