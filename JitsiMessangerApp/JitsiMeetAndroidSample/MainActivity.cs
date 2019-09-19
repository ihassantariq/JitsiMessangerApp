using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Java.Lang;
using Java.Net;
using Org.Jitsi.Meet.Sdk;

namespace JitsiMeetAndroidSample
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        EditText editText;
        Button button4;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            editText = FindViewById<EditText>(Resource.Id.conferenceName);
            button4 = FindViewById<Button>(Resource.Id.button4);
            button4.Click += delegate
             {
                 OnButoonClick();
             };
            // Initialize default options for Jitsi Meet conferences.
            URL serverURL;
            try
            {
                serverURL = new URL("https://meet.jit.si");
            }
            catch (MalformedURLException e)
            {
                e.PrintStackTrace();
                throw new RuntimeException("Invalid server URL!");
            }
            JitsiMeetConferenceOptions defaultOptions
                = new JitsiMeetConferenceOptions.Builder()
                    .SetServerURL(serverURL)
                    .SetWelcomePageEnabled(false)
                    .Build();
            JitsiMeet.DefaultConferenceOptions = defaultOptions;
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        public void OnButoonClick()
        {
            string text = editText.Text.ToString();

            if (text.Length > 0)
            {
                // Build options object for joining the conference. The SDK will merge the default
                // one we set earlier and this one when joining.
                JitsiMeetConferenceOptions options
                    = new JitsiMeetConferenceOptions.Builder()
                        .SetRoom(text)
                        .Build();
                // Launch the new activity with the given options. The launch() method takes care
                // of creating the required Intent and passing the options.
                JitsiMeetActivity.Launch(this, options);
            }
        }
    }
}

