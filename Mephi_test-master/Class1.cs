using System;
using System.Collections.Generic;
using System.Text;

namespace MEPHI_TEST
{

    // Создаем класс книга
    // выходные данные книги(автор, название, издательство)
    // раздел библиотеки(спец.литература, беллетристика)
    // наличие книги в данный момент
    // субъективная оценка

    class book
    {
        public book()
        {
        }

        public book(int count, string author, string name, string izdatelstvo, string razdel, string nalichie, string sostoinie)
        {
            Count = count;
            Author = author;
            Name = name;
            Izdatelstvo = izdatelstvo;
            Razdel = razdel;
            Nalichie = nalichie;
            Sostoinie = sostoinie;
        }

        public int Count { get; set; }
        public string Author { get; set; }
        public string Name { get; set; }
        public string Izdatelstvo { get; set; }
        public string Razdel { get; set; }
        public string Nalichie { get; set; }
        public string Sostoinie { get; set; }
    }
}
