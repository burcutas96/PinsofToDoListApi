using Business.Abstract;
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
    public class TodoManager : ITodoService
    {
        ITodoDal _todoDal;
        IDoingService _doingService;

        public TodoManager(ITodoDal todoDal, IDoingService doingService)
        {
            _todoDal = todoDal;
            _doingService = doingService;
        }


        public IResult Add(Todo entity)
        {
            _todoDal.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(Todo entity)
        {
            _todoDal.Delete(entity);

            Doing doing = new Doing
            {
                Task = entity.Task
            };

            _doingService.Add(doing);
            return new SuccessResult();
        }

        public IDataResult<Todo> Get(int id)
        {
            return new SuccessDataResult<Todo>(_todoDal.Get(t => t.Id == id));
        }

        public IDataResult<List<Todo>> GetAll()
        {
            return new SuccessDataResult<List<Todo>>(_todoDal.GetAll());
        }

        public IResult Update(Todo entity)
        {
            _todoDal.Update(entity);
            return new SuccessResult();
        }
    }
}
