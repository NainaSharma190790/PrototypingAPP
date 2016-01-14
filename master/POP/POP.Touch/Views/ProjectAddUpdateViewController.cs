using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using oPOP.Core;
using oPOP.Data;
using System.IO;

namespace POP.Touch
{
	public partial class ProjectAddUpdateViewController : UIViewController
	{
		int rowIndex=0;
		Database database;
		//ProjectManagers projectManager=new ProjectManagers();
		public ProjectAddUpdateViewController (int _rowIndex) : base ("ProjectAddUpdateViewController", null)
		{
			rowIndex = _rowIndex;
			//UnitOfWork.Init ();
			database = new Database (Path.Combine (Environment.GetFolderPath (Environment.SpecialFolder.MyDocuments), Constant.DatabaseName));

		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			View.BackgroundColor = UIColor.FromPatternImage (new UIImage("background.png"));
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
		}
		partial void btnCreate_Click (NSObject sender)
		{

				


		}
	}
}

