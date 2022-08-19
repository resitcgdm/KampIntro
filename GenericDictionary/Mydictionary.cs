using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDictionary
{

    public class Mydictionary<T, K>
    {

        KeyValuePair<T, K>[] items;

        public Mydictionary()
        {
            items = new KeyValuePair<T, K>[0]; //0 elemanlı key value iceren arrayi oluşturduk


        }
        public void Add(T keys, K values)
        {
            if (Control(keys))
            {
                KeyValuePair<T, K>[] tempArray = items;
                items = new KeyValuePair<T, K>[tempArray.Length + 1];

                for (int i = 0; i < tempArray.Length; i++)
                {
                    items[i] = tempArray[i];

                }
              
                items[items.Length - 1] = new KeyValuePair<T, K>(keys, values); // En son bize gelen değeri dizimize aktarıp işi bitirdik.
            }
            else
            {
                Console.WriteLine("Girdiğiniz key değeri özel olmalı. Yani daha önceden eklenmiş bir key değerini tekrardan kullanamazsınız.");
            }
        }

        public void ShowList()
        {
            foreach (var item in items)

            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

        }

       

        public bool Control(T keys)
        {
            bool control = true;
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Key.ToString() == keys.ToString())
                {
                    control = false;
                }
            }
            return control;

        }



    }

    //class MyDictionary<K, V>
    //{
    //    KeyValuePair<K, V>[] items; // KeyValuePair int gibi string gibi bir veri tipidir.
    //    //ctor kullanarak consructor'ı oluşturduk
    //    public MyDictionary()
    //    {
    //        items = new KeyValuePair<K, V>[0];
    //    }
    //    public void Add(K _key, V _value) //K tipinde key,V tipinde value değeri ekle demiş olduk.
    //    {
    //        KeyValuePair<K, V>[] tempArray = items; // değerlerimizi tutması amacıyla geçici dizimizi oluşturduk.
    //        items = new KeyValuePair<K, V>[items.Length + 1];
    //        for (int i = 0; i < tempArray.Length; i++)
    //        {
    //            items[i] = tempArray[i]; //ödünç verdiğimiz elemanları asıl dizimize geri koyduk.
    //        }
    //        items[items.Length - 1] = new KeyValuePair<K, V>(_key, _value);
    //        Console.WriteLine(items[items.Length - 1]);
    //    }
    //}
}
