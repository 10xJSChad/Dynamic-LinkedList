<h2>Dynamic LinkedList</h2>
Small & simple doubly Linked List library with support for dynamic type Keys & Values <br>
This was mostly made out of my personal interest for linked lists & data structures, but can also be used practically in applications where one might want to store and retrieve dynamic type data with little hassle. 

<h2>Features</h2>

* Dynamic veys and values
* Get and pop by index or key
* Set by key

<h2>Using Dynamic LinkedList</h2>
Simply download and include DynamicListNode in your project.

```C#
using System;
using DynamicLinkedList;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicListNode prices_of_things = new DynamicListNode();
            prices_of_things.Add("bottle of water", 5);
            prices_of_things.Add("jug of milk", 10);
            prices_of_things.PrintAll();
        }
    }
}

``` 
