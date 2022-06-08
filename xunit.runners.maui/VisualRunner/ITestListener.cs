#nullable enable
namespace Xunit.Runners.Maui.VisualRunner
{
	public interface ITestListener
	{
		void RecordResult(TestResultViewModel result);
	}
}