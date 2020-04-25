using BO;
using BO.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace BO.Validators
{
    public class ResourcesListValidator : ValidationAttribute
    {
        

        public override bool IsValid(Object value)
        {
            bool result = true;
            List<string> resourcesNames = new List<string> { "énergie", "uranium", "oxygène", "acier" };
            
            try
            {
                List<Resource> resourcesList = value as List<Resource>;

                // #1 resources must be 4
                if (resourcesList.Count != 4)
                {
                    result = false;
                }

                // #2 resources names must be in resourcesName list
                if (resourcesList.Select(r => r.Name).Any(n => !resourcesNames.Contains(n)))
                {
                    result = false;
                } 

            }
            catch (Exception e)
            {
                result = false;
                throw e;
            }
            return result;
        }
    }
}