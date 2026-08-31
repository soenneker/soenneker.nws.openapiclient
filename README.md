[![](https://img.shields.io/nuget/v/soenneker.nws.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.nws.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.nws.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.nws.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.nws.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.nws.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.nws.openapiclient/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.nws.openapiclient/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Nws.OpenApiClient

Typed request builders and models for forecasts, alerts, stations, observations, and other National Weather Service data.

## Installation

```bash
dotnet add package Soenneker.Nws.OpenApiClient
```

## Usage

The NWS API requires an identifying User-Agent:

```csharp
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.Nws.OpenApiClient;

var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
    "my-weather-app/1.0 (contact@example.com)");

var adapter = new HttpClientRequestAdapter(
    new AnonymousAuthenticationProvider(),
    httpClient: httpClient);

var client = new NwsOpenApiClient(adapter);
var alertTypes = await client.Alerts.Types.GetAsync(cancellationToken: cancellationToken);
```

The generated client defaults to `https://api.weather.gov`.

For application registration, configuration-based User-Agent values, and managed client reuse, use [`Soenneker.Nws.OpenApiClientUtil`](https://github.com/soenneker/soenneker.nws.openapiclientutil).
