using System;

namespace Week2Lesson4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Week2 Lesson4");

            // Exercise#1
            /*  Stwórz program, w którym zadeklarujesz zmienne dotyczące danych pracownika firmy. Dane
                    które chcesz przetrzymywać to:
                    a. Imię,
                    b. Nazwisko
                    c. Wiek
                    d. Płeć (‘m’ albo ‘k’)
                    e. PESEL
                    f. Numer pracownika (np. 2509324094)
                Zadeklaruj zmienne odpowiednich typów, które mogą przetrzymywać te informacje
            */

            string name = "Jan";
            string surename = "Kowalski";
            int age = 35;
            char gender = 'M'; // M or F
            string PESEL = "01234567890";
            uint employeeNumber = 2509324094;


            // Exercise#2
            /*  Napisz program, w którym stworzysz 3 zmienne z jedną literą, a następnie wypiszesz je w
                odwrotnej kolejności niż zostały zadeklarowane.
            */
            char i = 'A';
            char j = 'B';
            char k = 'C';
            Console.WriteLine("");
            Console.WriteLine("Exercise#2");
            Console.WriteLine(k);
            Console.WriteLine(j);
            Console.WriteLine(i);

            //Exercise#3
            /*  Napisz program, który na podstawie podanej szerokości i długości prostokąta wyliczy długość
                przekątnej. (Aby, obliczyć kwadrat liczby użyj metody Math.Pow())
            */
            Console.WriteLine("");
            Console.WriteLine("Exercise#3");
            Console.WriteLine("Please enter 1st value 'a':");
            var a = Console.ReadLine();
            double val1 = Convert.ToDouble(a);
            Console.WriteLine("Please enter 2nd value 'b':");
            var b = Console.ReadLine();
            double val2 = Convert.ToDouble(b);
            double c = Math.Sqrt(Math.Pow(val1, 2) + Math.Pow(val2, 2));
            Console.WriteLine($"Total: {c}");

            //Exercise#4
            /*  Napisz program w którym stworzysz 2 zmienne liczbowe, oraz jedną tekstową, a następnie
                przypiszesz im następujące wartości:
                    a. 10
                    b. Szkoła Dotneta
                    c. 12,5
                Pamiętaj o użyciu poprawnych typów danych.
            */
            int numVar1 = 10;
            string textVar = "Szkoła Dotneta";
            double numVar2;
            numVar2 = 12.5;

            //Exercise#5
            /* Napisz program w którym poprosisz użytkownika o jego dane personalne tj. Imię, nazwisko,
               numer telefonu, adres email, wzrost, waga(np. 85, 7), itp(postaraj się wymyślić jak najwięcej)
               i spróbuj przekonwertować odpowiedź do odpowiedniego typu danych używając metody:
               typDanych.Parse(odpowiedźOdUżytkownika).
            */
            Console.WriteLine("");
            Console.WriteLine("Exercise#5");
            Console.WriteLine("Your name:");
            var yourName = Console.ReadLine();
            Console.WriteLine("Your surename:");
            var yourSurename = Console.ReadLine();
            Console.WriteLine("Your phone number:");
            var writePhone = Console.ReadLine();
            Console.WriteLine("Your e-mail:");
            var email = Console.ReadLine();
            Console.WriteLine("Your Height:");
            var enterHeight = Console.ReadLine();
            double height = double.Parse(enterHeight);
            Console.WriteLine("Your Weight:");
            var enterWeight = Console.ReadLine();
            double weight = double.Parse(enterWeight);
            Console.WriteLine("Your Address:");
            Console.WriteLine("Postal Code:");
            var enterPostalCode = Console.ReadLine();
            Console.WriteLine("City:");
            var enterCity = Console.ReadLine();
            Console.WriteLine("Street:");
            var enterStreet = Console.ReadLine();
            Console.WriteLine("Building:");
            _ = Console.ReadLine();
        }
    }

}