namespace DataStructureAndAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select Programs\n 1.Binary search");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        BinarySearch binarysearch = new BinarySearch();
                        binarysearch.Search(@"C:\Users\HP\Desktop\rfp\brigdelabz assignment\asignment\DataStructureAndAlgorithm\DataStructureAndAlgorithm\DataStructureAndAlgorithm\Word.txt");
                        break;
                }
            }
        }
    }
}