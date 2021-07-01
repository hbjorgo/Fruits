# Fruits
[![CI](https://github.com/hbjorgo/Fruits/workflows/CI/badge.svg)](https://github.com/hbjorgo/Fruits)
[![Nuget](https://img.shields.io/nuget/v/HeboTech.Fruits)](https://www.nuget.org/packages/HeboTech.Fruits)
[![Nuget](https://img.shields.io/nuget/dt/HeboTech.Fruits)](https://www.nuget.org/packages/HeboTech.Fruits)


Return the fruits of your work in your applications!

Result models that can be returned from services. Use them to return data, errors and response types using a coherent interface. Works great in APIs, CQRS applications etc.

There are two NuGet packages:
- HeboTech.Fruits
- HeboTech.Fruits.AspNetCore

The first one includes all the result types, the other one includes extension methods to easily transform the results into HTTP responses.
Use just the core library, or install both if you're working with an API.

## Installation
Install as NuGet package, either using your favorite IDE or the CLI:
```shell
dotnet add package HeboTech.Fruits

dotnet add package HeboTech.Fruits.AspNetCore
```

## Usage

### Service
```
public Result<MyData> GetResult()
{
  try
  {
    MyData myData = database.GetData();

    if (myData == null)
      return new NotFoundResult<MyData>("MyData not found");

    return new OkResult<MyData>(myData);
  }
  catch (Exception ex)
  {
    return new UnexpectedResult<MyData>("Something went wrong");
  }
}
```

### Controller:
```
public class MyController : Controller
{
  [HttpGet]
  public IActionResult Get()
  {
    Result<MyData> result = service.GetResult();
    return this.FromResult(result); // This is the extension method
  }
}
```