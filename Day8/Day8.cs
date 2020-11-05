using System;

namespace Day8
{
    class Day8
    {
        static void Main(string[] args)
        {
            // int[] intArray = { 2, 43, 6, 3, 1, -6, 4 };
            // Console.WriteLine(String.Join(", ", intArray));
            // Console.WriteLine(String.Join(", ", Task1.GetOnlySmallValues(intArray)));

            Console.WriteLine(PasswordValidator.ValidatePassword("1234"));
            Console.WriteLine(PasswordValidator.ValidatePassword("1234658"));
            Console.WriteLine(PasswordValidator.ValidatePassword("A145289672872"));

        }


    }
}
