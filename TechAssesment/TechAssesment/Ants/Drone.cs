using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechAssesment.Utilities;

namespace TechAssesment.Ants
{
    class Drone : Ant
    {
        public override char Cahracter => throw new NotImplementedException();

        public override void OnUpdate()
        {
            throw new NotImplementedException();
        }

        public Drone( Colony colony,Position position) : base(colony,position)
        {

        }
    }
}
