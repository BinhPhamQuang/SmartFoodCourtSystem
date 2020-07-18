using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFoodCourtSystem.DTO
{
    class Bill
    {
        public int idbill { get; set; }
        public int day { get; set; }
        public int month { get; set; }
        public int year { get; set; }
        public long totalprice { get; set; }
        public string timecheckout { get; set; }
        public int status { get; set; }
        public Bill()
        {
            DateTime time = DateTime.Now;
            this.day = time.Day;
            this.month = time.Month;
            this.year = time.Year;
            status = 0;
            this.idbill = (year % 100) * (1000000) + month * 10000 + day * 100 + time.Hour+ time.Minute + time.Second;
            
        }
        
    }
}
