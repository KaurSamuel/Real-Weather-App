using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Real_Weather_App
{
    [Activity(Label = "Forecast")]
    class forecast_controller : ListActivity
    {


        List<string> countries = new List<string>() { "esimene", "teine" };
        List<string> countries1 = new List<string>() { "esimene", "teine" };
        List<string> countries2 = new List<string>() { "esimene", "teine" };
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            //SetContentView(Resource.Layout.Forecast);
            //ListView list = FindViewById<ListView>(Resource.Id.List);
            ListAdapter = new ArrayAdapter<string>(this, Resource.Layout.list_item, countries);

            ListView.ItemClick += delegate (object sender, AdapterView.ItemClickEventArgs args)
            {
                Toast.MakeText(Application, ((TextView)args.View).Text, ToastLength.Short).Show();
            };

            ListView.TextFilterEnabled = true;
        }
    }
}