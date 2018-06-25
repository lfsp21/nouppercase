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

namespace nouppercase.Model
{
    class UserAddress
    {
        public List<String> CP { get; set; }
        public List<String> Colonia { get; set; }
        public String Municipio { get; set; }
        public String Estado { get; set; }  

    }
}