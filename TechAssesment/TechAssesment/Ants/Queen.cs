using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechAssesment.Utilities;

namespace TechAssesment.Ants
{
    public class Queen : Ant
    {
        public override char Cahracter => 'Q';

        public override void OnUpdate()
        {
            throw new NotImplementedException();
        }

        public Queen(Colony colony, Position position) : base(colony, position)
        {

        }
    }
}
