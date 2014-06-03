using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XForms.Toolkit.Controls;

namespace XForms.Toolkit.Sample
{	
	public partial class CalendarPage : ContentPage
	{	
		CalendarView _calendarView;
		StackLayout _stacker;

		public CalendarPage ()
		{
			InitializeComponent ();
			 _stacker = new StackLayout ();
			Content = _stacker;

			_calendarView = new CalendarView() {
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.CenterAndExpand
			};
			_stacker.Children.Add (_calendarView);
			_calendarView.DateSelected += (object sender, DateTime e) => {
				_stacker.Children.Add(new Label() 
					{ 
						Text = "Date Was Selected" + e.ToString("d"),
						VerticalOptions = LayoutOptions.Start,
						HorizontalOptions = LayoutOptions.CenterAndExpand,
					});
			};

		
		}
	}
}

