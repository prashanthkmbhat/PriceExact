﻿using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuppliesPriceLister.Models.Data
{
    public class CSVDataModel
    {
        [Index(0)]
        public string Id { get; set; }
        [Index(1)]
        public string Description { get; set; }
        [Index(2)]
        public string Unit { get; set; }
        [Index(3)]
        public float Price { get; set; }
    }
}
