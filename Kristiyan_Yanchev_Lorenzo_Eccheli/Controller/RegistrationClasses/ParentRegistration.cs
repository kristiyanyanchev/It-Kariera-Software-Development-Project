using Controller.RegistrationClasses.ParentRegistrationStrategies;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.RegistrationClasses
{
    public class ParentRegistration
    {
        internal IParentRegistrationStrategy RegistrationStrategy { get; set; }
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
