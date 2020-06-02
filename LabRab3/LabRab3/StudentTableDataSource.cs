using System;
using AppKit;
using CoreGraphics;
using Foundation;
using System.Collections;
using System.Collections.Generic;

namespace LabRab3
{
    public class StudentTableDataSource: NSTableViewDataSource
    {
        #region Public Variiables
        public List<Student> Students = new List<Student>();
        #endregion

        #region Constructors
        public StudentTableDataSource()
        {
        }
        #endregion

        #region Override Methods
        public override nint GetRowCount(NSTableView tableView)
        {
            return Students.Count;
        }
        #endregion


    }
}
