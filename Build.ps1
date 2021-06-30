$artifacts = ".\artifacts"

### Clean artifacts folder ###
Write-Host "### Cleaning artifacts folder... ###"
if(Test-Path $artifacts) { Remove-Item $artifacts -Force -Recurse }

### Fruits Library ###
Write-Host "### dotnet clean... ###"
dotnet clean .\src\HeboTech.Fruits\HeboTech.Fruits.csproj -c Release

Write-Host "### dotnet build... ###"
dotnet build .\src\HeboTech.Fruits\HeboTech.Fruits.csproj -c Release

Write-Host "### dotnet test... ###"
dotnet test .\src\Tests\HeboTech.Fruits.Tests\HeboTech.Fruits.Tests.csproj -c Release

Write-Host "### dotnet pack... ###"
dotnet pack .\src\HeboTech.Fruits\HeboTech.Fruits.csproj -c Release -o $artifacts --no-build

### Fruits ASP.Net Core Library ###
Write-Host "### dotnet clean... ###"
dotnet clean .\src\HeboTech.Fruits.AspNetCore\HeboTech.Fruits.AspNetCore.csproj -c Release

Write-Host "### dotnet build... ###"
dotnet build .\src\HeboTech.Fruits.AspNetCore\HeboTech.Fruits.AspNetCore.csproj -c Release

Write-Host "### dotnet test... ###"
dotnet test .\src\Tests\HeboTech.Fruits.AspNetCore.Tests\HeboTech.Fruits.AspNetCore.Tests.csproj -c Release

Write-Host "### dotnet pack... ###"
dotnet pack .\src\HeboTech.Fruits.AspNetCore\HeboTech.Fruits.AspNetCore.csproj -c Release -o $artifacts --no-build