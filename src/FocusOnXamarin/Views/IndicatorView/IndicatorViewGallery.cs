using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace FocusOnXamarin.Views
{
	[Preserve(AllMembers = true)]
	public class IndicatorViewGallery : ContentPage
	{
		public IndicatorViewGallery()
		{
			Title = "IndicatorView Gallery";

			var button = new Button
			{
				Text = "Enable IndicatorView",
				AutomationId = "EnableIndicatorView"
			};
			button.Clicked += ButtonClicked;

			Content = new StackLayout
			{
				Children =
				{
					button,
					GalleryBuilder.NavButton("IndicatorView Gallery", () =>
                        new IndicatorCodeGallery(), Navigation),
                    /*
                    GalleryBuilder.NavButton("CarouselView (XAML, Horizontal)", () =>
                        new CarouselXamlGallery(), Navigation),
                    GalleryBuilder.NavButton("CarouselView (Indicators Forms)", () =>
						new CarouselItemsGallery(), Navigation),
                    GalleryBuilder.NavButton("CarouselView (Indicators Default (Native))", () =>
						new CarouselItemsGallery(), Navigation),
                    */
				}
			};
		}

		void ButtonClicked(object sender, System.EventArgs e)
		{
			var button = sender as Button;

			button.Text = "IndicatorView Enabled!";
			button.TextColor = Color.LightGray;
			button.IsEnabled = false;

			Device.SetFlags(new[] { "CarouselView_Experimental", "IndicatorView_Experimental" });
		}
	}
}