using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSL.Partiel01.Domain.Entities
{
    public class Complexe
    {
        public List<Housing> Housings { get; set; }

        public Complexe(List<Housing> housings)
        {
            Housings = housings;
        }

        public Housing GetHousing(string name)
        {
            return Housings.Single(_ => _.Name == name);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var housing in Housings)
            {
               sb.AppendLine(housing.ToString());
            }
            return sb.ToString();
        }
    }
}
