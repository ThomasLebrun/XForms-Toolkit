using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace XForms.Toolkit.Sample
{	
	public partial class MainPage : TabbedPage
	{	
		public MainPage ()
		{
			InitializeComponent ();

			var controls = new CarouselPage ();
			controls.Title = "Controls";
			controls.Children.Add (new CalendarPage ());

			var services = new CarouselPage ();
			services.Title = "Services";
			services.Children.Add (new TextToSpeechPage ());

			this.Children.Add (controls);
			this.Children.Add (services);
		}
	}
}

