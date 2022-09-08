using Core.Utilities.Results;
using Entitities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IPersonService
    {
        #region Person
        IResult Add(Person person);
        IResult Delete(Person person);
        IResult Update(Person person);
        #endregion
    }
}
