using StudentNamespace;
using ReaderNamespace;

internal class Program
{
    private static void Main(string[] args)
    {
        Student[] students = { new Student("Слейвов", "С.Н.", "прикольная", 29), new Student("Хахов", "П.А.", "прикольная", 23), new Student("фамилия", "Ха.ха", "не прикольная", 123) };
        Reader[] readers = { new Reader("Коков Е.Г.", 42, "Факультет", "05.06.1991", "974882482"), new Reader("Нет Е.Г.", 54, "Факультет", "05.06.1945", "972482"), new Reader("Ненов Ж.Г.", 78, "Факультет", "01.01.1998", "9764362") };
    }
}
namespace StudentNamespace
{
    class Student
    {
        string surname;

        string initials;

        string group;

        private int age;

        public Student(string surname, string initials, string group, int age)
        {
            this.surname = surname;
            this.initials = initials;
            this.group = group;
            this.age = age;
        }

        public void print()
        {
            Console.WriteLine($"{surname} {initials} группа: {group} возраст: {age}");
        }
    }
}
namespace ReaderNamespace
{
    class Reader
    {
        private string fullName;
        int readerTicketId;
        string faculty;
        private string birthday;
        string phoneNumer;

        public Reader(string fullName, int readerTicketId, string faculty, string birthday, string phoneNumer)
        {
            this.fullName = fullName;
            this.readerTicketId = readerTicketId;
            this.faculty = faculty;
            this.birthday = birthday;
            this.phoneNumer = phoneNumer;
        }

        public void takeBook(int number) {
            Console.WriteLine($"{fullName} взял {number} книги");
        }
        public void takeBook(string books)
        {
            Console.WriteLine($"{fullName} взял книги: {books}");
        }
        public void returnBook(int number)
        {
            Console.WriteLine($"{fullName} вернул {number} книги");
        }
        public void returnBook(string books)
        {
            Console.WriteLine($"{fullName} вернул книги: {books}");
        }


    }
}
