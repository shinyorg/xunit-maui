using Xunit.Runners.Maui;

namespace Sample
{
	public static class MauiProgram
	{
		public static MauiApp CreateMauiApp()
		{
			var appBuilder = MauiApp.CreateBuilder();
			appBuilder
				.ConfigureTests(new TestOptions
				{
					Assemblies =
					{
						typeof(MauiProgram).Assembly
					}
				})
				//.UseHeadlessRunner(new HeadlessRunnerOptions
				//{
				//	RequiresUIContext = true,
				//})
				.UseVisualRunner();

			return appBuilder.Build();
		}
	}
}