using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DropDownListWithEF.Shared.Models
{
    public class Region
    {
        [Key]
        public int? RegionID { get; set; }

        public string RegionDescription { get; set; }
    }

    public class Territories
    {
        [Key]
        public string TerritoryID { get; set; }

        public string TerritoryDescription { get; set; }
        
        public int? RegionID { get; set; }

    }
}
