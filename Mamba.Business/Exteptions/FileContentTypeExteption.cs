using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mamba.Business.Exteptions
{
    public class FileContentTypeExteption:Exception
    {
        public string PropertyName { get; set; }    
      public FileContentTypeExteption(string propertyName, string? message):base(message) 
        {
            PropertyName = propertyName;
        
        
        }
    }
}
