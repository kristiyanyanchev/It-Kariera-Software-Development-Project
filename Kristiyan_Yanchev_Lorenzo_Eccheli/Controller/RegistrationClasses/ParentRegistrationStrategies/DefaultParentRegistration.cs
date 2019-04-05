using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using Data.Repositories;

namespace Controller.RegistrationClasses.ParentRegistrationStrategies
{
    
    class DefaultParentRegistration : IParentRegistrationStrategy
    {
        
        public Parent Execute(ParentDataTransferObject parentDto)
        {
            
            var parentRepo = new ParentsRepository();

            var parent = new Parent(parentDto.FirstName, parentDto.LastName, parentDto.Address, parentDto.Email,
                           parentDto.PhoneNumber, parentDto.Username, parentDto.Password, parentDto.ValidationCode);
            var children = new StudentsRepository().List().Where(x => x.Username == parentDto.UsernameOfChild).ToList();


            parentRepo.AddParentWithChildren(parent, children);
            var validationCodes = new ValidationCodeRepository();
            var currentValidationCode = validationCodes.List().Single(x => x.Code == parentDto.ValidationCode);
            currentValidationCode.Used = true;
            validationCodes.Edit(currentValidationCode);

            return parent;

        }
    }
}
