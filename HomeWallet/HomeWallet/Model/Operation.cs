using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWallet.Model
{
    public class Operation
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public float Value { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }

        public User User { get; set; }
        public Category Category { get; set; }

        public Operation()
        {

        }

        public Operation(string title, string description, float value, DateTime date, Category cat, User user)
        {
            Title = title;
            Description = description;
            Value = value;
            Date = date;
            CategoryId = cat.ID;
            UserId = user.ID;
        }
    }
}
