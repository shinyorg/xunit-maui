# Xunit.Runners.Maui 

## Ported From
* https://github.com/xunit/devices.xunit
* https://github.com/dotnet/maui/tree/main/src/TestUtils

## Setup

1. Create a new MAUI application.
2. Delete the standard App.xaml & App.xaml.cs
3. Install Xunit.Runners.Maui nuget
4. Create tests in this project or reference another project containing your tests.
5. Create a MauiProgram like shown below - NOTE: It is not recommended you put any dependencies here

```csharp
using Xunit.Runners.Maui;

namespace Sample
{
	public static class MauiProgram
	{
		public static MauiApp CreateMauiApp() => MauiApp
			.CreateBuilder()
			.ConfigureTests(new TestOptions
			{
				Assemblies =
				{
					typeof(MauiProgram).Assembly
				}
			})
			.UseVisualRunner()
			.Build();
	}
}
```