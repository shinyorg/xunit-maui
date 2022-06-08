#nullable enable
namespace XUnit.Maui.Runners.VisualRunner
{
	public interface ITestListener
	{
		void RecordResult(TestResultViewModel result);
	}
}