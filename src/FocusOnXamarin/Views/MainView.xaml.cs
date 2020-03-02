using System;
using Xamarin.Forms;

namespace FocusOnXamarin.Views
{
    public partial class MainView : ContentPage
    {
        public MainView()
        {
            InitializeComponent();
        }

        void OnCollectionViewGalleryBtnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CollectionViewGallery());
        }

        void OnCarouselViewGalleryBtnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CarouselViewGallery());
        }

        void OnIndicatorViewGalleryBtnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new IndicatorViewGallery());
        }

        void OnRefreshViewGalleryBtnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RefreshViewGallery());
        }

        void OnSwipeViewGalleryBtnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SwipeViewGallery());
        }
    }
}