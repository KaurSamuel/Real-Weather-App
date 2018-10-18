using Android.App;
using Android.OS;
using Android;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Widget;
using WeatherApp.Core;
using System;
using Android.Content;
using System.Collections.Generic;

namespace Real_Weather_App
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        public string CityID;
        public bool forecast;
        public string id;
        string City;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            // var button = FindViewById<Button>(Resource.Id.button1);
            var search_button = FindViewById<ImageView>(Resource.Id.seacrh);
            search_button.Click += Button_Click;
            var edittext = FindViewById<EditText>(Resource.Id.textInputEditText1);
            City = edittext.Text;
            var forecast_btn = FindViewById<Button>(Resource.Id.Forecast_btn);
            forecast_btn.Click += Button_click_forecast;
            //button.Click += Button_Click;
        }
        
        private void Button_click_forecast(object sender, System.EventArgs e)
        {
            var ForecastActivity = new Intent(this, typeof(ForecastActivity));
            ForecastActivity.PutExtra("WeatherData", id);
            StartActivity(ForecastActivity);
        }


        private async void Button_Click(object sender, System.EventArgs e)
        {
            forecast = false;
            var edittext = FindViewById<EditText>(Resource.Id.textInputEditText1);
            City = edittext.Text;
            var weather = await Core.GetWeather("normal",City,CityID,forecast);
            var temperature_box = FindViewById<TextView>(Resource.Id.Temperature);
            var Humidity_box = FindViewById<TextView>(Resource.Id.Humidity);
            var WindSpeed_box = FindViewById<TextView>(Resource.Id.Wind_speed);
            var descriptionbox = FindViewById<TextView>(Resource.Id.description);
            var mainimage = FindViewById<ImageView>(Resource.Id.mainimage);
            id = weather.ID;

            temperature_box.Text = weather.Temperature;
            Humidity_box.Text = weather.Humidity;
            WindSpeed_box.Text = weather.wind_speed;
            descriptionbox.Text = weather.description;
            switch(weather.description)
            {
                case ("Clouds"):
                    mainimage.SetImageResource(Resource.Drawable.fewclouds);
                    break;
                case ("Clear"):
                    mainimage.SetImageResource(Resource.Drawable.sunny);
                    break;
                case ("Rain"):
                    mainimage.SetImageResource(Resource.Drawable.Rain);
                    break;
                case ("Thunderstorm"):
                    mainimage.SetImageResource(Resource.Drawable.storm);
                    break;
                case ("Drizzle"):
                    mainimage.SetImageResource(Resource.Drawable.drizzle);
                    break;
                case ("Snow"):
                    mainimage.SetImageResource(Resource.Drawable.snow);
                    break;
                case ("Mist"):
                    mainimage.SetImageResource(Resource.Drawable.mist);
                    break;
                case ("Fog"):
                    mainimage.SetImageResource(Resource.Drawable.mist);
                    break;

            }
        }
    }
}