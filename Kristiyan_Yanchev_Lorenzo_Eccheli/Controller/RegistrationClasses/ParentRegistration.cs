using Controller.RegistrationClasses.ParentRegistrationStrategies;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.RegistrationClasses
{
    /// <summary>
    /// Provides different strategies for registration.
    /// </summary>
    public class ParentRegistration
    {
        internal IParentRegistrationStrategy RegistrationStrategy { get; set; }

        /// <summary>
        /// Transforms parentDto to Parent
        /// </summary>
        /// <param name="Dto"></param>
        /// <returns></returns>
        public Parent Register(ParentDataTransferObject Dto)
        {
            return RegistrationStrategy.Execute(Dto);
        }

        public ParentRegistration()
        {
            RegistrationStrategy = new DefaultParentRegistration();
        }
    }
}
