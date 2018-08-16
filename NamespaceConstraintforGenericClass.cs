using System;
using System.Collections.Generic;
using System.Text;


public interface IBook
{
    string Name { get; set; }
    string Author { get; set; }
    uint Sheets { get; set; }
    string TypeOfBook { get; set; }
    
}
    public class PdfBook:IBook
{
     public string Name { get; set; }
     public string Author { get; set; }
     public uint Sheets { get; set; }
     public string TypeOfBook { get; set; }
     
    public PdfBook(string Name,string Author, uint Sheets)
    {
        this.Name = Name;
        this.Author = Author;
        this.Sheets = Sheets;
        TypeOfBook = "Pdf Book(pdf file)";
    }
}
public class PubBook:IBook
{
    public string Name { get; set; }
    public string Author { get; set; }
    public uint Sheets { get; set; }
    public string TypeOfBook { get; set; }
    public PubBook(string Name, string Author, uint Sheets)
    {
        this.Name = Name;
        this.Author = Author;
        this.Sheets = Sheets;
        TypeOfBook = "Pub Book(pub file)";
    }
}
    class Program
    {
   
        static void Main(string[] args)
        {
        Console.OutputEncoding = Encoding.Unicode;
        //pdf book list
        
        GenClass<PdfBook> MyPdfBookList = new GenClass<PdfBook>(5);
        MyPdfBookList.AddBook(new PdfBook("The Comple Referance C#","Herbert Schildt",950));
        MyPdfBookList.AddBook(new PdfBook("test","test1",33));
        MyPdfBookList.ShowBookList();
        MyPdfBookList.FindBookByNameOrAuthor("test");
        // pubbook list
        GenClass<PubBook> MyPubBookList = new GenClass<PubBook>(4);
        MyPdfBookList.AddBook(new PdfBook("The Comple Referance C++","Herbert Schildt",1022));
        MyPubBookList.ShowBookList();
         Console.ReadKey();
        }

    }
    

class GenClass<T> where T:IBook
{
    T[] BookList;
    bool EndList,BeginList;
    public static uint TotalCountOfBook;
    public static uint CurrCountOfBook;
   
    public GenClass(uint TotalCountOfBook)
    {
        BookList = new T[TotalCountOfBook];
        GenClass<T>.TotalCountOfBook = TotalCountOfBook;
        BeginList = true;
    }
    public bool AddBook(T Book)
    {
        if (!EndList)
        {
            BookList[CurrCountOfBook++] = Book;
            if (CurrCountOfBook == TotalCountOfBook)
            EndList = true;
            BeginList = false;
            return true;
        }
        else
        {
            return false;
        }
    }

    //find
    public T FindBookByNameOrAuthor(string BookName=null,string BookAuthor=null)
    {

        //var Result = from  search in BookList where BookName == search.Name  select ;
        if (BeginList)
        {
            Console.WriteLine("BookList is Empty");
            return default(T);
        }
        for(uint i = 0; i<CurrCountOfBook; i++)
        {
            if (BookName == BookList[i].Name || BookAuthor == BookList[i].Author)
            {
                ShowBookItem(BookList[i]);
                return BookList[i];
            }
            
        }
        Console.WriteLine("Book dont find");
        return default(T);
    }
    public void ShowBookList()
    {
       

        if (BeginList || CurrCountOfBook == 0)
            Console.WriteLine("BookList is empty ;(");
        else
        {
            Console.WriteLine("Book name\t\t\tAuthor\t\t\tSheets\t\t\tType of Book");

            for (uint i = 0; i < CurrCountOfBook; i++)
            {
                Console.WriteLine($"{BookList[i].Name}\t\t\t{BookList[i].Author}\t\t\t{BookList[i].Sheets}\t\t\t{BookList[i].TypeOfBook}");
            }
        }
    }
     void ShowBookItem(T Book)
    {
        Console.WriteLine("\n\n***Book finded***");
        Console.WriteLine("Book name\t\t\tAuthor\t\t\tSheets\t\t\tType of Book");
        Console.WriteLine($"{Book.Name}\t\t\t{Book.Author}\t\t\t{Book.Sheets}\t\t\t{Book.TypeOfBook}");
    }
}
