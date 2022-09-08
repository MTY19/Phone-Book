using Business.Abstract;
using Business.Constant;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entitities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PersonAddressManager:IPersonAddressService
    {
        public IPersonAddressDal _personAddressDal; 

        public PersonAddressManager(IPersonAddressDal personAddressDal)
        {
            _personAddressDal = personAddressDal;
        }

        #region PersonAddress
        public IResult Add(PersonAddress personAddress)
        {
            _personAddressDal.Add(personAddress);
            return new SuccessResult(Messages.PersonAddressAdded);
        }

        public IResult Delete(PersonAddress personAddress)
        {
            _personAddressDal.Delete(personAddress);
            return new SuccessResult(Messages.PersonAddressDeleted);
        }

        public IResult Update(PersonAddress personAddress)
        {
            _personAddressDal.Update(personAddress);
            return new SuccessResult(Messages.PersonAddressUpdated);
        }
        #endregion
    }
}
