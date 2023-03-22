using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_A_Day.RandomEasy
{
    public class Design_HashMap_706_LC_E
    {
        public class MyHashMap
        {
            Dictionary<int, int> _dict;
            public MyHashMap()
            {
                this._dict = new Dictionary<int, int>();
            }

            public void Put(int key, int value)
            {
                if(_dict.TryAdd(key, value) == false) 
                {
                    _dict[key] = value;
                }
            }

            public int Get(int key)
            {
                if (_dict.ContainsKey(key)) 
                {
                    return _dict[key];
                }
                else
                {
                    return -1;
                }
            }

            public void Remove(int key)
            {
                if (_dict.ContainsKey(key))
                {
                    _dict.Remove(key);
                }
            }
        }

        //using list 
        public class MyHashMap2
        {
            private List<KeyValuePair<int, int>> _list;

            public MyHashMap2()
            {
                _list = new List<KeyValuePair<int, int>>();
            }

            public void Put(int key, int value)
            {
                bool keyExists = false;

                for (int i = 0; i < _list.Count; i++)
                {
                    if (_list[i].Key == key)
                    {
                        _list[i] = new KeyValuePair<int, int>(key, value);
                        keyExists = true;
                        break;
                    }
                }

                if (!keyExists)
                {
                    _list.Add(new KeyValuePair<int, int>(key, value));
                }
            }

            public int Get(int key)
            {
                foreach (KeyValuePair<int, int> kvp in _list)
                {
                    if (kvp.Key == key)
                    {
                        return kvp.Value;
                    }
                }

                return -1;
            }

            public void Remove(int key)
            {
                for (int i = 0; i < _list.Count; i++)
                {
                    if (_list[i].Key == key)
                    {
                        _list.RemoveAt(i);
                        break;
                    }
                }
            }
        }
        //GPT "optimalization" XDD
        public class MyHashMap3
        {
            private const int MaxSize = 1000000; // Maximum possible value of the key
            private int?[,] _arr;

            public MyHashMap3()
            {
                this._arr = new int?[MaxSize + 1, 2];
            }

            public void Put(int key, int value)
            {
                _arr[key, 0] = key;
                _arr[key, 1] = value;
            }

            public int Get(int key)
            {
                if (_arr[key, 0] == null)
                {
                    return -1;
                }

                return (int)_arr[key, 1];
            }

            public void Remove(int key)
            {
                _arr[key, 0] = null;
                _arr[key, 1] = null;
            }
        }
    }
}

