using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWallet.Model
{
    public enum TargetType { Goal, Debt }
    public class Target
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float Value { get; set; }
        public int Type { get; set; }

        public Target(string name, float value, TargetType type)
        {
            Name = name;
            Value = value;
            Type = (int)type;
        }
    }
}
