using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice
{
    internal class Classroom
    {
        private string _ClassroomName;
        private int _ClassroomId;

        public Classroom(string classroomName, int classroomId)
        {
            _ClassroomName = classroomName;
            _ClassroomId = classroomId;
        }

        public  string ClassroomName
        {
            get { return _ClassroomName; }
            set { _ClassroomName = value;}
        }
        public int ClassroomId
        {
            get { return _ClassroomId; }
            set { _ClassroomId = value; }
        }

        public virtual void MethodParent()
        {
            Console.WriteLine("Parent Class Method 1");
        }

        public virtual void MethodParent2()
            {
            Console.WriteLine("Parent Class Method 2");
        }

        public override string ToString()
        {
            return ("ClassroomName:" + _ClassroomName + "ClassroomID:" + _ClassroomId);
        }
    }
}
