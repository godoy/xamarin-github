// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System;
using System.CodeDom.Compiler;

namespace IphoneApp
{
	[Register ("IphoneAppViewController")]
	partial class IphoneAppViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnSearch { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableView lvwRepositories { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtUser { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (btnSearch != null) {
				btnSearch.Dispose ();
				btnSearch = null;
			}
			if (lvwRepositories != null) {
				lvwRepositories.Dispose ();
				lvwRepositories = null;
			}
			if (txtUser != null) {
				txtUser.Dispose ();
				txtUser = null;
			}
		}
	}
}
