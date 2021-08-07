using System;

namespace DynamicLinkedList
{
    public class DynamicListNode
    {
        public int Size = 1;
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

        public void PrintAll()
        {
            DynamicListNode Current = this;
            while (Current != null)
            {
                Console.WriteLine("Key: " + Current.Key + " | Val: " + Current.Val);
                Current = Current.Next;
            }
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
            if(this.Key == null && this.Val == null)
            {
                this.Key = key; this.Val = val; return;
            }

            dynamic HeadVals = (this.Key, this.Val, this.Next);
            DynamicListNode Head = new DynamicListNode(HeadVals.Item1, HeadVals.Item2, HeadVals.Item3);
            DynamicListNode NewNode = new DynamicListNode(key, val, Head);
            this.Key = key; this.Val = val; this.Next = Head; this.Next.Back = NewNode;
            this.Size++;
        }

        public void AddToEnd(dynamic key = null, dynamic val = null)
        {
            DynamicListNode Current = this;
            while (Current.Next != null) Current = Current.Next;
            Current.Next = new DynamicListNode(key, val, null, Current);
            this.Size++;
        }

        public void Pop(dynamic key)
        {
            DynamicListNode Current = this;
            while (Current != null)
            {
                if (Current.Key == key)
                {
                    if(Current.Back == null)
                    {
                        Current.Key = Current.Next.Key;
                        Current.Val = Current.Next.Val;
                        Current.Next = Current.Next.Next;
                        this.Size--;
                        break;
                    }

                    if(Current.Next != null) Current.Next.Back = Current.Back;
                    Current.Back.Next = Current.Next;
                    this.Size--;
                    break;
                }
                Current = Current.Next;
            }
        }

        public void PopByIndex(int index)
        {
            DynamicListNode Current = this;
            for(int i = 0; i<index; i++)
            {
                Current = Current.Next;
            }

            if (Current.Back == null)
            {
                Current.Key = Current.Next.Key;
                Current.Val = Current.Next.Val;
                Current.Next = Current.Next.Next;
                this.Size--;
                return;
            }

            if (Current.Next != null) Current.Next.Back = Current.Back;
            Current.Back.Next = Current.Next;
            this.Size--;
            return;
        }
    }
}
