using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore_EventApp.Models
{
    public class Event
    {

        [Key]
        public int EventId { get; set; }
        [DataType("nvarchar(max)")]
        [Required]
        public string Title { get; set; }
        [DataType(DataType.Date)]
        
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        

        public DateTime EndDate { get; set; }
       
        public string Country { get; set; }
      
        public string City { get; set; }
       
        public string PhotoUrl { get; set; }
        [Required]
        [DataType("nvarchar(max)")]
        public string Description { get; set; }


    }
}
