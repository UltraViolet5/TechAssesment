using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechAssesment.Utilities;

namespace TechAssesment.Ants
{
    class Soldier : Ant
    {
        public override char Cahracter => 'S';

        public override void OnUpdate()
        {
            throw new NotImplementedException();
        }

        public Soldier(Colony colony, Position position) : base(colony, position)
        {

        }
    }
}
