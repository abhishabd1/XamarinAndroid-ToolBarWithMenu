using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Views;
using Android.Support.V4.View;

namespace ToolBarDemo
{
    [Activity(Label = "ToolBarDemo", MainLauncher = true, Icon = "@drawable/icon", Theme ="@style/Theme.AppCompat.Light.NoActionBar")]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);



            SetContentView(Resource.Layout.Main);


            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbr);
            toolbar.SetTitleTextColor(Android.Graphics.Color.White);
            SetSupportActionBar(toolbar);



        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            var inflator = MenuInflater;
            inflator.Inflate(Resource.Menu.ToolBarMenu, menu);
            return true;
        }


        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if(id==Resource.Id.search)
            {
                Toast.MakeText(this, " Do Search", ToastLength.Short).Show();
                return true;
            }
           else  if (id == Resource.Id.share)
            {
                Toast.MakeText(this, " Share what ever you want", ToastLength.Short).Show();
                return true;
            }
           else if (id == Resource.Id.email)
            {
                Toast.MakeText(this, " Send Mail", ToastLength.Short).Show();
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }
    }
}

