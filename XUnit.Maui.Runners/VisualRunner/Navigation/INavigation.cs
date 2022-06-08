using System.Threading.Tasks;

namespace XUnit.Maui.Runners.VisualRunner
{
	public interface ITestNavigation
	{
		Task NavigateTo(PageType page, object? dataContext = null);
	}
}