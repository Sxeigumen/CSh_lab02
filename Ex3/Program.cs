using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        public class DocumentWorker
        {
            public virtual void OpenDocument()
            {
                Console.WriteLine("Документ открыт!");
            }

            public virtual void EditDocument()
            {
                Console.WriteLine("!!!Редактирование документа доступно в версии Pro!!!");
            }

            public virtual void SaveDocument()
            {
                Console.WriteLine("!!!Сохранение документа доступно в версии Pro!!!");
            }
        }

        public class ProDocumentWorker : DocumentWorker
        {
            public override void EditDocument()
            {
                Console.WriteLine("Документ отредактирован!");
            }

            public override void SaveDocument()
            {
                Console.WriteLine("!!!Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Expert!!!");
            }
        }

        public class ExpertDocumentWorker : ProDocumentWorker
        {
            public override void SaveDocument()
            {
                Console.WriteLine("Документ сохранен в новом формате!");
            }
        }

        static void Main(string[] args)
        {
            string workMode = "";

            Console.WriteLine("Введите ключ активации, если ключа нет просто нажмите enter - ");
            string key = Console.ReadLine();
            switch (key)
            {
                case "123321":
                    workMode = "pro";
                    Console.WriteLine("Верный ключ - версия Pro");
                    break;
                case "456654":
                    workMode = "exp";
                    Console.WriteLine("Верный ключ - версия Expert");
                    break;
                default:
                    Console.WriteLine("Некорректный ключ или ключ не введён, версия программы - Default.");
                    break;
            }

            if(workMode == "")
            {
                DocumentWorker DocApp = new DocumentWorker();
                string mode = "";
                
                while(mode != "s")
                {
                    Console.WriteLine("Выбирете режим работы:");
                    Console.WriteLine("1 - Открыть документ");
                    Console.WriteLine("2 - Редактировать документ");
                    Console.WriteLine("3 - Созранить документ");
                    Console.WriteLine("s - Выйти");

                    mode = Console.ReadLine();
                    Console.WriteLine("\n");

                    if (mode == "s")
                    {
                        break;
                    }

                    switch (mode)
                    {
                        case "1":
                            DocApp.OpenDocument();
                            break;
                        case "2":
                            DocApp.EditDocument();
                            break;
                        case "3":
                            DocApp.SaveDocument();
                            break;
                    }
                }
            }
            else if(workMode == "pro")
            {
                ProDocumentWorker DocApp = new ProDocumentWorker();
                string mode = "";

                while (mode != "s")
                {
                    Console.WriteLine("Выбирете режим работы:");
                    Console.WriteLine("1 - Открыть документ");
                    Console.WriteLine("2 - Редактировать документ");
                    Console.WriteLine("3 - Созранить документ");
                    Console.WriteLine("s - Выйти");

                    mode = Console.ReadLine();
                    Console.WriteLine("\n");

                    if (mode == "s")
                    {
                        break;
                    }

                    switch (mode)
                    {
                        case "1":
                            DocApp.OpenDocument();
                            break;
                        case "2":
                            DocApp.EditDocument();
                            break;
                        case "3":
                            DocApp.SaveDocument();
                            break;
                    }
                }
            }
            else if (workMode == "exp")
            {
                ExpertDocumentWorker DocApp = new ExpertDocumentWorker();
                string mode = "";

                while (mode != "s")
                {
                    Console.WriteLine("Выбирете режим работы:");
                    Console.WriteLine("1 - Открыть документ");
                    Console.WriteLine("2 - Редактировать документ");
                    Console.WriteLine("3 - Созранить документ");
                    Console.WriteLine("s - Выйти");

                    mode = Console.ReadLine();
                    Console.WriteLine("\n");

                    if (mode == "s")
                    {
                        break;
                    }

                    switch (mode)
                    {
                        case "1":
                            DocApp.OpenDocument();
                            break;
                        case "2":
                            DocApp.EditDocument();
                            break;
                        case "3":
                            DocApp.SaveDocument();
                            break;
                    }
                }
            }
        }
    }
}
