using System.Threading.Tasks;

namespace Xunit.Runners.Maui.VisualRunner
{
	public interface ITestNavigation
	{
		Task NavigateTo(PageType page, object? dataContext = null);
	}
}