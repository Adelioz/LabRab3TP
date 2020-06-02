// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace LabRab3
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField birthField { get; set; }

		[Outlet]
		AppKit.NSTableColumn GroupColumn { get; set; }

		[Outlet]
		AppKit.NSTextField groupField { get; set; }

		[Outlet]
		AppKit.NSTextField hometownField { get; set; }

		[Outlet]
		AppKit.NSTableColumn NameColumn { get; set; }

		[Outlet]
		AppKit.NSTextField nameField { get; set; }

		[Outlet]
		AppKit.NSTableView StudentTable { get; set; }

		[Outlet]
		AppKit.NSTextField surnameField { get; set; }

		[Action ("addButton:")]
		partial void addButton (Foundation.NSObject sender);

		[Action ("deleteButton:")]
		partial void deleteButton (Foundation.NSObject sender);

		[Action ("saveButton:")]
		partial void saveButton (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (birthField != null) {
				birthField.Dispose ();
				birthField = null;
			}

			if (GroupColumn != null) {
				GroupColumn.Dispose ();
				GroupColumn = null;
			}

			if (groupField != null) {
				groupField.Dispose ();
				groupField = null;
			}

			if (hometownField != null) {
				hometownField.Dispose ();
				hometownField = null;
			}

			if (NameColumn != null) {
				NameColumn.Dispose ();
				NameColumn = null;
			}

			if (nameField != null) {
				nameField.Dispose ();
				nameField = null;
			}

			if (StudentTable != null) {
				StudentTable.Dispose ();
				StudentTable = null;
			}

			if (surnameField != null) {
				surnameField.Dispose ();
				surnameField = null;
			}
		}
	}
}
