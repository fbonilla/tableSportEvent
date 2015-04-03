using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace BasicTable
{
	[Activity (Label = "BasicTable", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		// int count = 1;

		private List<SportEvent> mItems;
		private ListView mListView;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			mListView = FindViewById<ListView> (Resource.Id.listViewEvents);

			mItems = new List<SportEvent>();
			mItems.Add (new SportEventSeparator("Tomorrow/Wednesday. January 18"));
			mItems.Add (new EntrySportEvent ("Canadiens @ Flyers", "7:30 PM", this.Resources.GetDrawable(Resource.Drawable.icon_icehockey)));
			mItems.Add (new EntrySportEvent ("Toronto FC @ Impact", "7:30 PM", this.Resources.GetDrawable(Resource.Drawable.icon_soccer)));
			mItems.Add (new SportEventSeparator("Thursday. January 19"));
			mItems.Add (new EntrySportEvent ("Patriots @ Packers", "8:30 PM", this.Resources.GetDrawable(Resource.Drawable.icon_american_football)));
			mItems.Add (new EntrySportEvent ("Kovalev vs Jean-Pascal", "10:30 PM", this.Resources.GetDrawable(Resource.Drawable.icon_boxing)));

			MyEventListViewAdapter adapter = new MyEventListViewAdapter (this, mItems);

			//ArrayAdapter adapter = new ArrayAdapter<string> (this, Android.Resource.Layout.SimpleListItem1, mItems); -- Test Commit

			mListView.Adapter = adapter;
		}
	}
}


