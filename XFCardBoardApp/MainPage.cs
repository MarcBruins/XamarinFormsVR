using System;

using Xamarin.Forms;

namespace XFCardBoardApp
{
	public class MainPage : ContentPage
	{
		public MainPage()
		{
			var button = new Button
			{
				Text = "Click Me!",
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
			};

			int clicked = 0;
			button.Clicked += (s, e) => button.Text = "Clicked: " + clicked++;

			Content = button;
		}
	}
}


