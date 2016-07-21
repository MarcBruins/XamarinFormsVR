using System;
using Foundation;
using Google.VR;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(XamarinFormsVR.VRPage), typeof(XamarinFormsVR.iOS.VRPage))]
namespace XamarinFormsVR.iOS
{
	public class VRPage : PageRenderer
	{
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			this.View = new GVRVideoView();  			var view = this.View as GVRVideoView;  		//	view.Delegate = this; 			view.EnableFullscreenButton = false; 			view.EnableCardboardButton = true;  			view.LoadFromUrl(NSUrl.FromFilename("congo.mp4")); 

		}

		public override void ViewDidAppear(bool animated)
		{
			base.ViewDidAppear(animated);
		}
	}
}