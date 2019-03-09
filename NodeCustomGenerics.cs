using System;

namespace Tests {
	internal class NodeCustomGenerics<T> where T : class{
        public T v  {get;set;}
        public NodeCustomGenerics<T> next {get;set;}
		public NodeCustomGenerics() {
		
        }

		internal void Add(T value) {
			v = value;
		}

		internal T GetVal() {
			return v;
		}
	}
}