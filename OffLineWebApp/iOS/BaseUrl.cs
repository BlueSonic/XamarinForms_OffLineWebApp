using OffLineApp.iOS;
using Foundation;
using Xamarin.Forms;

[assembly: Dependency(typeof(BaseUrl))]
namespace OffLineApp.iOS
{
	public class BaseUrl : IBaseUrl
	{
		public string Get()
		{
			return NSBundle.MainBundle.BundlePath + "/webdir";
		}
	}
}