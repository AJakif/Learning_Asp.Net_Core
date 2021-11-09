using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Uplift.Models
{
    public class Frequency
    {
        [Key] //Attribute
        public int Id { get; set; } /* Public = access modifier,
                                        int = Data Type
                                        Id = data name
                                        get,set = methods
                                     */
        [Required]
        public int FrequencyCount { get; set; }

        [Required]
        [Display(Name = "Frequency Name")] // Data name display on client side

        public string Name { get; set; }

    }
}
