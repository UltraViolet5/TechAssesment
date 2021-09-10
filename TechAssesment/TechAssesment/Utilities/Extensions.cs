using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechAssesment.Utilities
{
    class Extensions
    {
        public static readonly Random Rand = new Random();
        public Direction GetRandomDirection()
        {
            

            Direction[] allDirection = (Direction[]) Enum.GetValues(typeof(Direction));

            return allDirection[Rand.Next(0, allDirection.Length)];
        }
    }
}
