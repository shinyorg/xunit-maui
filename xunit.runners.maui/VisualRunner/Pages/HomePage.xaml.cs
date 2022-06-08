namespace Xunit.Runners.Maui.VisualRunner.Pages
{
	partial class HomePage : ContentPage
	{
		public HomePage()
		{
			InitializeComponent();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			assemblyList.SelectedItem = null;
			(BindingContext as ViewModelBase)?.OnAppearing();
		}
	}
}