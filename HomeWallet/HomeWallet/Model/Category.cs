using System.Drawing;
using System.Linq;

namespace HomeWallet.Model
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Color { get; set; }

        public Category()
        {
   
        }

        public Category(string name, int color)
        {
            Name = name;
            Color = color;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
