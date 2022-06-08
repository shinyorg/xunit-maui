#nullable enable
using Microsoft.Maui.Controls;

namespace XUnit.Maui.Runners.VisualRunner.Pages
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

			if (BindingContext is ViewModelBase vm)
				vm.OnAppearing();
		}
	}
}