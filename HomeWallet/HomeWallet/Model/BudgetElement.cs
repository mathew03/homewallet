using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWallet.Model
{
    public class BudgetElement
    {
        public int ID { get; set; }
        public int Type { get; set; }
        public string Title { get; set; }
        public float Value { get; set; }
        public int UserId { get; set; }
        public int ProductListId { get; set; }
    }
}
