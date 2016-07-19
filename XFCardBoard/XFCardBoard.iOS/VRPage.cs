using System;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Google.VR;
using Foundation;

[assembly: ExportRenderer(typeof(XFCardBoard.VRPage), typeof(XFCardBoard.iOS.VRPage))]
namespace XFCardBoard.iOS
{
	public class VRPage : PageRenderer, IGVRVideoViewDelegate
	{
		
		public VRPage()
		{
			
		}

		protected override void OnElementChanged(VisualElementChangedEventArgs e)
		{
			base.OnElementChanged(e);

			if (e.OldElement != null || Element == null)
			{
				return;
			}

			try
			{
				//SetupUserInterface();
				//SetupEventHandlers();
				//SetupLiveCameraStream();
				//AuthorizeCameraUse();

			}
			catch (Exception ex)
			{
				System.Diagnostics.Debug.WriteLine($"ERROR: {ex.Message}");
			}
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			this.View = new GVRVideoView(); ;

			var view = this.View as GVRVideoView;

			view.Delegate = this;
			view.EnableFullscreenButton = false;
			view.EnableCardboardButton = true;

			view.LoadFromUrl(NSUrl.FromFilename("congo.mp4"));
		}

		public void DidUpdatePosition(GVRVideoView videoView, double position)
		{
			if (position == videoView.Duration)
			{
				videoView.SeekTo(0);
				videoView.Resume();
			}
		}
	}
}


