using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace ProjectDemo
{
    [Activity(Label = "ProjectDemo", MainLauncher = false)]
    public class MainActivity : Activity
    {
        Button gBtnNewsFeed;
        Button gBtnCalendar;
        Button gBtnClubs;
        Button gBtnContact;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            gBtnNewsFeed = FindViewById<Button>(Resource.Id.btnNewsFeed);
            gBtnCalendar = FindViewById<Button>(Resource.Id.btnCalendar);
            gBtnClubs = FindViewById<Button>(Resource.Id.btnClubs);
            gBtnContact = FindViewById<Button>(Resource.Id.btnContact);

            gBtnNewsFeed.Click += GBtnNewsFeed_Click;
            gBtnCalendar.Click += GBtnCalendar_Click;
            gBtnClubs.Click += GBtnClubs_Click;
            gBtnContact.Click += GBtnContact_Click;
        }

        private void GBtnContact_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(ContactActivity));
            this.StartActivity(intent);
        }

        private void GBtnClubs_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(ClubActivity));
            this.StartActivity(intent);
        }

        private void GBtnCalendar_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(CalendarActivity));
            this.StartActivity(intent);
        }

        private void GBtnNewsFeed_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(NewsActivity));
            this.StartActivity(intent);
        }
    }
}

