using Soenneker.Tests.HostedUnit;

namespace Soenneker.Nws.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class NwsOpenApiClientTests : HostedUnitTest
{
    public NwsOpenApiClientTests(Host host) : base(host)
    {

    }

    [Test]
    public void Default()
    {

    }
}
