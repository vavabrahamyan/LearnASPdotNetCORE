using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoftBlogLeranAspNetCoreMVC.Models
{
    public class HelloModel
    {
        public string HelloMessage { get; set; }
        public string _HelloMessage(string str)
        {
            return "Hello__" + str;
        }
    }
}
