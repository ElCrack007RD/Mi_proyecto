using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_EntityFramework_Codefirst.Models.Entities
{   
    [Table("Personas")]
    public class Persons
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateBirth { get; set; }
        public string Phone { get; set; }
        public Profession Profession { get; set; }
        public int ProfessionId { get; set; }
    }
} 