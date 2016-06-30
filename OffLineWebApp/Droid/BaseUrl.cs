using OffLineApp.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(BaseUrl))]
namespace OffLineApp.Droid
{
	public class BaseUrl : IBaseUrl
	{
		public string Get()
		{
			return "file:///android_asset/webdir/";
		}
	}
}