using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary <T1, T2>
    {
        T1[] keys;
        T2[] values;

        public MyDictionary()
        {
            keys = new T1[0];
            values = new T2[0];
        }

        public void Add(T1 element, T2 item)
        {
            T1[] tempKeys = keys;
            T2[] tempValues = values;

            keys = new T1[keys.Length + 1];
            values = new T2[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
            }

            for (int i = 0; i < tempValues.Length; i++)
            {
                values[i] = tempValues[i];
            }

            keys[keys.Length - 1] = element;
            values[values.Length - 1] = item;
        }

        public int MyKeysLength {
            get { return keys.Length; } 
        }

        public int MyValuesLength { 
            get
            {
                return values.Length;
            } 
        }
        public void ShowData()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("ID: " + keys[i] + " Language: " + values[i]);
            }
        }
    }
}
