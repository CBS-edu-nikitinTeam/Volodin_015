using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class DocumentHandlerFactory
    {
        public static AbstractHandler CreateInstance(string documentFormat)
        {
            return (documentFormat.ToLower()) switch
            {
                "doc" => new DOCHandler(),
                "txt" => new TXTHandler(),
                "xml" => new XMLHandler(),
                _ => null,
            };
        }
    }
}
