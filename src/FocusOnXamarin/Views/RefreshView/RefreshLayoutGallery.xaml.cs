using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace FocusOnXamarin.Views
{
	[Preserve(AllMembers = true)]
	public partial class RefreshLayoutGallery : ContentPage
	{
		public RefreshLayoutGallery()
		{
			InitializeComponent();
			BindingContext = new RefreshViewModel();
		}
	}
}