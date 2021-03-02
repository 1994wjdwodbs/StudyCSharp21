using System;

namespace CallbackTestApp
{
    // 대리자 (메소드를 다른 메소드의 인수로 전달하는 데 사용되는 형식)
    // 콜백
    // 콜백 사용하는 이유 : https://url.kr/eqjcd9
    delegate int Compare(int a, int b); // a, b 비교 대리자
    class Program
    {
        // (a > b) : 1, (a == b) : 0, (a < b) : -1
        static int AscendCompare(int a, int b)
        {
            return (a > b) ? 1 : ((a == b) ? 0 : -1);
        }

        // (a < b) : 1, (a == b) : 0, (a > b) : -1
        static int DescendCompare(int a, int b)
        {
            return (a < b) ? 1 : ((a == b) ? 0 : -1);
        }

        static void BubbleSort(int[] DataSet, Compare comparer)
        {
            int temp = 0;
            for(int i = 0; i < DataSet.Length; i++)
                for(int j = 0; j < DataSet.Length - (i + 1); j++)
                {
                    if(comparer(DataSet[j], DataSet[j + 1]) > 0)
                    {
                        // Swap
                        DataSet[j] = DataSet[j] ^ DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j] ^ DataSet[j + 1];
                        DataSet[j] = DataSet[j] ^ DataSet[j + 1];
                    }

                }
        }

        static void Main(string[] args)
        {
            Compare A = new Compare(AscendCompare);
            Compare D = new Compare(DescendCompare);

            Console.WriteLine("Hello World!");
            Console.WriteLine(A(10, 2));
            Console.WriteLine(A(10, 10));
            Console.WriteLine(A(10, 12));
            Console.WriteLine("--------------------");

            int[] arr = { 5, 4, 3, 2, 1 };
            // 오름차순
            BubbleSort(arr, AscendCompare);
            foreach(int item in arr)
                Console.WriteLine(item);

            Console.WriteLine("--------------------");
            // 내림차순
            BubbleSort(arr, DescendCompare);
            foreach (int item in arr)
                Console.WriteLine(item);
        }
    }
}
