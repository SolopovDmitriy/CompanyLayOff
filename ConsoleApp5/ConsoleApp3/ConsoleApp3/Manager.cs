using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Manager : Employee, IManage
    {
        private ListOfWorkers _workers; //список рабочих текущего экземпляра менеджера

        public Manager(string name, string surname, string patronimic, DateTime birthDate, Genre genre, Nationality nationality, EducationLevel education, float salary)
           : base(name, surname, patronimic, birthDate, genre, nationality, education, salary)
        {
            _workers = new ListOfWorkers();
        }

        public Manager()
        {
            _workers = new ListOfWorkers();
        }


        public ListOfWorkers Workers
        { //поле получения доступа к рабочим текущего менеджера
            get
            {
                return _workers;
            }
        }

        public IWorker GetWorker(int index)
        {
            return _workers[index];
        }

        public IWorker GetWorker(string workDescription)
        {
            for (int i = 0; i <= _workers.Count; i++)
            {
                if (_workers[i].Work() == workDescription)
                {
                    return _workers[i];
                }
            }
            return null;
        }

        public bool PushWork(string task)
        {
            for (int i = 0; i < _workers.Count; i++)
            {
                if (_workers[i].IsWorking == false)
                {
                    _workers[i].NextTask(task);
                    return true;
                }
            }
            return false;
        }
      







        public void Control()
        {
            throw new NotImplementedException();
        }

        public void Organize()
        {
            throw new NotImplementedException();
        }
    }
}
