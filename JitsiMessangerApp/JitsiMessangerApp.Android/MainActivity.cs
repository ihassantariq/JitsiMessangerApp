using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace JitsiMessangerApp.Droid
{
    [Activity(Label = "JitsiMessangerApp", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        JitsiMeetView view;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);


            view = new JitsiMeetView(Application.Context);
            JitsiMeetConferenceOptions options = new JitsiMeetConferenceOptions.Builder()
                .SetRoom("https://meet.jit.si/AngryLemonsAnswerFerociously")
                .Build();
            view.Join(options);
            SetContentView(view);


            LoadApplication(new App());

        }

        public override void OnBackPressed()
        {
            JitsiMeetActivityDelegate.OnBackPressed();
        }
        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            JitsiMeetActivityDelegate.OnActivityResult(this, requestCode, (int)resultCode, data);
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            view.Dispose();
            view = null;

            JitsiMeetActivityDelegate.OnHostDestroy(this);
        }

        protected override void OnNewIntent(Intent intent)
        {
            JitsiMeetActivityDelegate.OnNewIntent(intent);
        }

        protected override void OnResume()
        {
            base.OnResume();
            JitsiMeetActivityDelegate.OnHostResume(this);
        }

        protected override void OnStop()
        {
            base.OnStop();
            JitsiMeetActivityDelegate.OnHostPause(this);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            JitsiMeetActivityDelegate.OnRequestPermissionsResult(requestCode, permissions, null);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}