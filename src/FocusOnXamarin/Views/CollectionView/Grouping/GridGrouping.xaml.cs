using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FocusOnXamarin.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GridGrouping : ContentPage
	{
		public GridGrouping()
		{
			InitializeComponent();
			CollectionView.ItemsSource = new SuperTeams();
		}
	}
}