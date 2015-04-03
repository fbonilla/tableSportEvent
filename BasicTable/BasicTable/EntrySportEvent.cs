using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Graphics.Drawables;

namespace BasicTable
{
	public class EntrySportEvent : SportEvent
	{
		//Attributs of a SportEvent represented by a title, a time and a sport icon
		public String mEventTitle{ get; set;}
		public String mEventTime{ get; set;}
		public Drawable mEventIcon{ get; set;}

		//Conctrustor of the SportEvent Modal represented inside the ListView located in the event section
		public EntrySportEvent (String eventTitle, String eventTime, Drawable eventIcon)
		{
			mEventTitle = eventTitle;
			mEventTime = eventTime;
			mEventIcon = eventIcon;
		}

		//Implemenation by interface SportEventInterface
		public Boolean isSection()
		{
			return false;
		}
	}
}

