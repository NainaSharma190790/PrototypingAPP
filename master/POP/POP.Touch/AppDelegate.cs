using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace POP.Touch
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to
	// application events from iOS.


	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations
		UIWindow window;
		ProjectCollectionViewController projectCollectionView;
		UINavigationController navigationController;

		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			// create a new window instance based on the screen size
			window = new UIWindow (UIScreen.MainScreen.Bounds);
			if (navigationController == null)
				navigationController = new UINavigationController ();
			if (projectCollectionView == null)
				projectCollectionView = new ProjectCollectionViewController (new ProjectCollectionLayout());
			// If you have defined a root view controller, set it here:
			// window.RootViewController = myViewController;
			navigationController.PushViewController (projectCollectionView, true);

			window.RootViewController = navigationController;
			// make the window visible
			window.MakeKeyAndVisible ();
			
			return true;
		}
	}
}

