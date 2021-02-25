using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    interface IManage
    {
        void Control();
        void Organize();

        ListOfWorkers Workers { get; } //дать возможность получить доступ к сотрудникам

        bool PushWork(string task);


        string Surname
        {
            get; set;
        }

        string Patronimic
        {
            get; set;
        }

        string Name
        {
            get; set;
        }

    }
}
