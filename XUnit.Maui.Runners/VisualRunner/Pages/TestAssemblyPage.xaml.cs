#nullable enable
using Microsoft.Maui.Controls;

namespace XUnit.Maui.Runners.VisualRunner.Pages
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

			if (BindingContext is ViewModelBase vm)
				vm.OnAppearing();
		}
	}
}