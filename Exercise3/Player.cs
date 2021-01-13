using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class Player : IPlayable, IRecodable
    {
        void IPlayable.Pause()
        {
            Console.WriteLine("Проигрывание музыки приостановлено");
        }

        void IRecodable.Pause()
        {
            Console.WriteLine("Запись приостановлена");
        }

        public void Play()
        {
            Console.WriteLine("Выполняется проигрывание музыки");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Проигрывание музыки остановлено");
        }

        void IRecodable.Stop()
        {
            Console.WriteLine("Запись остановлена");
        }

        public void Record()
        {
            Console.WriteLine("Выполняется запись");
        }
    }
}
