using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prove
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    class LeetAddTwoNumbers
    {
        public static ListNode addTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode temp = l1 ?? l2;
            int carry = 0;

            while ((l1 != null && l2 != null) || carry > 0)
            {

                l1.val = (l1?.val ?? 0) + (l2?.val ?? 0) + carry;
                if (l1.val > 9)
                {
                    carry = l1.val / 10;
                    l1.val -= 10;
                }
                else
                {
                    carry = 0;
                }
                if (l1.next == null && (l2?.next != null || carry > 0))
                {
                    l1.next = new ListNode(0);
                }
                l1 = l1.next;
                l2 = l2?.next;
            }
            return temp;
        }
    }
}
