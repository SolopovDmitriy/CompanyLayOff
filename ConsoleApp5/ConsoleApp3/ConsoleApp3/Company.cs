using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Company
    {
        private Director _director;
       
        public Company(Director director)//конструктор класса Company
        {
            _director = director;           
        }

        public Director Director1 // Director - класс свойства, Director1 - имя свойства
        {
            get
            {
                //if (_director.Managers.Count == 0)
                //{
                //    return null;
                //}
                return _director;
            }

            set
            {
                if (value != null)
                {
                    _director = value;
                }
            }


        }




      
        public void PrintAllWorkers()
        {
            for (int i = 0; i < _director.Managers.Count; i++)
            {
                IManage manager = _director.Managers[i];
                for (int j = 0; j < manager.Workers.Count; j++)
                {
                    Console.WriteLine(manager.Workers[j]);
                }
            }
        }

        public void PrintAllManagers()
        {
            for (int i = 0; i < _director.Managers.Count; i++)
            {
                IManage manager = _director.Managers[i];
                Console.WriteLine(manager);    
            }
        }


    }
}
