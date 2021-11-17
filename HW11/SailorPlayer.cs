using System;
using System.Collections.Generic;  //доступ к объектам памяти при условии что тип объекта реализует интерфейс   
using System.Text; //вмещает классы, дополнительные базы классов и вспомогательные классы

namespace HW11
{
    class SailorPlayer
    {
        public string Name { get; set; } //вседоступный параметр

        public int[,] SeaField { get; set; } //определяет неизменяемую структуру (свойства доступны только для чтения)

        public SailorPlayer(string name)
        {
            Name = name;
        }
    }
}
