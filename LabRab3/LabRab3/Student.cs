using System;
namespace LabRab3
{
    public class Student
    {

        public int Group { get; set; } = 0;
        public string Name { get; set; } = "";
        public string SurName { get; set; } = "";
        public int BirthYear { get; set; } = 0;
        public string IsLocal { get; set; } = "";


        public Student()
        {
        }

        public Student(int group, string name, string surName, int birthYear, string isLocal)
        {
            this.Group = group;
            this.Name = name;
            this.SurName = surName;
            this.BirthYear = birthYear;
            this.IsLocal = isLocal;
        }


    }
}
