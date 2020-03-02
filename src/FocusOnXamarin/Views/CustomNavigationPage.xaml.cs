using Xamarin.Forms;

namespace FocusOnXamarin.Views
{
	public partial class CustomNavigationPage : NavigationPage
	{
		public CustomNavigationPage() : base()
		{
			InitializeComponent();
		}

		public CustomNavigationPage(Page root) : base(root)
		{
			InitializeComponent();
		}
	}
}