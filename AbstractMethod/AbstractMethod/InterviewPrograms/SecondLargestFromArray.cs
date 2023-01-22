using System;

namespace AbstractMethod.InterviewPrograms
{
    class LargestElement
    {
        public static void ChangedMethod()
        {
            int[] array = new int[] { 10, 3, 8, 4, 19 };
            int large = 0, small = 0, mid = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (large < array[i] && mid <= large)
                {
                    small = mid;
                    mid = large;
                    large = array[i];
                }
                else if (mid < array[i] && small <= mid)
                {
                    small = mid;
                    mid = array[i];
                }
                else if (small <= array[i])
                {
                    small = array[i];
                }
            }
            foreach (var item in array)
            {
                Console.Write(item + " ");

            }
            Console.WriteLine();
            Console.WriteLine("3rd largest Array Element :{0} ", small);
        }
        public static void SecondLargestNumber()
        {
            int[] myArray = new int[] { 0, 1, 2, 3, 13, 8, 5 };

            int largest = 0;
            int second = 0;

            foreach (int i in myArray)
            {
                if (i > largest)
                {
                    second = largest;
                    largest = i;
                }
                else if (i > second)
                    second = i;
            }
            Console.WriteLine(second);
        }

    }


    class CodeingAssistance
    {
        private readonly CodeInspector _codeIndicator;
        public CodeingAssistance(CodeInspector codeIndicator)
        {
            _codeIndicator = codeIndicator;
        }

    }
    class CodeInspector
    {

    }

}
