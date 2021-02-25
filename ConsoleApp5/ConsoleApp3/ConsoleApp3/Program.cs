using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Program
    {
        static void TestPoint()
        {
            Point2D point2D = new Point2D();
            Console.WriteLine(++point2D);
            //point2D++;
            //++point2D;
            Console.WriteLine(point2D);
            Console.WriteLine(-point2D);
            Console.WriteLine(point2D);

            Console.WriteLine(point2D + new Point2D(15, 45));

            Console.WriteLine(point2D + 15);
            Console.WriteLine(45 + point2D);

            Point2D point2D1 = new Point2D(15, 15);
            Point2D point2D2 = new Point2D(15, 10);

            Console.WriteLine(point2D1);
            Console.WriteLine(point2D2);

            Console.WriteLine(point2D1.Equals(point2D2));


            if (!point2D1)
            {
                Console.WriteLine("точка в положительном пространстве");
            }
            else
            {
                Console.WriteLine("точка в отрицательном пространстве");
            }


        }


        static void TestWorkers()
        {
            /*Human human = new Human();
           Console.WriteLine(human);
           Console.WriteLine(human.ToString());
           Console.WriteLine(human.genre);
           Console.WriteLine(human.nationality);
           Console.WriteLine(human.Name); //поле: чтение
           human.Name = "Вася";           //поле: запись
           Console.WriteLine(human.Name); 
           Console.WriteLine(human.getName());*/

            try
            {
                //класс абстрактный - нет возможности создать его экземпляр
                //Human human = new Human("Марко", "Поло", "Иммануилович", new DateTime(1775, 10, 25), Genre.MALE, Nationality.English);
                //Employee employee = new Employee();
                //Console.WriteLine(employee);

                /*Tutor tutor = new Tutor();
                Console.WriteLine(tutor);
                tutor.Show();

                Tutor tutor_two = new Tutor("Марко", "Поло", "Иммануилович", new DateTime(1990, 10, 25), Genre.MALE, Nationality.English, 
                                        EducationLevel.Higher, 3500f, TutorSpeciality.Biologist);

                Console.WriteLine(tutor_two);


                Worker worker = new Worker("Марко", "Поло", "Иммануилович", new DateTime(1990, 10, 25), Genre.MALE, Nationality.English,
                                        EducationLevel.Higher, 3500f, "Колоть дрова");

                if (!worker.IsWorking)
                {
                    worker.NextTask("Выпить кофе");
                }
                worker.StopWorking();
                worker.NextTask("Покурить");
                Console.WriteLine(worker.Work());
                worker.StopWorking();
                worker.NextTask("Колоть дрова");
                Console.WriteLine(worker.Work());

                
                Manager manager = new Manager();
                manager.addWorker(worker);
                */

                ListOfWorkers listOfWorkers = new ListOfWorkers();
                for (int i = 0; i < 25; i++)
                {
                    listOfWorkers.AddWorker(
                        new Worker(
                            "worker_" + i,
                            "tested",
                            "tested",
                            DateTime.Now,
                            Genre.UNDEFINED,
                            Nationality.Argentine,
                            EducationLevel.Higher,
                            1555f,
                            "чтото делает и слава богу")
                    );
                }

                /*for (int i = listOfWorkers.Count - 1; i >= 0; i--)
                {
                    listOfWorkers.RemoveWorker(listOfWorkers.Workers[i]);
                }*/

                /*for (int i = 0; i < 25; i++)
                {
                    listOfWorkers.RemoveWorker(listOfWorkers.Workers[0]);
                }*/

                Console.WriteLine(listOfWorkers);

                Console.WriteLine(listOfWorkers.Count);
                Console.WriteLine(listOfWorkers.Workers.Length);



                listOfWorkers[5] = new Worker();
                Console.WriteLine(((Worker)listOfWorkers[5]).Name); //по индексу


                Console.WriteLine(((Worker)listOfWorkers[listOfWorkers.Workers[5]]).Name); //через ссылку на обьект
                listOfWorkers[listOfWorkers.Workers[6]] = new Worker();
                Console.WriteLine(((Worker)listOfWorkers[listOfWorkers.Workers[6]]));
            }

            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Я ошибка, но программа не вылетела :)");
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }
            Console.WriteLine("Я программа и я все одно работаю :)");
        }

        static void TestCompany2()
        {
            Director nachalnyk = new Director();

            nachalnyk.Name = "Petr";
            nachalnyk.Surname = "Petrov";
            nachalnyk.Patronimic = "Petrovitch";
            nachalnyk.Genre = Genre.MALE;
            nachalnyk.nationality = Nationality.Ukrainian;
            nachalnyk.BirthDate = new DateTime(1987, 10, 27);
            nachalnyk.educationLevel = EducationLevel.Higher;
            nachalnyk.Salary = 1203.5f;
            Console.WriteLine("Director: " + nachalnyk);


            Director nachalnyk1 = new Director();

            nachalnyk1.Name = "Vasya";
            nachalnyk1.Surname = "Vasin";
            nachalnyk1.Patronimic = "Igorevitch";
            nachalnyk1.Genre = Genre.MALE;
            nachalnyk1.nationality = Nationality.Ukrainian;
            nachalnyk1.BirthDate = new DateTime(1989, 11, 27);
            nachalnyk1.educationLevel = EducationLevel.Higher;
            nachalnyk1.Salary = 1500.5f;
            Console.WriteLine("Director: " + nachalnyk1);


            Director nachalnyk3 = new Director
            {
                Name = "Katya",
                Surname = "Vasina",
                Patronimic = "Igorevna",
                Genre = Genre.FEMALE,
                nationality = Nationality.Ukrainian,
                BirthDate = new DateTime(1988, 11, 27),
                educationLevel = EducationLevel.Higher,
                Salary = 1600.5f
            };

            Console.WriteLine("Director: " + nachalnyk3);

            Company microsoft = new Company(nachalnyk3);//microsoft.Director1 = nachalnyk3;  _director = nachalnyk3 из класса Company
            Manager manager3 = new Manager
            {
                Name = "Maria",
                Surname = "Vasina",
                Patronimic = "Igorevna",
                Genre = Genre.FEMALE,
                nationality = Nationality.Ukrainian,
                BirthDate = new DateTime(1988, 11, 27),
                educationLevel = EducationLevel.Higher,
                Salary = 1600.5f
            };
            Console.WriteLine("Manager: " + manager3);

            microsoft.Director1.AddManager(manager3);

            Worker worker1 = new Worker
            {
                Name = "Nina",
                Surname = "Kostina",
                Patronimic = "Igorevna",
                Genre = Genre.FEMALE,
                nationality = Nationality.Ukrainian,
                BirthDate = new DateTime(1990, 11, 27),
                educationLevel = EducationLevel.NoEducation,
                WorkDescription = "Уборщица",
                Salary = 20.5f
            };
            Worker worker2 = new Worker
            {
                Name = "Rita",
                Surname = "Kosina",
                Patronimic = "Igorevna",
                Genre = Genre.FEMALE,
                nationality = Nationality.Ukrainian,
                BirthDate = new DateTime(1990, 11, 27),
                educationLevel = EducationLevel.NoEducation,
                WorkDescription = "Гардиробщица",
                Salary = 20.5f
            };

            microsoft.Director1.AddWorker(manager3, worker1);
            //Console.WriteLine("Рабочий: " + worker1);

            //microsoft.Director1.RemoveComandManager(manager3);

            Manager manager4 = new Manager
            {
                Name = "Igor",
                Surname = "Vasin",
                Patronimic = "Igorevitch",
                Genre = Genre.MALE,
                nationality = Nationality.Ukrainian,
                BirthDate = new DateTime(1988, 11, 27),
                educationLevel = EducationLevel.Higher,
                Salary = 600.5f
            };

            Manager manager5 = new Manager
            {
                Name = "Igor",
                Surname = "Gasin",
                Patronimic = "Igorevitch",
                Genre = Genre.MALE,
                nationality = Nationality.Ukrainian,
                BirthDate = new DateTime(1989, 11, 27),
                educationLevel = EducationLevel.Higher,
                Salary = 800.5f
            };

            microsoft.Director1.AddManager(manager5);
            microsoft.Director1.LayOfManager(manager5, manager4);
            Console.WriteLine("All managers: ");
            microsoft.PrintAllManagers();
            microsoft.Director1.AddWorker(manager4, worker2);
            Console.WriteLine("All wokers: " );
            microsoft.PrintAllWorkers();

        }

            static void TestCompany()
        {
           
            Director director = new Director();
            Company company = new Company(director);
            Director directorNew = new Director();

            company.Director1 = directorNew;
            directorNew.Name = "Alex";
            Console.WriteLine("Директор: " + company.Director1);
            Console.WriteLine("директор: " + directorNew);



            IManage manager1 = new Manager();
            director.AddManager(manager1);
            /*Director.Test();*/// статический метод обращаемся к нему через класс (Test() - метод, а Director - класс, нестатический метод (AddManager(manager1)это когда обращаемся к методу через обЪект (director) класса



            for (int i = 0; i < 25; i++)
            {
                IWorker worker = new Worker(
                        "worker_" + i,
                        "for manager 1",
                        "tested",
                        DateTime.Now,
                        Genre.UNDEFINED,
                        Nationality.Argentine,
                        EducationLevel.Higher,
                        1555f,
                        "чтото делает и слава богу");
                // 1 version
                director.AddWorker(manager1, worker);
                //// 2 version
                //ListOfWorkers workers1 = manager1.Workers;
                //workers1.AddWorker(worker);
                //// 3 version
                //manager1.Workers.AddWorker(worker);                
            }


            IManage manager2 = new Manager();
            director.AddManager(manager2);
            for (int i = 0; i < 15; i++)
            {
                IWorker worker = new Worker(
                        "worker_" + i,
                         "for manager 2",
                        "tested",
                        DateTime.Now,
                        Genre.UNDEFINED,
                        Nationality.Argentine,
                        EducationLevel.Higher,
                        2555f,
                        "чтото делает и слава богу");
                director.AddWorker(manager2, worker);                           
            }

            IManage manager5 = new Manager(
                        "Иван",
                        "Иванов",
                        "Иванович",
                        new DateTime(1980, 11, 5),
                        Genre.MALE,
                        Nationality.Argentine,
                        EducationLevel.Higher,
                        2555f) ;

            director.AddManager(manager5);
            director.AddManager(manager5);  // SET
            for (int i = 0; i < 8; i++)
            {
                IWorker worker = new Worker(
                        "worker_" + i,
                         "for manager 5",
                        "tested",
                        DateTime.Now,
                        Genre.UNDEFINED,
                        Nationality.Argentine,
                        EducationLevel.Higher,
                        2555f,
                        "Копает картошку");
                director.AddWorker(manager5, worker);
            }
            IManage manager6 = new Manager(
                        "Петр",
                        "Петров",
                        "Петрович",
                        new DateTime(1980, 11, 6),
                        Genre.MALE,
                        Nationality.Argentine,
                        EducationLevel.Higher,
                        2555f);

            director.AddManager(manager6);
           
            director.AddManager(manager6);
            IManage manager7 = new Manager(
                      "Петр1",
                      "Петров1",
                      "Петрович1",
                      new DateTime(1980, 11, 6),
                      Genre.MALE,
                      Nationality.Argentine,
                      EducationLevel.Higher,
                      2555f);

            IManage manager8 = new Manager(
                   "Петр2",
                   "Петров1",
                   "Петрович1",
                   new DateTime(1980, 11, 6),
                   Genre.MALE,
                   Nationality.Argentine,
                   EducationLevel.Higher,
                   2555f);
            director.AddManager(manager7);
            director.AddManager(manager7);
            director.LayOfManager(manager7, manager8);
            director.RemoveComandManager(manager8);
            manager5.Workers[1].StopWorking();
            director.PushWork("собирать дрова10");

            company.PrintAllWorkers();

            manager2.Workers[1].StopWorking();
            director.PushWork("собирать дрова");
            director.RemoveComandManager(manager6);

            Manager newManager = new Manager();            
            director.LayOfManager(manager1, newManager);

            // Console.WriteLine(manager5.Workers.Count);
            // company.PrintAllWorkers();

            company.PrintAllManagers();


        }


        static void Main(string[] args)// это статический  метод Main(string[] args) - точка входа
        {
            // TestPoint();
            // TestWorkers();
            //TestCompany();
            TestCompany2();
            Console.ReadKey();
        }
    }
}
