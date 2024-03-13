//namespace ConsoleApp3
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] arr = { 3, 10, 1, 40, 29, 20 };
//            bool check = false;

//            for (int i = 0; i < arr.Length; i++)
//            {
//                check = false;
//                for (int j = 0; j < arr.Length - 1; j++)
//                {
//                    if (arr[j] > arr[j + 1])
//                    {
//                        int swapped = arr[j];
//                        arr[j] = arr[j + 1];
//                        arr[j + 1] = swapped;
//                        check = true;
//                    }

//                }
//                for (int k = 0; k < arr.Length; k++)
//                {
//                    Console.Write(arr[k] + " ");
//                }
//                Console.WriteLine();

//                if (!check)
//                {
//                    break;
//                }


//            }
//        }
//    }
//}



namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 10, 1, 40, 29, 5 };
            int a = 40;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == a)
                {
                    Console.WriteLine(i);
                    break;
                }

                if (i == arr.Length - 1)
                {
                    Console.WriteLine("Not found");
                }

            }

        }
    }
}