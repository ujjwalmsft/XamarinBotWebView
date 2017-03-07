using System;
using Xamarin.Forms;

namespace WorkingWithWebview
{
	public class WebPage : ContentPage
	{
		public WebPage ()
		{
			var browser = new WebView();

			browser.Source = "https://webchat.botframework.com/embed/<INCLUDE YOUR BOT WEBCHAT URL>";

			Content = browser;
		}
	}
}

