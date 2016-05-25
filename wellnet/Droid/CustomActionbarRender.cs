using Android.App;  
using Android.Graphics.Drawables;  
using Xamarin.Forms;  
using Xamarin.Forms.Platform.Android;  
using wellnet;  
using wellnet.Droid;  

[assembly: ExportRenderer(typeof(NavigationPage), typeof(CustomActionbarRender))]  
namespace wellnet.Droid {  
	public class CustomActionbarRender: NavigationRenderer {  
		protected override void OnElementChanged(ElementChangedEventArgs < NavigationPage > e) {  
			base.OnElementChanged(e);  

			RemoveAppIconFromActionBar();  
		}  
		void RemoveAppIconFromActionBar() {  
			var actionBar = ((Activity) Context).ActionBar;  
			actionBar.SetIcon(new ColorDrawable(Color.Transparent.ToAndroid()));
            
        }  
	}  
}  