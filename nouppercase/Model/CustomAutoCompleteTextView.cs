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
    public class CustomAutoCompleteTextView : AutoCompleteTextView
    {
    
        public CustomAutoCompleteTextView(Context context, Attribute attrs)
        {
            base.CustomAutoCompleteTextView(context, attrs);
        }

        protected CharSequence convertSelectionToString(Object selectedItem)
        {
            /** Each item in the autocompetetextview suggestion list is a hashmap object */
            HashMap<String, String> hm = (HashMap<String, String>)selectedItem;
            return hm.get("description");
        }
    }
}