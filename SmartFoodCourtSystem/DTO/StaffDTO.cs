using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFoodCourtSystem.DTO
{
    class StaffDTO
    {
        private static StaffDTO instance;
        public static StaffDTO Instance
        {
            get { if (instance == null) instance = new StaffDTO(); return StaffDTO.instance; }
            private set { StaffDTO.instance = value; }
        }
        private StaffDTO() { }
        public string name { get; set; }
        public string phone { get; set; }
    }
}
