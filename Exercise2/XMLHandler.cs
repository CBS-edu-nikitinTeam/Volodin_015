using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class XMLHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("Изменение документа в формате .xml");
        }

        public override void Create()
        {
            Console.WriteLine("Создание документа в формате .xml");
        }

        public override void Open()
        {
            Console.WriteLine("Открытие документа в формате .xml");
        }

        public override void Save()
        {
            Console.WriteLine("Сохранение документа в формате .xml");
        }
    }
}
