using System;

namespace DictionaryTests {
	internal class DictionaryGeneric {
		public int sizeDefined = 10;
        string[] keys = new string[10];
        string[] copyKeys;

        string[] values = new string[10];
        string[] copyValue ;

        public DictionaryGeneric()
        {
            for(int i = 0;i<keys.Length;i++)
            {
                keys[i] = null;
                values[i] = null;
            }
        }

		internal int GetHashFrom(string world)
		{
			return Djb2(world) % sizeDefined;
		}


        internal int GetHashFrom2(string world,int size)
		{
			return Djb2(world) % size;
		}


		internal void Add(string key, string value) {
            int stat = (keys.Length * 30/100);
            copyKeys = new string[keys.Length];
            copyValue = new string[values.Length];
//             if(keys.Length == Size())
//             {
//                 int lastSize = Size();
// //              sizeDefined = keys.Length+stat;
//                 sizeDefined = 0;
//                 for(int keyIndice = 0;keyIndice<keys.Length;keyIndice++)
//                 {
//                     copyKeys[keyIndice]=keys[keyIndice];
                    
//                 }

//                 for(int keyIndice = 0;keyIndice<values.Length;keyIndice++)
//                 {
//                     copyValue[keyIndice]=values[keyIndice];
//                 }
                
//                 keys = new string[sizeDefined];
//                 values = new string[sizeDefined];

//                 for(int keyIndice = 0;keyIndice<copyKeys.Length;keyIndice++)
//                 {
//                     var valueFromKey = copyKeys[keyIndice];
//                     int indiceValue = GetHashFrom2(valueFromKey,lastSize);
//                     var valueFromValues = copyValue[indiceValue];
//                     int newIndice = GetHashFrom(valueFromKey);
//                     copyValue[newIndice] = valueFromKey;
//                     // keys[keyIndice]=copyKeys[keyIndice];
//                     // var currentKey = copyKeys[keyIndice];
//                     // var valueWithTheLastIndice = 
//                     // var keyIndiceWithNewArraySize = GetHashFrom(currentKey);
//                     //values[keyIndiceWithNewArraySize];
//                 }
                
//             }
            int indice = GetHashFrom(key);
            int i = 0;
            for(;i<keys.Length;i++)
            {
                if(keys[i] == null)
                {
                    break;
                }
            }
            keys[i] = key;
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

		internal void Remove(string key) {
            bool found = false;
            for(int i = 0;i<keys.Length;i++)
            {
                if(keys[i]==key)
                {
                    found = true;
                    int indice = GetHashFrom(keys[i]);
                    keys[i]=null;
                    values[indice]=null;
                }
            }
            if(!found)
            {
                throw new Exception($"the key -> {key} not exist ");
            }
            
		}

		internal void Update(string key, string valueToUpdate) 
        {
			bool found = false;
            for(int i = 0;i<keys.Length;i++)
            {
                if(keys[i] == key)
                {
                    found = true;
                    int indice = GetHashFrom(key);
                    values[indice] = valueToUpdate;
                }
            }
            if(!found)
            {
                throw new Exception($"the key -> {key} not exist ");
            }
		}

		internal int Size() 
        {
            var count = 0;
            for(int i = 0;i<keys.Length;i++)
            {
                if(keys[i]!=null)
                {
                    count++;
                }
            }
            return count;
		}
	}
}