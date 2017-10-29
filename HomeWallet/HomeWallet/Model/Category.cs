using System.Drawing;

namespace HomeWallet.Model
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Color Color { get; set; }

        public Category()
        {

        }

        public Category(string name, Color color)
        {
            Name = name;
            Color = color;
        }
    }
}
