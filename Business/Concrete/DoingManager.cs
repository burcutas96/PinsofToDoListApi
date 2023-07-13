using Business.Abstract;
using Business.Constants.Messages;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class DoingManager : IDoingService
    {
        IDoingDal _doingDal;

        public DoingManager(IDoingDal doingDal)
        {
            _doingDal = doingDal;
        }


        public IResult Add(Doing entity)
        {
            _doingDal.Add(entity);
            return new SuccessResult(DoingMessages.DoingAdded);
        }

        public IResult Delete(Doing entity)
        {
            _doingDal.Delete(entity);
            return new SuccessResult(DoingMessages.DoingDeleted);
        }

        public IDataResult<Doing> Get(int id)
        {
            return new SuccessDataResult<Doing>(_doingDal.Get(d => d.Id == id), DoingMessages.DoingWasBrought);
        }

        public IDataResult<List<Doing>> GetAll()
        {
            return new SuccessDataResult<List<Doing>>(_doingDal.GetAll(), DoingMessages.DoingsListed);
        }

        public IResult Update(Doing entity)
        {
            _doingDal.Update(entity);
            return new SuccessResult(DoingMessages.DoingUpdated);
        }
    }
}
