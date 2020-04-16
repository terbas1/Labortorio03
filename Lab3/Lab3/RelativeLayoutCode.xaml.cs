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
	public partial class RelativeLayoutCode : ContentPage
	{
		public RelativeLayoutCode ()
		{
            var stack = new StackLayout();
            var layout = new RelativeLayout();
            var box = new BoxView { Color = Color.Green };

            layout.Children.Add(box, Constraint.RelativeToParent((parent) =>
            {
                return (.5 * parent.Width) - 100;
            }),
            Constraint.RelativeToParent((parent) =>
            {
                return (.5 * parent.Height) - 100;
            }),
            Constraint.Constant(50), Constraint.Constant(50));

            stack.Children.Add(layout);

            Content = stack;
        }
	}
}