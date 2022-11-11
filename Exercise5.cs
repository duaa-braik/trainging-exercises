using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// link to the problem: https://leetcode.com/problems/intersection-of-two-linked-lists/

/*
 * Given the heads of two singly linked-lists headA and headB, return the node 
 * at which the two lists intersect. If the two linked lists have no intersection 
 * at all, return null.
 */


//Definition for singly - linked list.
public class ListNode
  {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
  }

public class Exercise5
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        Dictionary<ListNode, int> intersect = new Dictionary<ListNode, int>();

        ListNode A = headA;
        ListNode B = headB;
        while (A != null)
        {
            intersect.Add(A, 1);
            A = A.next;
        }

        while (B != null)
        {
            if (!intersect.ContainsKey(B))
            {
                intersect.Add(B, 1);
            }
            else
            {
                int count;
                intersect.TryGetValue(B, out count);
                intersect[B] = count + 1;
                break;
            }
            B = B.next;
        }
        return B;
    }




}