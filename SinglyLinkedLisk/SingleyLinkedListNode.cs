using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleyLinkedListNamespace
{
    public class SingleyLinkedListNode
    {
        public SingleyLinkedListNode(Person p)
        {
            this.Person = p;
        }

        public Person Person { get; set; }
        public SingleyLinkedListNode? Next { get; set; } = null;

    }
}