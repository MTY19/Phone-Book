using Core.Utilities.Results;
using Entitities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IPersonAddressService
    {
        #region PersonAddress
        IResult Add(PersonAddress personAddress);
        IResult Delete(PersonAddress personAddress);
        IResult Update(PersonAddress personAddress);
        #endregion
    }
}
