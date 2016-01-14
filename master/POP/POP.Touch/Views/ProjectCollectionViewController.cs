using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Collections.Generic;
using oPOP.Core;
using oPOP.Data;
using System.IO;
using System.Linq;
using oPOP.Data.Logging;

namespace POP.Touch
{
	public class ProjectCollectionViewController : UICollectionViewController
	{
		Database database;
		public ProjectCollectionViewController (UICollectionViewLayout layout) : base (layout)
		{
			database = new Database (Path.Combine (Environment.GetFolderPath (Environment.SpecialFolder.MyDocuments), Constant.DatabaseName));
			database.Trace = true;

		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}
		List<Projects> projectData;
		public override void ViewDidLoad ()
		{
			CollectionView.BackgroundColor = UIColor.FromPatternImage (new UIImage ("background.png"));
			base.ViewDidLoad ();
			CollectionView.RegisterClassForCell (typeof(ProjectCollectionViewControllerCell), ProjectCollectionViewControllerCell.Key);

			var projectItem=new Projects();
			projectItem.ProjectName="Test"; //txtProjectName.Text;
			projectItem.IsShared=false;
			projectItem.IsActive=true;
			//
			//projectManager.AddUpdate(projectItem);
			var id=  database.Insert(projectItem);

			Console.WriteLine ("Get ID : " + id);

			if (projectData == null) {
				projectData = database.GetItems<Projects> ().ToList();
				if (projectData == null || projectData.Count == 0) {
					projectData = DummyData.GetData ();
				}
			}

		}

		public override int NumberOfSections (UICollectionView collectionView)
		{
    		return 1;
		}

		public override int GetItemsCount (UICollectionView collectionView, int section)
		{
			// TODO: return the actual number of items in the section
			return projectData.Count;
		}

		public override UICollectionViewCell GetCell (UICollectionView collectionView, NSIndexPath indexPath)
		{
			var cell = collectionView.DequeueReusableCell (ProjectCollectionViewControllerCell.Key, indexPath) as ProjectCollectionViewControllerCell;
			
			//TODO: populate the cell with the appropriate data based on the indexPath

			cell.CreateView (projectData,indexPath.Item);

			return cell;
		}
		public override void ItemSelected (UICollectionView collectionView, NSIndexPath indexPath)
		{
			//base.ItemSelected (collectionView, indexPath);
			this.NavigationController.PushViewController (new ProjectAddUpdateViewController (indexPath.Row), true);
		}
	}
}

