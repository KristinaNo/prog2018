using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class HashTable

    {
        class Pair
        {
            public object Key { get; set; }
            public object Value { get; set; }
        }

        List<List<Pair>> list;
        /// <summary>

        /// Конструктор контейнера

        /// summary>

        /// size">Размер хэ-таблицы

        public HashTable(int size)

        {
            list = new List<List<Pair>>();
            for (int i=0; i<size; i++)
            {
                list.Add(new List<Pair>());
            }


        }

        /// 

        /// Метод складывающий пару ключь-значение в таблицу

        /// 

        /// key">

        /// value">

        public void PutPair(object key, object value)

        {
            var bucketNumber = Math.Abs(key.GetHashCode()) % list.Count; ;
            foreach(var element in list[bucketNumber])
            {
                if (Equals(element.Key, key))
                {
                    element.Value = value;
                    return;
                }
            }
            list[bucketNumber].Add(new Pair { Key = key, Value = value });
        }



        /// <summary>

        /// Поиск значения по ключу

        /// summary>

        /// key">Ключь

        /// <returns>Значение, null если ключ отсутствуетreturns>

        public object GetValueByKey(object key)

        {
            var bucketNumber = Math.Abs(key.GetHashCode()) % list.Count; ;
            foreach (var element in list[bucketNumber])
            {
                if (Equals(element.Key, key))
                {
                    return element.Value;
                }
            }

            return null;
        }
        static void Main()
        {
        }
    }
}
