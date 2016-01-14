using System;
using MonoTouch.UIKit;
using System.Drawing;
using MonoTouch.Foundation;

namespace POP.Touch
{
	public class ProjectCollectionLayout : UICollectionViewFlowLayout
	{
		public ProjectCollectionLayout ()
		{
			ItemSize = new SizeF (72, 72);
		}
		public override bool ShouldInvalidateLayoutForBoundsChange (RectangleF newBounds)
		{
			return true;
		}

		public override UICollectionViewLayoutAttributes LayoutAttributesForItem (NSIndexPath path)
		{
			return base.LayoutAttributesForItem (path);
		}

		public override UICollectionViewLayoutAttributes[] LayoutAttributesForElementsInRect (RectangleF rect)
		{
			return base.LayoutAttributesForElementsInRect (rect);

		}
	}
}

