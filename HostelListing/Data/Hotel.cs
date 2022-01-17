﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HostelListing.Data
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double rating { get; set; }
        [ForeignKey(nameof(Country))]
        public Country Country { get; set; }
        public int CountryId { get; set; }
    }
}
