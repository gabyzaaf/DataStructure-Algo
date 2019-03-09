using System;

namespace Tests {
	internal class Node {
		public int Number{get; private set;}
        public Node Next {get;private set;}
		public Node(int number) {
			Number = number;
		}

		internal void AddNextNode(Node nextNode) 
        {
            Next = nextNode;
		}
	}
}