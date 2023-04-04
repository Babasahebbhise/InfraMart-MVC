using System.ComponentModel.DataAnnotations;

namespace StudentJquery.Models
{
    public class StudentModel
    {
        [Key]
        public string Name
        {
            get;
            set;
        }
        [Required]
        public string Email
        {
            get;
            set;
        }
        public string Phone
        {
            get;
            set;
        }
        public string Image
        {
            get;
            set;
        }
        public StudentModel()
        {

        }
        public StudentModel(string name, string email, string phone)
        {
            Name = name;
            Email = email;
            Phone = phone;
        }

        public override string ToString()
        {
            return ("Name" + Name + "Email:" + Email + "Number:" + Phone);
        }
    }
}
