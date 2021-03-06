using Android.Views;
using Android.Widget;

namespace ActionBarCompat.DrawerLayout.Helpers
{
    public class Fragment1 : Android.Support.V4.App.Fragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Android.OS.Bundle savedInstanceState)
        {
            HasOptionsMenu = true;
            var ignored = base.OnCreateView(inflater, container, savedInstanceState);
            var view = inflater.Inflate(Resource.Layout.NavDrawerFrag, null);

            view.FindViewById<Button>(Resource.Id.button).Click += (sender, args) =>
            {
                var popUp = new Android.Support.V7.Widget.PopupMenu(Activity, (Button) sender);
                popUp.Inflate(Resource.Menu.main_menu);
                popUp.Show();
            };

            view.FindViewById<TextView>(Resource.Id.main_text).Text = "This is BROWSE FRAGMENT";
            return view;
        }

        public override void OnCreateOptionsMenu(IMenu menu, MenuInflater inflater)
        {
            inflater.Inflate(Resource.Menu.main_menu, menu);
        }
    }

    public class Fragment3 : Android.Support.V4.App.Fragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Android.OS.Bundle savedInstanceState)
        {
            HasOptionsMenu = true;
            var ignored = base.OnCreateView(inflater, container, savedInstanceState);
            var view = inflater.Inflate(Resource.Layout.NavDrawerFrag, null);

            view.FindViewById<Button>(Resource.Id.button).Click += (sender, args) =>
            {
                var popUp = new Android.Support.V7.Widget.PopupMenu(Activity, (Button)sender);
                popUp.Inflate(Resource.Menu.main_menu);
                popUp.Show();
            };

            view.FindViewById<TextView>(Resource.Id.main_text).Text = "This is PROFILE FRAGMENT";
            return view;
        }

        public override void OnCreateOptionsMenu(IMenu menu, MenuInflater inflater)
        {
            inflater.Inflate(Resource.Menu.main_menu, menu);
        }
    }

    public class Fragment2 : Android.Support.V4.App.Fragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Android.OS.Bundle savedInstanceState)
        {
            HasOptionsMenu = true;
            var ignored = base.OnCreateView(inflater, container, savedInstanceState);
            var view = inflater.Inflate(Resource.Layout.NavDrawerFrag, null);

            view.FindViewById<Button>(Resource.Id.button).Click += (sender, args) =>
            {
                var popUp = new Android.Support.V7.Widget.PopupMenu(Activity, (Button)sender);
                popUp.Inflate(Resource.Menu.main_menu);
                popUp.Show();
            };

            view.FindViewById<TextView>(Resource.Id.main_text).Text = "This is FRIENDS FRAGMENT";
            return view;
        }

        public override void OnCreateOptionsMenu(IMenu menu, MenuInflater inflater)
        {
            inflater.Inflate(Resource.Menu.main_menu, menu);
        }
    }
}