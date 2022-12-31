namespace DataStructureAndAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select Programs\n 1.Binary search\n 2.Bubble sort\n 3.Anagram Detection\n 4.Check Prime Number\n 5.Check Number is Prime,palindrome or Anagram\n 6.Order List using Generics\n 7.String repalce");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        BinarySearch binarysearch = new BinarySearch();
                        binarysearch.Search(@"C:\Users\HP\Desktop\rfp\brigdelabz assignment\asignment\DataStructureAndAlgorithm\DataStructureAndAlgorithm\DataStructureAndAlgorithm\Word.txt");
                        break;
                    case 2:
                        BubbleSort bubblesort = new BubbleSort();
                        bubblesort.Sort(@"C:\Users\HP\Desktop\rfp\brigdelabz assignment\asignment\DataStructureAndAlgorithm\DataStructureAndAlgorithm\DataStructureAndAlgorithm\Word.txt");
                        break;
                    case 3:
                        Anagram anagram = new Anagram();
                        anagram.AnagramCheck("heart", "earth");
                        break;
                    case 4:
                        PrimeNumber prime = new PrimeNumber();
                        prime.Prime();
                        break;
                    case 5:
                        PrimePalindromeAnagram primePalimdrome = new PrimePalindromeAnagram();
                        primePalimdrome.PrimeNumber();
                        primePalimdrome.Palindrome();
                        primePalimdrome.AnagramCheck();
                        break;
                    case 6:
                        OrderList orderList = new OrderList();
                        orderList.Link(@"C:\Users\Suraj Sinha\OneDrive\Desktop\Bridgelabz\DataStructureAndAlgorithm\DataStructureandAlgorithm\Words.txt");
                        break;
                    case 7:
                        StringReplace stringReplace = new StringReplace();
                        stringReplace.Validate("\nHello << name >>, We have your fullname as << full name >> in our system.", "abc");
                        stringReplace.ValidateNumber("your contact number is << contactno >>.", "91 7558570105");
                        stringReplace.ValidateDate("Thank you BridgeLabz << Date >>.\n", "25/09/2022");
                        break;
                }
            }
        }
    }
}