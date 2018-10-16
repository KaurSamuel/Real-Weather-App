using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace Real_Weather_App
{
    [Activity(Label = "ForecastActivity")]
    public class ForecastActivity : AppCompatActivity
    {
        List<string> countries = new List<string>() { "esimene", "teine", "kolmas" };
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Forecast);
            ListView list = FindViewById<ListView>(Resource.Id.listView1);
            list.Adapter = new CustomAdapter(this, countries);

             /*ListView.ItemClick += delegate (object sender, AdapterView.ItemClickEventArgs args)
             {
                 Toast.MakeText(Application, ((TextView)args.View).Text, ToastLength.Short).Show();
             };

             ListView.TextFilterEnabled = true;*/
        }
    }
}