using System;

namespace DictionaryTests {
	internal class DictionaryGeneric {
		int size = 10;
        string[] keys = new string[10];

        string[] values = new string[10];


		internal int GetHashFrom(string world)
		{
			return Djb2(world) % size;
		}


		internal void Add(string key, string value) {
            int indice = GetHashFrom(key);
            for(int i = 0;i<size;i++)
            {
                if(keys[i] == null)
                {
                    keys[i] = key;
                }
            }
            if(values[indice] != null)
            {
                throw new Exception("The Key Already Exist");
            }
            values[indice] = value;
		}

		internal string Get(string key) {
            int k = GetHashFrom(key);
            return values[k];
		}

		private int Djb2(string input){
            int hash = 5381;
            foreach (var character in input.ToCharArray())
            {
                unchecked
                {
                    hash = ((hash << 5)+hash)+character;
                }
            }
            return hash;
        }
	}
}