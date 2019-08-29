using Foundation;
using System;
using UIKit;
using JitsiMeetSDK;

namespace SampleApp
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        { }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            JitsiMeetView jitsiMeetView = (JitsiMeetView)View;
            // jitsiMeetView.Delegate = View;
            JitsiMeetConferenceOptions defaultOptions = JitsiMeetConferenceOptions.FromBuilder((obj) =>
            {
                obj.ServerURL = new NSUrl("https://meet.jit.si");
                obj.WelcomePageEnabled = false;
                obj.Room = @"test123";
            });

            jitsiMeetView.Join(defaultOptions);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}