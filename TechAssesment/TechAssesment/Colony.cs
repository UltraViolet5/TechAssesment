using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechAssesment.Ants;
using TechAssesment.Utilities;

namespace TechAssesment
{
    public class Colony
    {
        public int Width { get; }

        private readonly Ant[,] _ants;

        public Queen queen { get; }
        public Colony(int witdth)
        {
            Width = witdth;

        }

        public List<Ant> GenerateAnts(int workers, int soldiers, int drones)
        {
            List<Position> positions = GetFreePositions().ToList();

            Position getRandmPosition



        }

        public Position Place(Ant ant, Position targetPosition, bool emptyOldPosition)
        {
            if (emptyOldPosition)
            {
                Position oldPosition = ant.Position;

                this[oldPosition] = null;
            }
            this[targetPosition] = ant;
            return targetPosition;
        }

        public Ant this[Position position]
        {
            get => _ants[position.Y, position.X];
            set => _ants[position.Y, position.X] = value;
        }

        public void update()
        {
            foreach (var ant in _ants)
            {
                Act();
            }

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Ant ant = _ants[i, j];
                    sb.Append(ant?.Cahracter ?? ' ');
                }
            }

            return sb.ToString();
        }

        public Position[] GetFreePositions()
        {
            List<Position> freePosition = new List<Position>;

            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j <Width; j++)
                {
                    if(_ants[j,i]==null)
                    {
                   
                       freePosition.Add(new Position(i, j));
                       

                    }
                 
                }
            }

            return freePosition.ToArray();
        }

        public void display()
        {
            List<Colony> colonie = new List<Colony>
            {
                new Colony(20),
            };

            while(true)
            {
                Console.Clear();
                colonie.ForEach(c =>
                {
                    c.update();
                    Console.WriteLine(c.ToString());
                });
                Thread.Sleep(100);
            }

        }

        public void Act()
        {

        }


    }
}
