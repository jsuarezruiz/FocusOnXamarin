using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace FocusOnXamarin.Views
{
	[Preserve(AllMembers = true)]
	internal class CarouselViewGallery : ContentPage
	{
		public CarouselViewGallery()
		{
			Title = "CarouselView Galleries";

			var button = new Button
			{
				Text = "Enable CarouselView"
			};
			button.Clicked += ButtonClicked;

			Content = new ScrollView
			{
				Content = new StackLayout
				{
					Children =
					{
						button,
						GalleryBuilder.NavButton("CarouselView (Code, Horizontal)", () =>
							new CarouselCodeGallery(ItemsLayoutOrientation.Horizontal), Navigation),
						GalleryBuilder.NavButton("CarouselView (Code, Vertical)", () =>
							new CarouselCodeGallery(ItemsLayoutOrientation.Vertical), Navigation),
	  					GalleryBuilder.NavButton("CarouselView Snap", () =>
 							new CarouselSnapGallery(), Navigation),
						GalleryBuilder.NavButton("ObservableCollection and CarouselView", () =>
 							new CollectionCarouselViewGallery(), Navigation),
						GalleryBuilder.NavButton("CarouselView EmptyView", () =>
  							new EmptyCarouselGallery(), Navigation)
					}
				}
			};
		}

		void ButtonClicked(object sender, System.EventArgs e)
		{
			var button = sender as Button;

			button.Text = "CarouselView Enabled!";
			button.TextColor = Color.LightGray;
			button.IsEnabled = false;

			Device.SetFlags(new[] { "CarouselView_Experimental", "IndicatorView_Experimental" });
		}
	}
}