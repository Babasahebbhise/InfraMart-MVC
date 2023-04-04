using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice
{
    internal class Student : Classroom
    {
        private string _name;
        private string _lastname;
        private int _age;

        public Student(string classroomname,int classroomid,string name, string lastname, int age):base(classroomname, classroomid)
        {
            this._name = name;
            this._lastname = lastname;
            this._age = age;
        }   

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string LastName
        {
            get { return _lastname; }
            set { _lastname = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public override void MethodParent()
        {
            Console.WriteLine("Method 1 in Child Class");
        }

        public override void MethodParent2()
        {
            Console.WriteLine("Method 2 In Chile Class");
        }
        public override string ToString()
        {
            return ("Name is" + _name + "Last Name is:" + _lastname + "Age is:" + _age+"Classroom : "+ClassroomName+"ClassroomId : "+ClassroomId);
        }

    }
}
