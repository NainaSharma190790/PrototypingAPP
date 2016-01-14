using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Collections.Generic;
using oPOP.Core;

namespace POP.Touch
{
	public class ProjectCollectionViewControllerCell : UICollectionViewCell
	{
		public static readonly NSString Key = new NSString ("ProjectCollectionViewControllerCell");

		[Export ("initWithFrame:")]
		public ProjectCollectionViewControllerCell (RectangleF frame) : base (frame)
		{
			// TODO: add subviews to the ContentView, set various colors, etc.
			BackgroundColor = UIColor.White;
			BackgroundView = new UIImageView (new UIImage("CellBack.png"));
		}
		public void CreateView(List<Projects> item, int indexPath)
		{
			var label = new UILabel (new RectangleF (0, 20, 71, 30));
			label.BackgroundColor = UIColor.Clear;
			label.TextAlignment = UITextAlignment.Center;
			label.Text = item [indexPath].ProjectName;
			label.TextColor = UIColor.White;

			if (item [indexPath].IsShared == true) {
				//Share Icon
				var shareLabel = new UILabel (new RectangleF (2, this.Frame.Height-17, 18, 15));
				shareLabel.BackgroundColor = UIColor.Clear;
				shareLabel.BackgroundColor = UIColor.FromPatternImage (new UIImage ("Share.png"));
				shareLabel.TextAlignment = UITextAlignment.Center;
				shareLabel.TextColor = UIColor.White;
				ContentView.AddSubview (shareLabel);
			}


			ContentView.AddSubview (label);
		}
	}
}

