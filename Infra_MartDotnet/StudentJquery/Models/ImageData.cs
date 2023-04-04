using System.ComponentModel.DataAnnotations;

namespace StudentJquery.Models
{
    public class ImageData
    {
        public string Name { get; set; }
        
     
        public string Email { get; set; }
       
        public string Phone { get; set; }
      

        public IFormFile Files { get; set; }

        public ImageData()
        {

        }
    }
}
