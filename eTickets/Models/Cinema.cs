using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Name")]
        public string Name { get; set; }
        [Display(Name = "Cinema Logo")]
        public string Logo { get; set; }
        [Display(Name = "Descriptuion")]
        public string Description { get; set; }
        //Relationship
        public List<Movie> Movies { get; set; }
    }
}
