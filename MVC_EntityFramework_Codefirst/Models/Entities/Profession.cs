using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_EntityFramework_Codefirst.Models.Entities
{
    public class Profession
    {
        public int Id { get; set; }
        public string Description { get; set; }


        public List<Profession> Professions { get; set; }
    }
}