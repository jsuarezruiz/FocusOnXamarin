using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FocusOnXamarin.Views
{
	public class ViewModelBase2 : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual ViewModelBase2 SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
		{
			field = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            return this;
		}
	}
}