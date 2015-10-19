using Foundation;
using UIKit;
using System.Collections.Generic;
using Florismart.Gozer.iOS.Core;

namespace Florismart.Gozer.iOS.Sample
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
	[Register ("AppDelegate")]
	public class AppDelegate : UIApplicationDelegate
	{
		public static UIStoryboard Storyboard = UIStoryboard.FromName ("MainStoryboard", null);
		public static UIViewController initialViewController;

		public override UIWindow Window {
			get;
			set;
		}

		public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
		{
			InitDictionary ();
			Window = new UIWindow (UIScreen.MainScreen.Bounds);

			initialViewController = Storyboard.InstantiateInitialViewController () as UIViewController;

			Window.RootViewController = initialViewController;
			Window.MakeKeyAndVisible ();
			return true;
		}

		private void InitDictionary ()
		{
			//crete dictionary (download your dictionary or load from assets..)
			var keys = new Dictionary<string, string> ();
			keys.Add ("egon", "Dr. Egon Spengler");
			keys.Add ("ray", "Dr Ray Stantz");
			keys.Add ("gozer", "Gozer");
			keys.Add ("questionOne", "Are you a God?");
			keys.Add ("answerOne", "No");
			keys.Add ("answerTwo", "Then... DIE! ");

			VinzClortho.Instance.Keys = keys;
		}
			
	}
}


