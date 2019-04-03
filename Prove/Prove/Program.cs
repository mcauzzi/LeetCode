using System;

namespace Prove
{
    class Program
    {
        /// <summary>
        /// Main Method
        /// </summary>
        /// <param name="args">Main args</param>
        private static void Main(string[] args)
        {
            ListNode l1 = new ListNode(5);
            //l1.next = new ListNode(4);
            //l1.next.next = new ListNode(3);

            ListNode l2 = new ListNode(5);
            //l2.next = new ListNode(6);
            //l2.next.next = new ListNode(4);

            var l=LeetAddTwoNumbers.addTwoNumbers(l1, l2);

            Console.WriteLine(l.val);
        }
    }
}
