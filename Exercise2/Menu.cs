using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class Menu
    {
        public static void Show()
        {
            Console.WriteLine("Введите формат документа для работы (txt, doc, xml)");
            string answer = Console.ReadLine();
            AbstractHandler documentHelper = DocumentHandlerFactory.CreateInstance(answer);

            if (documentHelper == null)
            {
                Console.WriteLine("Выбран некорректный формат...");
                return;
            }


            do
            {
                Console.WriteLine("Выберите действие с документом:");
                Console.WriteLine("0 - Выход");
                Console.WriteLine("1 - Создание");
                Console.WriteLine("2 - Открытие");
                Console.WriteLine("3 - Изменение");
                Console.WriteLine("4 - Сохранение");
                answer = Console.ReadLine();
                Console.WriteLine("\n");

                switch (answer)
                {
                    case "0":
                        Console.WriteLine("Выполняется выход...");
                        break;
                    case "1":
                        documentHelper.Create();
                        break;
                    case "2":
                        documentHelper.Open();
                        break;
                    case "3":
                        documentHelper.Change();
                        break;
                    case "4":
                        documentHelper.Save();
                        break;
                    default:
                        Console.WriteLine("Вы ввели некорректное действие, попробуйте еще раз...");
                        break;
                }
                Console.WriteLine("\n");
            } while (answer != "0");
        }
    }
}
