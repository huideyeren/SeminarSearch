using Xamarin.Forms;
using SeminarSearch.Views;
using Prism.Unity;

namespace SeminarSearch
{
	public partial class App : PrismApplication
	{
		protected override void OnInitialized()
		{
			InitializeComponent();
			this.NavigationService.NavigateAsync("MainPage");
		}

		protected override void RegisterTypes()
		{
			this.Container.RegisterTypeForNavigation<MainPage>();
		}
	}
}
