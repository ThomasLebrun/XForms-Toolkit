using Android.Util;

namespace XForms.Toolkit.Droid.Controls.Calendar
{
	public class Logr
	{
		public static void D(string message)
		{
#if DEBUG
			Log.Debug("XForms.Toolkit.Droid.Controls.Calendar", message);
#endif
		}

		public static void D(string message, params object[] args)
		{
#if DEBUG
			D(string.Format(message, args));
#endif
		}
	}
}