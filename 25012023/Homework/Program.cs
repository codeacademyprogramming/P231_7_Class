using System;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsFullname("Hikmet Abbasov"));

            int[] numbers = { 34, 10, 34, 54, 23, 54, 10 };

            numbers = MakeUniqueArr(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            string[] emails = { "hiko@gmail.com", "abbas@code.edu.az", "hikmet@code.edu.az", "nermin@yandex.ru", "abdulla@gmail.com" };

            //for (int i = 0; i < emails.Length; i++)
            //{
            //    Console.WriteLine(emails[i]);
            //}

            foreach (string item in emails)
            {
                Console.WriteLine(item);
            }

            var domains = GetEmailDomains(emails);

            for (int i = 0; i < domains.Length; i++)
            {
                Console.WriteLine(domains[i]);
            }

            var count = GetSentenceCount("Salam. Men geldim...");

            Console.WriteLine(count);




        }

        //Verilmiş yazıda rəqəm olub olmadığını tapan metod
        static bool HasDigit(string str)
        {
            for(int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                    return true;
            }

            return false;
        }

        static bool IsName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return false;

            if (!char.IsUpper(name[0]))
                return false;

            for (var i = 1; i < name.Length; i++)
            {
                if (!char.IsLower(name[i]))
                    return false;
            }
            return true;
        }



        //Verilmiş yazının fullname olub olmadığını tapan metod
        //(fullname olması üçün iki ve daha cox sozdən ibarət olmalıdır və hər bir söz böyük
        //hərflə başlayıb kiçik hərflərlə davam etməlidir)

        static bool IsFullname(string str)
        {
            var words = str.Split(' ');

            if (words.Length < 2) return false;

            for(var i = 0; i < words.Length; i++)
            {
                if (!IsName(words[i]))
                    return false;
            }

            return true;
        }

        //Verilmiş ədədlər siyahısından yeni bir array düzəldib qaytaran metod.
        //Yeni arrayə elementlər təkrarlanmamaq şərti ilə yerləşdirilsin.

        static int[] MakeUniqueArr(int[] arr)
        {
            int[] newArr = new int[0];

            for(int i = 0; i < arr.Length; i++)
            {
                if (Array.IndexOf(newArr, arr[i]) == -1)
                {
                    Array.Resize(ref newArr, newArr.Length + 1);
                    newArr[newArr.Length - 1] = arr[i];
                }
            }

            return newArr;
        } 

        static string[] GetEmailDomains(string[] emails)
        {
            string[] domains = new string[0];

            for(var i = 0; i < emails.Length; i++)
            {
                var domain = emails[i].Substring(emails[i].IndexOf('@')+1);

                if (Array.IndexOf(domains, domain) == -1)
                {
                    Array.Resize(ref domains, domains.Length + 1);
                    domains[domains.Length - 1] = domain;
                }
            }
            return domains;
        }

        //Verilmiş yazının içindəki cümlələrin sayını tapan metod.
        static int GetSentenceCount(string str)
        {
            var arr = str.Split('.');
            int count = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(arr[i]))
                    count++;
            }

            return count;
        } 
    }
}
