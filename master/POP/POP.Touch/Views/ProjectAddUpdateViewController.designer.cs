// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace POP.Touch
{
	[Register ("ProjectAddUpdateViewController")]
	partial class ProjectAddUpdateViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton btnCreate { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnDelete { get; set; }

		[Outlet]
		MonoTouch.UIKit.UISwitch SwcIsActive { get; set; }

		[Outlet]
		MonoTouch.UIKit.UISwitch SwcIsShared { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITableView tblTeamMember { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField txtProjectName { get; set; }

		[Action ("btnCreate_Click:")]
		partial void btnCreate_Click (MonoTouch.Foundation.NSObject sender);

		[Action ("btnDelete_Click:")]
		partial void btnDelete_Click (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (txtProjectName != null) {
				txtProjectName.Dispose ();
				txtProjectName = null;
			}

			if (SwcIsShared != null) {
				SwcIsShared.Dispose ();
				SwcIsShared = null;
			}

			if (SwcIsActive != null) {
				SwcIsActive.Dispose ();
				SwcIsActive = null;
			}

			if (tblTeamMember != null) {
				tblTeamMember.Dispose ();
				tblTeamMember = null;
			}

			if (btnCreate != null) {
				btnCreate.Dispose ();
				btnCreate = null;
			}

			if (btnDelete != null) {
				btnDelete.Dispose ();
				btnDelete = null;
			}
		}
	}
}
