using BMES_REST_API.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMES_REST_API.Models.Product
{
    public class Category: BaseObject
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public CategoryStatus BrandStatus { get; set; }
        public CategoryStatus CategoryStatus { get; internal set; }
    }
}
