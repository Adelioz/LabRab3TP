using System;
using AppKit;
using CoreGraphics;
using Foundation;
using System.Collections;
using System.Collections.Generic;

namespace LabRab3
{
    public class StudentTableDelegate: NSTableViewDelegate
    {
        
        private const string cellId = "stud";

        private StudentTableDataSource DataSource;
        private ViewController viewCont;

        

        public StudentTableDelegate(StudentTableDataSource datasource, ViewController vc)
        {
            this.DataSource = datasource;
            this.viewCont = vc;
        }

        public override NSView GetViewForItem(NSTableView tableView, NSTableColumn tableColumn, nint row)
        {
            NSTextField view = (NSTextField)tableView.MakeView(cellId, this);
            if (view == null)
            {
                view = new NSTextField();
                view.Identifier = cellId;
                view.BackgroundColor = NSColor.Clear;
                view.Bordered = false;
                view.Selectable = false;
                view.Editable = false;
            }

            switch (tableColumn.Title)
            {
                case "Group":
                    view.StringValue = DataSource.Students[(int)row].Group.ToString();
                    break;
                case "Name":
                    view.StringValue = string.Format("{0} {1}", DataSource.Students[(int)row].SurName, DataSource.Students[(int)row].Name);
                    break;
            }

            

            return view;
        }

        public override bool ShouldSelectRow(NSTableView tableView, nint row)
        {
            viewCont.sendTextField(DataSource.Students[(int)row], (int)row);
            return true;
        }

        

        
        

    }
}
