using Microsoft.Extensions.Configuration;

namespace HelloWorldCoreApp
{
    public class HelloWorld : IHelloWorld
    {
        private IConfiguration _configuration;

        public HelloWorld(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string GetMessageHelloWorld()
        {
            return _configuration["HelloWorld"];
        }
    }
}
