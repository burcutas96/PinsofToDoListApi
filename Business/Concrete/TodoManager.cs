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
    public class TodoManager : ITodoService
    {
        ITodoDal _todoDal;

        public TodoManager(ITodoDal todoDal)
        {
            _todoDal = todoDal;
        }


        public IResult Add(Todo entity)
        {
            _todoDal.Add(entity);
            return new SuccessResult(TodoMessages.TodoAdded);
        }

        public IResult Delete(Todo entity)
        {
            _todoDal.Delete(entity);
            return new SuccessResult(TodoMessages.TodoDeleted);
        }

        public IDataResult<Todo> Get(int id)
        {
            return new SuccessDataResult<Todo>(_todoDal.Get(t => t.Id == id), TodoMessages.TodoWasBrought);
        }

        public IDataResult<List<Todo>> GetAll()
        {
            return new SuccessDataResult<List<Todo>>(_todoDal.GetAll(), TodoMessages.TodosListed);
        }

        public IResult Update(Todo entity)
        {
            _todoDal.Update(entity);
            return new SuccessResult(TodoMessages.TodoUpdated);
        }
    }
}
