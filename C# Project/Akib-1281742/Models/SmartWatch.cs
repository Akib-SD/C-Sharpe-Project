using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akib_1281742.Model
{
    public class SmartWatch:EntityBase
    {
        public string Model {  get; set; }
       
        public int YearMake {  get; set; }
        public string OriginCountry { get; set; }
        public decimal Price {  get; set; }
        
    }
}
