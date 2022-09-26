
using System;
using System.Collections.Generic;

List<Book> listBooks = new List<Book>();

do
{
    Console.WriteLine("               Ваш Список книг для прочтения!\n\n");
    Console.WriteLine("               Выберите дальнешее действие\n");
    Console.WriteLine("  1 - Добавить книгу в список      2 - Вывести список книг\n\n  3 - Удалить книгу из списка      4 - Найти книгу в списке\n                             5 - Выход");
    string choise = Console.ReadLine();
    if (choise == "1")
    {
        Console.Clear();
        Console.WriteLine("   Добавление книги в список\n\n");
        listBooks.Add(new Book());
    }
    if (choise == "2")
    {
        Console.WriteLine("  Ваш список книг\n\n");
        if (listBooks.Count == 0)
        {
            Console.WriteLine("У вас нет книг в списке");
        }
        else
        {
            foreach(Book book in listBooks)
            {
                Console.WriteLine(book);
            }
        }

        Console.WriteLine("Нажмите любую кнопку... ");
        Console.ReadKey();
    }

    if(choise == "3")
    {
        if (listBooks.Count == 0)
        {
            Console.WriteLine("У вас нет книг в списке");
        }

        Console.WriteLine("   Удаление книг из списка");
        Console.WriteLine("Что вам известно о книге 1-название, 2-автор,3-год издания,4-жанр");
        
    }

    Console.Clear();

} while (true);



class Book
{
    public string _Title { get; set; }
    public string _Author { get; set; }
    public string _Date { get; set; }
    public string _Genre { get; set; }
    public Book()
    {
        Console.WriteLine("Введите название книги");
        _Title = Console.ReadLine();
        Console.WriteLine("Введите автора книги");
        _Author = Console.ReadLine();
        Console.WriteLine("Введите год написания книги");
        _Date = Console.ReadLine();
        Console.WriteLine("Введите жанр книги");
        _Genre = Console.ReadLine();
    }

    public override string ToString()
    {
        return $" Название книги {_Title} \n Автор книги {_Author} \n Дата издания {_Date} \n Жанр книги {_Genre}";
    }

    public IEnumerator<string> GetEnumerator()
    {
        yield return ToString();
    }
}
