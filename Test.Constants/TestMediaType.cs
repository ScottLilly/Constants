using System.Net.Mime;

namespace Test.Constants
{
    public class TestMediaType
    {
        [Fact]
        public void Test_MediaTypeValues()
        {
            var test = MediaTypeNames.Application.Json;
        }
    }
}