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
	public partial class GridCode : ContentPage
	{
		public GridCode ()
		{
            var layout = new StackLayout();
            var grid = new Grid();
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(200) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(200) });

            layout.Children.Add(grid);

            var btn = new Button();
            btn.Text = "AD";
            layout.Children.Add(btn);
            var c = new Button();
            c.Text = "MM";
            layout.Children.Add(c);


            Content = layout;
        }
	}
}