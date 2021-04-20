using System;
using System.Collections.Generic;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MEPHI_TEST
{

    // Бибилиотека 
    // Картотека должна позволять:
    // Вывод книг по произвольному запросу (по автору, разделу, наличию)
    // Редактирование записи(изменение параметров)
    // Добавление/ удаление книги
    // Загрузка/сохранение картотеки в файл


    class Program
    {


        static void Main()
        {
            List<book> biblioteka = new List<book>();
            int Count = 5;

            biblioteka.Add(new book(1, "Л.Н.Толстой", "Война и мир 1 том", "Издательство АСТ", "Классическая проза", "Да", "Хорошее"));
            biblioteka.Add(new book(2, "Л.Н.Толстой", "Война и мир 2 том", "Издательство АСТ", "Классическая проза", "Да", "Хорошее"));
            biblioteka.Add(new book(3, "Л.Н.Толстой", "Война и мир 2 том", "Издательство АСТ", "Классическая проза", "Да", "Хорошее"));
            biblioteka.Add(new book(4, "Л.Н.Толстой", "Анна Каренина", "Издательство АСТ", "Драма", "Да", "Хорошее"));


            while (true)
            {
                Console.WriteLine("Библиотека");
                Console.WriteLine("1 Вывод книг");
                Console.WriteLine("2 Редактирование книги");
                Console.WriteLine("3 Добавление книги");
                Console.WriteLine("4 Удаление книги");
                Console.WriteLine("5 Выгрузка всех книг в файл");
                Console.WriteLine("6 Загрузка книг из файла");

                int chose = Convert.ToInt32(Console.ReadLine()); ;


                if (chose == 3)
                {

                    Console.WriteLine("Автор");
                    string Author = Convert.ToString(Console.ReadLine());
                    // Console.WriteLine(Author);
                    Console.WriteLine("Название");
                    string Name = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Издательство");
                    string Izdatelstvo = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Раздел");
                    string Razdel = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Наличие");
                    string Nalichie = Convert.ToString(Console.ReadLine());
                        if (Nalichie =="Да" | Nalichie =="Нет")
                        {

                        }
                        else
                        {
                            Console.WriteLine("Введите повторно наличие");
                            Nalichie = Convert.ToString(Console.ReadLine());
                    }

                    Console.WriteLine("Состояние");
                    string Sostoinie = Convert.ToString(Console.ReadLine());

                    biblioteka.Add(new book() { Count = Count, Author = Author, Name = Name, Izdatelstvo = Izdatelstvo, Razdel = Razdel, Nalichie = Nalichie, Sostoinie = Sostoinie });
                    Count = Count + 1;

                }
                else if (chose == 1)
                {
                    Console.WriteLine("Выберите пунк меню");
                    Console.WriteLine("1 Весь список");
                    Console.WriteLine("2 По автору");
                    Console.WriteLine("3 По разделу");
                    Console.WriteLine("4 По наличию");

                    int chosebook = Convert.ToInt32(Console.ReadLine());

                    if (chosebook == 1)
                    {
                        foreach (book b in biblioteka)
                            Console.WriteLine("Номер:" + b.Count + " Автор:" + b.Author + " Книга:" + b.Name + " Раздел:" + b.Razdel + " Издательство:" + b.Izdatelstvo + " Наличие:" + b.Nalichie + " Состояние:" + b.Sostoinie);
                        Console.WriteLine("Ожидается нажатие клавиатуры");
                        Console.ReadLine();
                    }

                    if (chosebook == 2)
                    {
                        Console.WriteLine("Введите автора");
                        string author = Convert.ToString(Console.ReadLine());
                       // Console.WriteLine("\r\n");

                        foreach (book b in biblioteka)
                            if (b.Author == author)
                            {
                            Console.WriteLine("Номер:" + b.Count + " Автор:" + b.Author + " Книга:" + b.Name + " Раздел:" + b.Razdel + " Издательство:" + b.Izdatelstvo + " Наличие:" + b.Nalichie + " Состояние:" + b.Sostoinie);
                            }
                            else
                            {
                                Console.WriteLine("Такого автора нет "+ " \r\n");
                                break;
                            }
                    }

                    if (chosebook == 3)
                    {
                        Console.WriteLine("Введите раздел");
                        string Razdel = Convert.ToString(Console.ReadLine());
                        // Console.WriteLine("\r\n");

                        foreach (book b in biblioteka)
                            if (b.Razdel == Razdel)
                            {
                                Console.WriteLine("Номер:" + b.Count + " Автор:" + b.Author + " Книга:" + b.Name + " Раздел:" + b.Razdel + " Издательство:" + b.Izdatelstvo + " Наличие:" + b.Nalichie + " Состояние:" + b.Sostoinie);
                            }
                            
                    }

                    if (chosebook == 4)
                    {
                        Console.WriteLine("Введите наличие (Да или Нет)");
                        string Nalichie = Convert.ToString(Console.ReadLine());
                        // Console.WriteLine("\r\n");

                        foreach (book b in biblioteka)
                            if (b.Nalichie == Nalichie)
                            {
                                Console.WriteLine("Номер:" + b.Count + " Автор:" + b.Author + " Книга:" + b.Name + " Раздел:" + b.Razdel + " Издательство:" + b.Izdatelstvo + " Наличие:" + b.Nalichie + " Состояние:" + b.Sostoinie);
                            }
                            else
                            {
                                Console.WriteLine("Ошибка ввода" + " \r\n");
                                break;
                            }
                    }

                   

                }

                else if (chose == 5)
                {
                    // FileStream file1 = new FileStream("F:\\file3.txt", FileMode.Append);
                    // FileStream file1 = new FileStream("F:\\new_file.txt", FileAccess.Write); //создаем файловый поток

                    foreach (book b in biblioteka)
                        //Writer(b, file1);
                        File.AppendAllText("F:\\new_file.txt", "Номер:" + b.Count + " Книга:" + b.Name + " Раздел:" + b.Razdel + " Издательство:" + b.Izdatelstvo + " Наличие:" + b.Nalichie + " Состояние:" + b.Sostoinie + " \r\n");
                    Console.Write("Данные успешно записаны в файл F:\\new_file.txt" + " \r\n");


                }

                else if (chose == 4)
                {
                    Console.WriteLine("Введите номер записи");
                    int zapis = Convert.ToInt16(Console.ReadLine());
                    zapis = zapis-1;
                    biblioteka.RemoveAt(zapis);
                }

                else if (chose == 2)
                {
                    Console.WriteLine("Весь список");
                    foreach (book b in biblioteka)
                        Console.WriteLine("Номер:" + b.Count + " Книга:" + b.Name + " Раздел:" + b.Razdel + " Издательство:" + b.Izdatelstvo + " Наличие:" + b.Nalichie + " Состояние:" + b.Sostoinie);

                    Console.Write("Выберите порядковый номер");
                    int pointer = Convert.ToInt16(Console.ReadLine());
                    pointer = pointer - 1;


                    Console.WriteLine("Номер:" + biblioteka[pointer].Count + " Книга:" + biblioteka[pointer].Name + " Раздел:" + biblioteka[pointer].Razdel + " Издательство:" + biblioteka[pointer].Izdatelstvo + " Наличие:" + biblioteka[pointer].Nalichie + " Состояние:" + biblioteka[pointer].Sostoinie);
                    Console.Write("Какой пункт хотите исправить ");
                    string razdel = Convert.ToString(Console.ReadLine()); ;

                    if (razdel == "Книга")
                    {
                        Console.Write("Новое имя = ");
                        string newname = Convert.ToString(Console.ReadLine());
                        biblioteka[pointer].Name = newname;
                    }

                    else if (razdel == "Раздел")
                    {
                        Console.Write("Новое имя = ");
                        string newname = Convert.ToString(Console.ReadLine());
                        biblioteka[pointer].Razdel = newname;
                    }



                    else if (razdel == "Издательство")
                    {
                        Console.Write("Новое имя = ");
                        string newname = Convert.ToString(Console.ReadLine());
                        biblioteka[pointer].Izdatelstvo = newname;
                    }

                    else if (razdel == "Наличие")
                    {
                        Console.Write("Новое имя = ");
                        string newname = Convert.ToString(Console.ReadLine());
                        biblioteka[pointer].Nalichie = newname;
                    }

                    else if (razdel == "Состояние")
                    {
                        Console.Write("Новое имя = ");
                        string newname = Convert.ToString(Console.ReadLine());
                        biblioteka[pointer].Sostoinie = newname;
                    }


                    //Console.WriteLine(chose);

                    //biblioteka[0].Author = "22";
                    //biblioteka[0].Name = "22";
                    //biblioteka[0].Izdatelstvo = "22";
                    //biblioteka[0].Razdel = "22";
                    //biblioteka[0].Nalichie = "22";
                    // biblioteka[0].Sostoinie = "22";
                }
            }
        }

        //public static void Writer(book b, FileStream file1)

        //   {
        // StreamWriter writer = new StreamWriter(file1);
        //     //создаем «потоковый писатель» и связываем его с файловым потоком
        //  writer.Write("Книга:" + b.Name + " Раздел:" + b.Razdel + " Издательство:" + b.Izdatelstvo + " Наличие:" + b.Nalichie + " Состояние:" + b.Sostoinie); //записываем в файл
        //    writer.Close(); //закрываем поток. Не закрыв поток, в файл ничего не запишется
        //  }
    }
}