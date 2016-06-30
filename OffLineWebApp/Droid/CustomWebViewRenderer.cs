using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using OffLineApp;
using OffLineApp.Droid;

[assembly: ExportRenderer(typeof(WebView), typeof(WebViewRenderer))]
namespace OffLineApp.Droid
{
	public class CustomWebViewRenderer : WebViewRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<WebView> e)
		{
			base.OnElementChanged(e);
			if (Control == null) return;

			Control.Settings.DomStorageEnabled = true;
			Control.Settings.JavaScriptEnabled = true;

			//javascriptのfileスキームへのアクセス許可
			Control.Settings.AllowFileAccessFromFileURLs = true;
			Control.Settings.AllowUniversalAccessFromFileURLs = true;
		}

	}
}
