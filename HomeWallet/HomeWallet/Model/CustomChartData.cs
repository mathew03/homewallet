using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWallet.Model
{
    public class CustomChartData
    {
        public string CategoryName { get; set; }
        public float Total { get; set; }

        public CustomChartData(float total, string catName)
        {
            CategoryName = catName;
            Total = total;
        }
    }
}
