# Quickstream REST API - .Net Client Library

The Quickstream REST API .Net library provides integration across the Quickstream platform.

![Build Status](https://travis-ci.org/seanobjames/quickstreamapi-dotnet.svg?branch=master)

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