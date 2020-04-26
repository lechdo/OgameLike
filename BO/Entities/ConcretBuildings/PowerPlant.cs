using BO.Extensions;
using BO.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace BO.Entities.ConcretBuildings
{
    class PowerPlant : ResourceGenerator
    {
        private Func<int?, int?> energyFunc = x => x; 
        private Func<int?, int?> oxygenFunc = x => 1 * x + (200 * (x / 10)) + 20;
        private Func<int?, int?> steelFunc = x => 1 * x + (100 * (x / 8) + 20);
        private Func<int?, int?> uraniumFunc = x => (int)((3 * Math.Pow(x.Value, 3) + (200 * (x / 20)) + 20));

        public override List<Resource> ResourceBySecond
        {
            get
            {
                Resource energy = new Resource()
                {
                    Name = ResourceNames.Energy.GetName(),
                    LastQuantity = 3 * Level + 10,
                    LastUpdate = DateTime.Now
                };
            
                return new List<Resource> { energy };
            }
        }

        public override List<Resource> TotalCost
        {
            get
            {
                Resource energy = new Resource()
                {
                    Name = ResourceNames.Energy.GetName(),
                    LastQuantity = MathTools.RecurrentAddition(energyFunc, Level),
                    LastUpdate = DateTime.Now
                };
                Resource steel = new Resource()
                {
                    Name = ResourceNames.Steel.GetName(),
                    LastQuantity = MathTools.RecurrentAddition(steelFunc, Level),
                    LastUpdate = DateTime.Now
                };
                Resource oxygen = new Resource()
                {
                    Name = ResourceNames.Oxygen.GetName(),
                    LastQuantity = MathTools.RecurrentAddition(oxygenFunc, Level),
                    LastUpdate = DateTime.Now
                };
                Resource uranium = new Resource()
                {
                    Name = ResourceNames.Uranium.GetName(),
                    LastQuantity = MathTools.RecurrentAddition(uraniumFunc, Level),
                    LastUpdate = DateTime.Now
                };

                return new List<Resource> { energy, oxygen, steel, uranium };
            }
        }

        public override List<Resource> NextCost
        {
            get {

                Resource energy = new Resource()
                { Name = ResourceNames.Energy.GetName(),
                  LastQuantity = energyFunc.Invoke(Level +1),
                  LastUpdate = DateTime.Now };
                Resource steel = new Resource() 
                { Name = ResourceNames.Steel.GetName(),
                  LastQuantity = steelFunc.Invoke(Level + 1),
                  LastUpdate = DateTime.Now };
                Resource oxygen = new Resource() 
                { Name = ResourceNames.Oxygen.GetName(),
                  LastQuantity = oxygenFunc.Invoke(Level + 1),
                  LastUpdate = DateTime.Now};
                Resource uranium = new Resource()
                { Name = ResourceNames.Uranium.GetName(),
                  LastQuantity = uraniumFunc.Invoke(Level+ 1),
                  LastUpdate = DateTime.Now };

                return new List<Resource> { energy, oxygen, steel, uranium };
            }
        }
    }
}
