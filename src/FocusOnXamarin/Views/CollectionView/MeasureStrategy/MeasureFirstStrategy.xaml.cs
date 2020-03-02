using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FocusOnXamarin.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MeasureFirstStrategy : ContentPage
	{
		public MeasureFirstStrategy()
		{
			InitializeComponent();

			CollectionView.ItemsSource = new SuperTeams();
		}
	}
}