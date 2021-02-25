using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Director : Employee 
    {
        ListOfManagers _managers;
        //public static void Test () //внутри статического метода можно вызывать только статический метод
        //{
        //    Console.WriteLine(Math.Sqrt(4));
        //    Test2();
        //    //AddManager(null); //AddManager(null)-нестатический метод
        //}

        //public static void Test2() //внутри статического метода можно вызывать только статический метод
        //{
        //    Console.WriteLine(Math.Sqrt(9));

        //}

        public Director()
        {
            _managers = new ListOfManagers();

        }

        public ListOfManagers Managers { 
            get
            {
                return _managers;
            } 
        }


        public void AddManager(IManage manager)
        {
            _managers.AddManager(manager);
        }

        public void AddWorker(IManage manager, IWorker worker)
        {
            // if (!Contains(manager)) cw("Error");
            manager.Workers.AddWorker(worker);
        }

        public bool PushWork(string task)
        {
            for (int i = 0; i < Managers.Count; i++)
            {
                IManage manager = Managers[i];
                if (manager.PushWork(task))
                {
                    return true;
                }
            }
            return false;
        }

        public void LayOfManager(IManage managerLayOf, IManage managerNew)
        {
            
            for (int i = managerLayOf.Workers.Count - 1; i >=0 ; i--)
            {              
                IWorker worker = managerLayOf.Workers[i];
                managerNew.Workers.AddWorker(worker);
                managerLayOf.Workers.RemoveWorker(worker);

            }
            _managers.RemoveManager(managerLayOf);
            _managers.AddManager(managerNew);            
        }
        public void RemoveComandManager(IManage managerRemove)
        {  
            _managers.RemoveManager(managerRemove);            
        }

    }
}
