using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace FocusOnXamarin.Views
{
	internal class ItemAdder : ObservableCollectionModifier
	{
		public ItemAdder(CollectionView cv) : base(cv, "Adder")
		{
		}

		protected override void ModifyObservableCollection(ObservableCollection<CollectionViewGalleryTestItem> observableCollection, params int[] indexes)
		{
			var item = new CollectionViewGalleryTestItem(DateTime.Now, "Added", "fruit01.jpg", observableCollection.Count);
			observableCollection.Add(item);
		}
	}
}