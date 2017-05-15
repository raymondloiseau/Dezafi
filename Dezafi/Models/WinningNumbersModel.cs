using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Dezafi.Models
{
    public class WinningNumbersModel
    {
        [System.ComponentModel.DataAnnotations.Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Current date")]
        public string CurrentDate { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 10)]
        [DataType(DataType.Text)]
        [Display(Name = "Winning Numbers")]
        public string WinningNumbers { get; set; }
        
    }

    
}