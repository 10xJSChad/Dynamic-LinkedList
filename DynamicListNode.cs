using System;

namespace DynamicLinkedList
{
    public class DynamicListNode
    {
        public dynamic Key;
        public dynamic Val;
        public DynamicListNode Next;
        public DynamicListNode Back;

        public DynamicListNode(dynamic Key = null, dynamic Val = null, DynamicListNode Next = null, DynamicListNode Back = null)
        {
            this.Key = Key;
            this.Val = Val;
            this.Next = Next;
            this.Back = Back;
        }

        public DynamicListNode GetByKey(dynamic key)
        {
            DynamicListNode Current = this;
            while (Current != null)
            {
                if (Current.Key == key) return (Current);
                Current = Current.Next;
            }
            return null;
        }

        public void Set(dynamic key, dynamic val)
        {
            DynamicListNode Current = this;
            while (Current != null)
            {
                if (Current.Key == key) { Current.Val = val; break; }
                Current = Current.Next;
            }
        }

        public DynamicListNode GetByIndex(int index)
        {
            int i = 0;
            DynamicListNode Current = this;
            while (Current != null)
            {
                if (i == index) return Current;
                i++; Current = Current.Next;
            }
            return null;
        }

        public void Add(dynamic key = null, dynamic val = null)
        {
            dynamic HeadVals = (this.Key, this.Val, this.Next);
            DynamicListNode Head = new DynamicListNode(HeadVals.Item1, HeadVals.Item2, HeadVals.Item3);
            DynamicListNode NewNode = new DynamicListNode(key, val, Head);
            this.Key = key; this.Val = val; this.Next = Head; this.Next.Back = NewNode;
        }

        public void AddToEnd(dynamic key = null, dynamic val = null)
        {
            DynamicListNode Current = this;
            while (Current.Next != null) Current = Current.Next;
            Current.Next = new DynamicListNode(key, val, null, Current);
        }
    }
}
