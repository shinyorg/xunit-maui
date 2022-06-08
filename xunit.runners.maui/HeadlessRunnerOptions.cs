namespace Xunit.Runners.Maui
{
	public class HeadlessRunnerOptions
	{
		public string TestResultsFilename { get; set; } = "TestResults.xml";

		public bool RequiresUIContext { get; set; } = true;
	}
}