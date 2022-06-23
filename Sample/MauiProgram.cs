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
#if RUN_HEADLESS
			// you cannot have both - best to set a compiler flag in project
			.UseHeadlessRunner(new HeadlessRunnerOptions
			{
				RequiresUIContext = true
			})
#endif
			.Build();
	}
}