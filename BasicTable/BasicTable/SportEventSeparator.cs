using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace BasicTable
{
	//The class SportEventSeparator is used to seperates events by a given date
	public class SportEventSeparator : SportEvent
	{
		public String mDate { get; set;}

		public SportEventSeparator (String date)
		{
			mDate = date;
		}

		public Boolean isSection()
		{
			return true;
		}
	}
}

