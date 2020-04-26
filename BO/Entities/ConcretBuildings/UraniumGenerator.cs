using BO.Extensions;
using BO.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Entities.ConcretBuildings
{
    class UraniumGenerator : ResourceGenerator
    {
        private Func<int?, int?> energyFunc = x => x;
        private Func<int?, int?> oxygenFunc = x => 200 * (x / 2) + 20;
        private Func<int?, int?> steelFunc = x => (100 * (x / 3)) + 20;

        public override List<Resource> ResourceBySecond
        {
            get
            {
                Resource uranium = new Resource()
                {
                    Name = ResourceNames.Uranium.GetName(),
                    LastQuantity = (int?)(7 * Math.Pow(Level.Value, 3) + 2),
                    LastUpdate = DateTime.Now
                };
                return new List<Resource> { uranium };
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
                Resource oxygen = new Resource()
                {
                    Name = ResourceNames.Oxygen.GetName(),
                    LastQuantity = MathTools.RecurrentAddition(oxygenFunc, Level),
                    LastUpdate = DateTime.Now
                };
                Resource steel = new Resource()
                {
                    Name = ResourceNames.Steel.GetName(),
                    LastQuantity = MathTools.RecurrentAddition(steelFunc, Level),
                    LastUpdate = DateTime.Now
                };


                return new List<Resource> { energy, oxygen, steel };
            }
        }

        public override List<Resource> NextCost
        {
            get
            {
                Resource energy = new Resource()
                {
                    Name = ResourceNames.Energy.GetName(),
                    LastQuantity = energyFunc.Invoke(Level),
                    LastUpdate = DateTime.Now
                };
                Resource oxygen = new Resource()
                {
                    Name = ResourceNames.Oxygen.GetName(),
                    LastQuantity = oxygenFunc.Invoke(Level),
                    LastUpdate = DateTime.Now
                };
                Resource steel = new Resource()
                {
                    Name = ResourceNames.Steel.GetName(),
                    LastQuantity = steelFunc.Invoke(Level),
                    LastUpdate = DateTime.Now
                };


                return new List<Resource> { energy, oxygen, steel };
            }
        }
    }
}
