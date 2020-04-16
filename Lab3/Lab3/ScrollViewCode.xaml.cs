using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab3
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ScrollViewCode : ContentPage
	{
		public ScrollViewCode ()
		{
            var scroll = new ScrollView();
            Content = scroll;
            var stack = new StackLayout();
            stack.Children.Add(new BoxView
            { BackgroundColor = Color.Red, HeightRequest = 600, WidthRequest = 600 });
            stack.Children.Add(new Entry());
            scroll.Content = stack;
            Content = scroll;
        }
	}
}