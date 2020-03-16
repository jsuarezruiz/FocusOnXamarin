using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.WindowsSpecific;
using static Xamarin.Forms.PlatformConfiguration.WindowsSpecific.RefreshView;
using WindowsOS = Xamarin.Forms.PlatformConfiguration.Windows;

namespace FocusOnXamarin.Views
{
	public class RefreshViewWindows : ContentPage
	{
		public RefreshViewWindows()
		{
			Title = "Pull To Refresh (from Bottom to Top)";

			Construct();
		}

		void Construct()
		{
			BindingContext = new RefreshViewModel();

			var refreshView = new Xamarin.Forms.RefreshView
            {
				BackgroundColor = Color.Red,
				RefreshColor = Color.Yellow
			};

			refreshView.SetBinding(Xamarin.Forms.RefreshView.CommandProperty, "RefreshCommand");
			refreshView.SetBinding(Xamarin.Forms.RefreshView.IsRefreshingProperty, "IsRefreshing");

			refreshView.On<WindowsOS>().SetRefreshPullDirection(RefreshPullDirection.BottomToTop);

			var listView = new Xamarin.Forms.ListView
			{
				ItemTemplate = new DataTemplate(() =>
				{
					var stackLayout = new StackLayout
					{
						Orientation = StackOrientation.Horizontal
					};

					var boxView = new BoxView { WidthRequest = 40 };
					var infoLabel = new Xamarin.Forms.Label();

					boxView.SetBinding(BoxView.ColorProperty, "Color");
					infoLabel.SetBinding(Xamarin.Forms.Label.TextProperty, "Name");

					stackLayout.Children.Add(boxView);
					stackLayout.Children.Add(infoLabel);

					return new ViewCell { View = stackLayout };
				})
			};
			listView.SetBinding(Xamarin.Forms.ListView.ItemsSourceProperty, "Items");

			refreshView.Content = listView;

			Content = refreshView;
		}
	}
}
