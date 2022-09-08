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
    public class PhoneBookManager:IPhoneBookService
    {
        public IPersonDal _personDal; 

        public PhoneBookManager(IPersonDal personDal)
        {
            _personDal = personDal;
        }

        #region Person
        public IResult Add(Person person)
        {
            _personDal.Add(person);
            return new SuccessResult(Messages.PersonAdded);
        }

        public IResult Delete(Person person)
        {
            _personDal.Delete(person);
            return new SuccessResult(Messages.PersonDeleted);
        }

        public IResult Update(Person person)
        {
            _personDal.Update(person);
            return new SuccessResult(Messages.PersonUpdated);
        }
        #endregion
    }
}
