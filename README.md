# Quickstream REST API - .Net Client Library

The Quickstream REST API .Net library provides integration across the Quickstream platform.

![Build Status](https://travis-ci.org/seanobjames/quickstreamapi-dotnet.svg?branch=master) [![codecov](https://codecov.io/gh/seanobjames/quickstreamapi-dotnet/branch/master/graph/badge.svg)](https://codecov.io/gh/seanobjames/quickstreamapi-dotnet) [![Codacy Badge](https://api.codacy.com/project/badge/Grade/ba4ddfedddfc4bd0950f00050b8d3432)](https://www.codacy.com/app/seanobjames/quickstreamapi-dotnet?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=seanobjames/quickstreamapi-dotnet&amp;utm_campaign=Badge_Grade)

## Dependencies

* .NET Core 2.0

## Quick Start Example

```csharp
using System;
using QuickstreamAPI;
namespace QuickstreamAPIExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var quickstreamAPI = new QuickstreamAPI
            {
                Environment = QuickstreamAPI.Environment.TEST,
                PublishableKey = "thePublishableKey",
                SecretKey = "theSecretKey"
            };

            ... etc. TODO
        }
    }
}
```

## Documentation

* [Official documentation](https://quickstream.westpac.com.au/docs/quickstreamapi/v1/).

## Tests

The unit tests can be run by anyone on any system. The unit tests do not test your integration. Here is an example of how to run unit tests using the dotnet CLI tool from within /test/QuickstreamAPI.Tests:

### On a Windows environment

```text
dotnet restore
dotnet build
dotnet test .
```

## Open Source Attribution

A list of open source projects that help power QuickStream REST API - .Net Client Library are:

## Licence

See the LICENSE file.