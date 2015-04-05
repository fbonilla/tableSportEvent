using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using Android.Views.Animations;

namespace BasicTable
{
	[Activity (Label = "BasicTable", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		// int count = 1;

		private List<SportEvent> mItems;
		private ListView mListView;
		private MyEventListViewAdapter adapter;
		private LinearLayout layoutMonthEvent;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			layoutMonthEvent = FindViewById<LinearLayout> (Resource.Id.layoutMonthEvent);
			mListView = FindViewById<ListView> (Resource.Id.listViewEvents);

			mItems = new List<SportEvent>();
			mItems.Add (new SportEventSeparator("Tomorrow/Wednesday. January 18"));
			mItems.Add (new EntrySportEvent ("Predators @ Oilers", "7:30 PM", this.Resources.GetDrawable(Resource.Drawable.icon_icehockey)));
			mItems.Add (new EntrySportEvent ("Toronto FC @ Impact", "7:30 PM", this.Resources.GetDrawable(Resource.Drawable.icon_soccer)));
			mItems.Add (new SportEventSeparator("Thursday. January 19"));
			mItems.Add (new EntrySportEvent ("Patriots @ Packers", "7:30 PM", this.Resources.GetDrawable(Resource.Drawable.icon_american_football)));
			mItems.Add (new EntrySportEvent ("Kovalev vs Jean-Pascal", "9:30 PM", this.Resources.GetDrawable(Resource.Drawable.icon_boxing)));
			mItems.Add (new EntrySportEvent ("Canadiens @ Flyers ", "9:30 PM", this.Resources.GetDrawable(Resource.Drawable.icon_icehockey)));
			mItems.Add (new EntrySportEvent ("Bruins @ Predators", "10:30 PM", this.Resources.GetDrawable(Resource.Drawable.icon_icehockey)));
			mItems.Add (new SportEventSeparator("Friday. January 20"));
			mItems.Add (new EntrySportEvent ("FC Barcelona @ Real Madrid", "1:00 PM", this.Resources.GetDrawable(Resource.Drawable.icon_soccer)));
			mItems.Add (new EntrySportEvent ("Milan Raonic vs Roger Federer", "4:00 PM", this.Resources.GetDrawable(Resource.Drawable.icon_tennis)));
			mItems.Add (new EntrySportEvent ("Maple Leafs @ Bruins", "7:00 PM", this.Resources.GetDrawable (Resource.Drawable.icon_icehockey)));
			mItems.Add (new EntrySportEvent ("Cannucks @ Kings", "10:00 PM", this.Resources.GetDrawable (Resource.Drawable.icon_icehockey)));

			adapter = new MyEventListViewAdapter (this, mItems);

			mListView.Adapter = adapter;

			var slideToTheRight = AnimationUtils.LoadAnimation (this, Resource.Animation.right_swipe);
			var slideToTheLeft = AnimationUtils.LoadAnimation (this, Resource.Animation.left_swipe);
			var backSwipe = AnimationUtils.LoadAnimation (this, Resource.Animation.back_swipe);

			Button btnNextMonth = FindViewById<Button> (Resource.Id.buttonNextMonth);
			btnNextMonth.Click += delegate {

				//Normally, a server request would replace all this to refresh the data for ths list of events to show. 

				layoutMonthEvent.StartAnimation(slideToTheRight);

				TextView txtMonth = FindViewById<TextView> (Resource.Id.textMonth);
				txtMonth.Text = "February 2015";

				mItems.Clear();
				//mItems = new List<SportEvent>();
				mItems.Add (new SportEventSeparator("Tomorrow/Wednesday. February 18"));
				mItems.Add (new EntrySportEvent ("Jets @ Flames", "7:30 PM", this.Resources.GetDrawable(Resource.Drawable.icon_icehockey)));
				mItems.Add (new EntrySportEvent ("New York FC @ Toronto FC", "7:30 PM", this.Resources.GetDrawable(Resource.Drawable.icon_soccer)));
				mItems.Add (new SportEventSeparator("Thursday. February 19"));
				mItems.Add (new EntrySportEvent ("Steelers @ NY Giants", "7:30 PM", this.Resources.GetDrawable(Resource.Drawable.icon_american_football)));
				mItems.Add (new EntrySportEvent ("Lucian Bute vs Adonis Stevenson", "9:30 PM", this.Resources.GetDrawable(Resource.Drawable.icon_boxing)));
				mItems.Add (new EntrySportEvent ("Canadiens @ Bruins ", "9:30 PM", this.Resources.GetDrawable(Resource.Drawable.icon_icehockey)));
				mItems.Add (new EntrySportEvent ("Senators @ Maple Leafs", "10:30 PM", this.Resources.GetDrawable(Resource.Drawable.icon_icehockey)));
				mItems.Add (new SportEventSeparator("Friday. February 20"));
				mItems.Add (new EntrySportEvent ("Juventus @ Atletico Madrid", "1:00 PM", this.Resources.GetDrawable(Resource.Drawable.icon_soccer)));
				mItems.Add (new EntrySportEvent ("Genie Bouchard vs Serema Williams", "4:00 PM", this.Resources.GetDrawable(Resource.Drawable.icon_tennis)));
				mItems.Add (new EntrySportEvent ("Blackhawls @ Panthers", "7:00 PM", this.Resources.GetDrawable (Resource.Drawable.icon_icehockey)));
				mItems.Add (new EntrySportEvent ("Sharks @ Avalanche", "10:00 PM", this.Resources.GetDrawable (Resource.Drawable.icon_icehockey)));


				adapter.NotifyDataSetChanged();
				//layoutMonthEvent.StartAnimation(backSwipe);
				 
			};

			Button btnPreviousMonth = FindViewById<Button> (Resource.Id.buttonPreviousMonth);
			btnPreviousMonth.Click += delegate {

				//Normally, a server request would replace all this to refresh the data for ths list of events to show. 
				layoutMonthEvent.StartAnimation(slideToTheLeft);

				TextView txtMonth = FindViewById<TextView> (Resource.Id.textMonth);
				txtMonth.Text = "January 2015";

				mItems.Clear();
				mItems.Add (new SportEventSeparator("Tomorrow/Wednesday. January 18"));
				mItems.Add (new EntrySportEvent ("Predators @ Oilers", "7:30 PM", this.Resources.GetDrawable(Resource.Drawable.icon_icehockey)));
				mItems.Add (new EntrySportEvent ("Toronto FC @ Impact", "7:30 PM", this.Resources.GetDrawable(Resource.Drawable.icon_soccer)));
				mItems.Add (new SportEventSeparator("Thursday. January 19"));
				mItems.Add (new EntrySportEvent ("Patriots @ Packers", "7:30 PM", this.Resources.GetDrawable(Resource.Drawable.icon_american_football)));
				mItems.Add (new EntrySportEvent ("Kovalev vs Jean-Pascal", "9:30 PM", this.Resources.GetDrawable(Resource.Drawable.icon_boxing)));
				mItems.Add (new EntrySportEvent ("Canadiens @ Flyers ", "9:30 PM", this.Resources.GetDrawable(Resource.Drawable.icon_icehockey)));
				mItems.Add (new EntrySportEvent ("Bruins @ Predators", "10:30 PM", this.Resources.GetDrawable(Resource.Drawable.icon_icehockey)));
				mItems.Add (new SportEventSeparator("Friday. January 20"));
				mItems.Add (new EntrySportEvent ("FC Barcelona @ Real Madrid", "1:00 PM", this.Resources.GetDrawable(Resource.Drawable.icon_soccer)));
				mItems.Add (new EntrySportEvent ("Milan Raonic vs Roger Federer", "4:00 PM", this.Resources.GetDrawable(Resource.Drawable.icon_tennis)));
				mItems.Add (new EntrySportEvent ("Maple Leafs @ Bruins", "7:00 PM", this.Resources.GetDrawable (Resource.Drawable.icon_icehockey)));
				mItems.Add (new EntrySportEvent ("Cannucks @ Kings", "10:00 PM", this.Resources.GetDrawable (Resource.Drawable.icon_icehockey)));

				adapter.NotifyDataSetChanged();

			};
		}
	}
}


