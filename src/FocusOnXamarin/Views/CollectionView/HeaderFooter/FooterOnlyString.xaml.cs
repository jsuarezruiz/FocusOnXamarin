using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FocusOnXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FooterOnlyString : ContentPage
	{
		readonly DemoFilteredItemSource _demoFilteredItemSource = new DemoFilteredItemSource(20);

		public FooterOnlyString()
		{
			InitializeComponent();

			CollectionView.ItemTemplate = ExampleTemplates.PhotoTemplate();
			CollectionView.ItemsSource = _demoFilteredItemSource.Items;
		}
	}
}