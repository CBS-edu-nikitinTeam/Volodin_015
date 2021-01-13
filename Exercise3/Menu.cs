using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class Menu
    {
        public static void Show()
        {
            Console.WriteLine("Выберите действие с проигрывателем:");
            Console.WriteLine("0 - Проиграть музыку");
            Console.WriteLine("1 - Выполнить запись");
            string answer = Console.ReadLine();
            Player player = new Player();
            switch (answer)
            {
                case "0":
                    PlayMenu.Show(player);
                    break;
                case "1":
                    RecordMenu.Show(player);
                    break;
                default:
                    Console.WriteLine("Выбрано некорректное действие...");
                    break;
            }
        }

        private static class PlayMenu
        {
            public static void Show(IPlayable player)
            {
                string answer = String.Empty;
                do
                {
                    Console.WriteLine("Выберите действие с проигрыванием:");
                    Console.WriteLine("0 - Выход");
                    Console.WriteLine("1 - Проиграть музыку");
                    Console.WriteLine("2 - Приостановить музыку");
                    Console.WriteLine("3 - Остановить музыку");

                    answer = Console.ReadLine();
                    Console.WriteLine("\n");

                    switch (answer)
                    {
                        case "0":
                            Console.WriteLine("Выполняем выход...");
                            break;
                        case "1":
                            player.Play();
                            break;
                        case "2":
                            player.Pause();
                            break;
                        case "3":
                            player.Stop();
                            break;
                        default:
                            Console.WriteLine("Некорректное действие, попробуйте еще раз...");
                            break;
                    }
                    Console.WriteLine("\n");

                } while (answer != "0");
            }
        }

        private static class RecordMenu
        {
            public static void Show(IRecodable player)
            {
                string answer = String.Empty;
                do
                {
                    Console.WriteLine("Выберите действие с записью:");
                    Console.WriteLine("0 - Выход");
                    Console.WriteLine("1 - Выполнить запись");
                    Console.WriteLine("2 - Приостановить запись");
                    Console.WriteLine("3 - Остановить запись");

                    answer = Console.ReadLine();
                    Console.WriteLine("\n");

                    switch (answer)
                    {
                        case "0":
                            Console.WriteLine("Выполняем выход...");
                            break;
                        case "1":
                            player.Record();
                            break;
                        case "2":
                            player.Pause();
                            break;
                        case "3":
                            player.Stop();
                            break;
                        default:
                            Console.WriteLine("Некорректное действие, попробуйте еще раз...");
                            break;
                    }
                    Console.WriteLine("\n");

                } while (answer != "0");
            }
        }
    }
}
