using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FocusOnXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GroupingPlusSelection : ContentPage
	{
		public GroupingPlusSelection ()
		{
			InitializeComponent ();
			CollectionView.ItemsSource = new SuperTeams();
		}
	}
}