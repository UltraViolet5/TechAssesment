using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechAssesment.Utilities;

namespace TechAssesment.Ants
{
    class Worker : Ant
    {
        public override char Cahracter => 'W'

        public override void OnUpdate()
        {
            throw new NotImplementedException();
        }

        public Worker(Colony colony, Position position) : base(colony,position)
        {

        }
    }
}
