
using Projects.AddTwoNumbers;

namespace LeetCode;

public static class AddTwoNumbers {
    public static ListNode Run(ListNode l1, ListNode l2)
    {
        ListNode result = new ListNode();

        ListNode current = result;
        int carry = 0;
        while (true)
        {
            int sum = l1.val + l2.val + carry;
            carry = sum / 10;
            current.val = sum % 10;

            if (l1.next == null && l2.next == null)
            {
                if (carry > 0)
                {
                    current.next = new ListNode(carry);
                }
                break;
            }

            current.next = new ListNode();
            current = current.next;

            l1 = l1.next ?? new ListNode();
            l2 = l2.next ?? new ListNode();
        }

        return result;
    }
}