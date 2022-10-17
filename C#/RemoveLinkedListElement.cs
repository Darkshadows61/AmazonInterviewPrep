    if (head != null) {
        for (; head != null && head.val == val; head = head.next);
        for (ListNode n = head; n != null && n.next != null;){
            if (n.next.val == val)
                n.next = n.next.next;
            else
                n = n.next;
        }
    }
    return head;