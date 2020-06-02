using System;

using AppKit;
using Foundation;

namespace LabRab3
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public StudentTableDataSource DataSource = new StudentTableDataSource();

        public int selected = -1;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            

            //var DataSource = new StudentTableDataSource();
            DataSource.Students.Add(new Student(1, "Adel", "Rakhimov", 1999, "Kazan"));
            DataSource.Students.Add(new Student(2, "Ramil", "Salahov", 2010, "Aznakaevo"));


            groupField.StringValue = StudentTable.SelectedRow.ToString();

            StudentTable.DataSource = DataSource;
            StudentTable.Delegate = new StudentTableDelegate(DataSource, this);




            // Do any additional setup after loading the view.
        }

        public void sendTextField(Student student, int selected)
        {
            groupField.StringValue = student.Group.ToString();
            nameField.StringValue = student.Name;
            surnameField.StringValue = student.SurName;
            birthField.StringValue = student.BirthYear.ToString();
            hometownField.StringValue = student.IsLocal;

            this.selected = selected;
        }

        partial void addButton(NSObject sender)
        {
            DataSource.Students.Add(new Student());
            Console.WriteLine(DataSource.Students.Count);
            StudentTable.ReloadData();
        }

        partial void deleteButton(NSObject sender)
        {
            if (DataSource.Students.Count > 0 && selected != -1)
            {
                DataSource.Students.RemoveAt(selected);
                StudentTable.ReloadData();
                selected = -1;
                groupField.StringValue = "";
                nameField.StringValue = "";
                surnameField.StringValue = "";
                birthField.StringValue = "";
                hometownField.StringValue = "";
            }
            
        }

        partial void saveButton(NSObject sender)
        {
            var alert = new NSAlert()
            {
                AlertStyle = NSAlertStyle.Critical,
                InformativeText = "Group and Birth year must be integer.",
                MessageText = "Format error",
            };

            if (selected != -1 && int.TryParse(groupField.StringValue, out int groupInt) && int.TryParse(birthField.StringValue, out int birthInt))
            {
                DataSource.Students[selected].Group = groupInt; 
                DataSource.Students[selected].Name = nameField.StringValue;
                DataSource.Students[selected].SurName = surnameField.StringValue;
                DataSource.Students[selected].BirthYear = birthInt;
                DataSource.Students[selected].IsLocal = hometownField.StringValue;

                StudentTable.ReloadData();
            } else
            {
                alert.RunModal();
            }

        }


        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }



    }
}
