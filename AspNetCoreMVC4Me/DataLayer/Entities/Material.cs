using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities
{
    public class Material:Page
    {
        public int DIrectoryId { get; set; }
        public Directory Directiry { get; set; }
    }
}
