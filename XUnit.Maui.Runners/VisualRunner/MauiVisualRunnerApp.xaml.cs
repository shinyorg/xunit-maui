using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls;
using XUnit.Maui.Runners.VisualRunner.Pages;

namespace XUnit.Maui.Runners.VisualRunner
{
	partial class MauiVisualRunnerApp : Application
	{
		readonly TestOptions _options;
		readonly ILogger _logger;

		public MauiVisualRunnerApp(TestOptions options, ILogger logger)
		{
			_options = options;
			_logger = logger;

			InitializeComponent();
		}

		protected override Window CreateWindow(IActivationState? activationState)
		{
			var hp = new HomePage();

			var nav = new TestNavigator(hp.Navigation);

			var runner = new DeviceRunner(_options.Assemblies, nav, _logger);

			var vm = new HomeViewModel(nav, runner);

			hp.BindingContext = vm;

			var navPage = new NavigationPage(hp);

			return new Window(navPage);
		}
	}
}