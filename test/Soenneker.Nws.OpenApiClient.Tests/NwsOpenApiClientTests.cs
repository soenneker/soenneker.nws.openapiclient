using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Nws.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class NwsOpenApiClientTests : FixturedUnitTest
{
    public NwsOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {

    }

    [Fact]
    public void Default()
    {

    }
}
