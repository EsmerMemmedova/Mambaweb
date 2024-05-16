using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mamba.Business.Exteptions
{
    public class FileSizeExteption:Exception
    {
        public string PropertyName { get; set; }
        public FileSizeExteption(string propertyname,string? message) : base(message) 
        {
         PropertyName= propertyname;
        }
    }
}
