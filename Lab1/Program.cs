using System;

namespace Lab1
{
	internal class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("---task1---");
            string inputString = "tiger";
            ReverseAndPrint(inputString);
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("---task2---");
            ListNode head1 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));
            PrintList(head1);
            Console.WriteLine("");

            ListNode newHead1 = SwapPairs(head1);
            PrintList(newHead1);
            Console.WriteLine();
            Console.WriteLine("");

            Console.WriteLine("---task3---");
            Console.WriteLine($"F(7):  {Fibonacci(7)}");
            Console.WriteLine("");

            Console.WriteLine("---task4---");
            Console.WriteLine($"n=6: {ClimbStairs(6)}");
            Console.WriteLine("");

            Console.WriteLine("---task5---");
            Console.WriteLine($"2 ^ 10 =  {MyPow(2, 10)}");
            Console.ReadKey();

        }
        static void ReverseAndPrint(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return;
            }

            Console.Write(input[input.Length - 1]);

            ReverseAndPrint(input.Substring(0, input.Length - 1));
        }
        static ListNode SwapPairs(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            int temp = head.val;
            head.val = head.next.val;
            head.next.val = temp;

            head.next.next = SwapPairs(head.next.next);

            return head;
        }

        static void PrintList(ListNode head)
        {
            while (head != null)
            {
                Console.Write(head.val + " ");
                head = head.next;
            }
        }
        static int Fibonacci(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
        static int ClimbStairs(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            int ways1 = ClimbStairs(n - 1);
            int ways2 = ClimbStairs(n - 2);

            return ways1 + ways2;
        }
        static double MyPow(double x, int n)
        {
            if (n == 0)
            {
                return 1.0;
            }

            if (n < 0)
            {
                x = 1 / x;
                n = -n;
            }

            double halfPow = MyPow(x, n / 2);

            return (n % 2 == 0) ? halfPow * halfPow : x * halfPow * halfPow;
        }
    }
}
