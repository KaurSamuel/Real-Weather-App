using Android.App;
using Android.OS;
using Android;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Widget;
using WeatherApp.Core;
using System;

namespace Real_Weather_App
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        string City;
        ImageView Main_image;
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
            //button.Click += Button_Click;
        }

        private async void Button_Click(object sender, System.EventArgs e)
        {
            var weather = await Core.GetWeather("asd",City);
            var temperature_box = FindViewById<TextView>(Resource.Id.Temperature);
            var Humidity_box = FindViewById<TextView>(Resource.Id.Humidity);
            var WindSpeed_box = FindViewById<TextView>(Resource.Id.Wind_speed);

            temperature_box.Text = weather.Temperature;
            Humidity_box.Text = weather.Humidity;
            WindSpeed_box.Text = weather.wind_speed;
        }
    }
}