using System;
using Xamarin.Forms;

namespace FocusOnXamarin.Views
{
	public static class GalleryBuilder
	{
		public static Button NavButton(string galleryName, Func<ContentPage> gallery, INavigation nav)
		{
			var button = new Button { Text = $"{galleryName}", FontSize = 10, HeightRequest = 40 };
			button.Clicked += (sender, args) => { nav.PushAsync(gallery()); };

            return button;
		}
	}
}