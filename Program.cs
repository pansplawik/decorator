using System;

namespace wzorce
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("kamil", "splawinski", 4, "INZ BIOM", "Politechnika Śląska", "Silesia");
            student.Beer();
            student.DiscountStudents();
            student.Introduce();

        }
    }
}
