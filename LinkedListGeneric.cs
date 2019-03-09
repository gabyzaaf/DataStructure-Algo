using System;

namespace Tests {
	internal class LinkedListGeneric<T> where T : class{
        NodeCustomGenerics<T> genericNode = new NodeCustomGenerics<T>();
		public LinkedListGeneric() {
			
		}

		internal void Add(T value) {
			var current = genericNode;
			if(current.v == null)
			{
				current.v = value;
				return;
			}

			while(current.next != null)
			{
				current = current.next;
			}
			current.next = new NodeCustomGenerics<T>();
			current.next.Add(value);
		}

		internal T Get(int indice) {
			var current = genericNode;
			for(int i = 0;i!=indice;i++)
			{
				current = current.next;
			}
			return current.v;
		}

		internal void Update(int indice, T value) 
		{
			var current = genericNode;
			for(int i = 0;i<indice;i++)
			{
				current = current.next;
			}
			current.v = value;
		}

		internal int Size() {
			var current = genericNode;
			int count = 0;
			while(current != null)
			{
				current = current.next;
				count ++;
			}
			return count;
		}

		internal void Delete(int indice) {
			NodeCustomGenerics<T> current = genericNode;
			NodeCustomGenerics<T> next;
			if(indice == 0)
			{
				genericNode = genericNode.next;
				return;
			}
			
			for(int i = 0;i<indice -1;i++){
				current = current.next;
			}
			if(indice == (Size()-1))
			{
				current.next = null;
				return ;
			}
			next = current.next.next;
			current.next = next;
		}

		internal bool Exist(T value) {
			bool found = false;
			var current = genericNode;
			while(current != null)
			{
				if(current.v == value){
					found = true;
					break;
				}
				current = current.next;
			}
			return found;
		}
	}
}