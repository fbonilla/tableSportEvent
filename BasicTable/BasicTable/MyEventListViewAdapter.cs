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
	public class MyEventListViewAdapter : BaseAdapter<SportEvent>
	{

		private List<SportEvent> mItems;
		private Context mContext;
		private EntrySportEvent entrySportEvent;
		private SportEventSeparator separator;
		//private LayoutInflater vi;

		public MyEventListViewAdapter (Context context, List<SportEvent> Items)
		{
			mContext = context;
			mItems = Items;
			//vi = (LayoutInflater)context.GetSystemService (Context.LayoutInflaterService);
		}

		public override int Count
		{
			get {return mItems.Count; }
		}

		public override long GetItemId(int position)
		{
			return position;
		}

		public override SportEvent this[int position]
		{
			get {return mItems[position]; }
		}

		public override View GetView (int position, View convertView, ViewGroup parent)
		{
			View row = convertView;

			//if (row == null) {
			//	row = LayoutInflater.FromContext (mContext).Inflate (Resource.Layout.ListEvents_row, null, false);
			//}


			SportEvent se = mItems[position];
		
			//Checks if it's a seperator
			if (se.isSection()) {

				separator = (SportEventSeparator)se;

				row = LayoutInflater.FromContext (mContext).Inflate (Resource.Layout.ListEventsSeparator, null, false);

				TextView sectionView = row.FindViewById<TextView> (Resource.Id.listItemSection);
				sectionView.Text = separator.mDate;
			} else {

				row = LayoutInflater.FromContext (mContext).Inflate (Resource.Layout.ListEvents_row, null, false);

				TextView textEventTitle = row.FindViewById<TextView> (Resource.Id.textEventTitle);
				TextView textEventTime = row.FindViewById<TextView> (Resource.Id.textEventTime);
				ImageView imageViewIcon = row.FindViewById<ImageView> (Resource.Id.iconSport);


				entrySportEvent = (EntrySportEvent)mItems [position]; 

				textEventTitle.Text = entrySportEvent.mEventTitle;
				textEventTime.Text = entrySportEvent.mEventTime;
				imageViewIcon.SetImageDrawable (entrySportEvent.mEventIcon);
			}

			return row;
		}
	}
}

