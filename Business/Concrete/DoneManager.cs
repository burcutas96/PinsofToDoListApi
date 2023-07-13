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
    public class DoneManager : IDoneService
    {
        IDoneDal _doneDal;

        public DoneManager(IDoneDal doneDal)
        {
            _doneDal = doneDal;
        }


        public IResult Add(Done entity)
        {
            _doneDal.Add(entity);
            return new SuccessResult(DoneMessages.DoneAdded);
        }

        public IResult Delete(Done entity)
        {
            _doneDal.Delete(entity);
            return new SuccessResult(DoneMessages.DoneDeleted);
        }

        public IDataResult<Done> Get(int id)
        {
            return new SuccessDataResult<Done>(_doneDal.Get(d => d.Id == id), DoneMessages.DoneWasBrought);
        }

        public IDataResult<List<Done>> GetAll()
        {
            return new SuccessDataResult<List<Done>>(_doneDal.GetAll(), DoneMessages.DonesListed);
        }

        public IResult Update(Done entity)
        {
            _doneDal.Update(entity);
            return new SuccessResult(DoneMessages.DoneUpdated);
        }
    }
}
