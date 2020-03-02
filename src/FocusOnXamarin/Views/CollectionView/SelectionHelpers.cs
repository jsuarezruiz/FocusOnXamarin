using System.Collections.Generic;
using System.Linq;

namespace FocusOnXamarin.Views
{
	internal static class SelectionHelpers
	{
		public static string ToCommaSeparatedList(this IEnumerable<object> items)
		{
			if (items == null)
			{
				return string.Empty;
			}

			return string.Join(", ", items.Cast<CollectionViewGalleryTestItem>().Select(i => i.Caption));
		}
	}
}