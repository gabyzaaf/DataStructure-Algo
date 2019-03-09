using System;

namespace Tests {
	internal class LinkedListCustom {
		private Node node;

		public LinkedListCustom(Node node) {
			this.node = node;
		}

		internal string GetAllNodesContents() {
            if(node == null)
            {
                throw new Exception("The node added is null");
            }
            Node current = node;
            var result = "";
            while(current != null)
            {
             result +=$"{current.Number}-";   
             current = current.Next;
            }
            return result.Remove(result.Length-1);
		}

		internal int Size() {
            var count = 0;
            Node current = node;
            while(current != null)
            {
             current = current.Next;
             count ++;
            }
            return count++;
		}

		internal Node GetNodeWithSpecificIndex(int indice)
        {
            int i = 0;
            int size = Size();
            if(indice < 0 &&  indice > size){
                throw new Exception("the indice is outside the node limit");
            }
            Node current = node;
            for(;i != indice;i++)
            {   
                current = current.Next;
            }
            return current;
		}

		internal Node RandomNode() {
		    var number = Size();
		    Random random = new Random();
		    int numberRandom = random.Next(0,number);
            return GetNodeWithSpecificIndex(numberRandom);
		}
	}
}