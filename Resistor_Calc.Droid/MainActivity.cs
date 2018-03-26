using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Resistor_Calc.Droid
{
	[Activity (Label = "Resistor_Calc", Icon = "@drawable/Icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

            var x = typeof(Xamarin.Forms.Themes.DarkThemeResources);
            //x = typeof(Xamarin.Forms.Themes.LightThemeResources);
            x = typeof(Xamarin.Forms.Themes.Android.UnderlineEffect);

            global::Xamarin.Forms.Forms.Init (this, bundle);
			LoadApplication (new Resistor_Calc.App ());
		}
	}
}

