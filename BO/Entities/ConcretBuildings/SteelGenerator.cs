using BO.Extensions;
using BO.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Entities.ConcretBuildings
{
    public class SteelGenerator : ResourceGenerator
    {
        private Func<int?, int?> energyFunc = x => x;
        private Func<int?, int?> oxygenFunc = x => (int?) (2 * Math.Pow(x.Value, 3) + (300 * (x / 6)) + 50);
        private Func<int?, int?> steelFunc = x => 100 * (x / 8) + 20;
        private Func<int?, int?> uraniumFunc = x => (int)((7 * Math.Pow(x.Value, 3) + (200 * (x / 12)) + 20));
        
        public override List<Resource> ResourceBySecond
        {
            get
            {
                Resource steel = new Resource()
                {
                    Name = ResourceNames.Energy.GetName(),
                    LastQuantity = 10 * Level / 2 + 1,
                    LastUpdate = DateTime.Now
                };

                return new List<Resource> { steel };
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
            get
            {

                Resource energy = new Resource()
                {
                    Name = ResourceNames.Energy.GetName(),
                    LastQuantity = energyFunc.Invoke(Level + 1),
                    LastUpdate = DateTime.Now
                };
                Resource steel = new Resource()
                {
                    Name = ResourceNames.Steel.GetName(),
                    LastQuantity = steelFunc.Invoke(Level + 1),
                    LastUpdate = DateTime.Now
                };
                Resource oxygen = new Resource()
                {
                    Name = ResourceNames.Oxygen.GetName(),
                    LastQuantity = oxygenFunc.Invoke(Level + 1),
                    LastUpdate = DateTime.Now
                };
                Resource uranium = new Resource()
                {
                    Name = ResourceNames.Uranium.GetName(),
                    LastQuantity = uraniumFunc.Invoke(Level + 1),
                    LastUpdate = DateTime.Now
                };

                return new List<Resource> { energy, oxygen, steel, uranium };
            }
        }
    }
}
