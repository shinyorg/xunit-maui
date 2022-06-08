namespace Xunit.Runners.Maui.VisualRunner.Pages
{
	partial class TestAssemblyPage : ContentPage
	{
		public TestAssemblyPage()
		{
			InitializeComponent();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			testsList.SelectedItem = null;

			(BindingContext as ViewModelBase)?.OnAppearing();
		}
	}
}