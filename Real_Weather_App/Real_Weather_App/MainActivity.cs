﻿using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using WeatherApp.Core;

namespace Real_Weather_App
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        ImageView Main_image;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            // var button = FindViewById<Button>(Resource.Id.button1);
            var search_button = FindViewById<ImageView>(Resource.Id.seacrh);
            search_button.Click += Button_Click;
            //button.Click += Button_Click;
        }

        private async void Button_Click(object sender, System.EventArgs e)
        {
            var weather = await Core.GetWeather("asd");
            
        }
    }
}