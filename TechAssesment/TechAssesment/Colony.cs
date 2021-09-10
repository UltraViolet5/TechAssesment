using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechAssesment.Ants;
using TechAssesment.Utilities;

namespace TechAssesment
{
    public class Colony
    {
        public int Width {get;}

        private readonly Ant[,] _ants;
        public Colony(int witdth)
        {
            Width = witdth;

        }

        public List<Ant> GenerateAnts(int workers,int soldiers, int drones )
        {
            List<Position> positions;

        }

        public Position Place (Ant ant, Position targetposition, bool emptyOldPosition )
        {
            if(emptyOldPosition)
            {
                Position oldPosition = ant.Position;

                this[oldPosition] = null;
            }
        }

        public Ant this[Position position]
        {
            get => _ants[position.Y, position.X];
            set => _ants[position.Y, position.X] = value;
        }
    }
}
