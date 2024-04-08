using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task08._04.Models
{
    internal interface ICodeAcademy
    {
        public string CodeEmail { get; set; }

        void GenarateEmail();
        
    }
}
