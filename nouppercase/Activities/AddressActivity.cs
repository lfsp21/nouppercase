using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace nouppercase.Activities
{
    [Activity(Label = "Address_AutoComplete", MainLauncher = true)]
    public class AddressActivity : AppCompatActivity
    {
        private TextView city_tv;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.addressactivity_layout);

            HttpClient client = new HttpClient();

            FindViews();
        }

        void FindViews()
        {
            city_tv = FindViewById<TextView>(Resource.Id.tv_city);
        }
    }
}