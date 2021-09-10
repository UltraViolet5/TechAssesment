using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechAssesment.Utilities;

namespace TechAssesment.Ants
{
    public abstract class  Ant
    {
        protected Colony MyColony { get; }

        public Position Position { get; }

        protected Ant (Colony myColony,Position position )
        {
            MyColony = myColony;
            Position = MyColony.Place(this, position, false);
        }

        public abstract void OnUpdate();

        public abstract Char Cahracter { get; }

    }
}
