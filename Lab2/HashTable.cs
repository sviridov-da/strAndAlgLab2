using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab2
{

    //Используется метод цепочек (открытое хеширование).

    public class HashTable
    {

        private Dictionary<int, List<Item>> items = null;


        public IReadOnlyCollection<KeyValuePair<int, List<Item>>> Items => items?.ToList()?.AsReadOnly();


        public HashTable()
        {
            items = new Dictionary<int, List<Item>>();
        }


        public void Insert(PassportData key, PersonData value)
        {

            var item = new Item(key, value);


            var hash = GetHash(item.Key);


            List<Item> hashTableItem = null;
            if (items.ContainsKey(hash))
            {

                hashTableItem = items[hash];

                var oldElementWithKey = hashTableItem.SingleOrDefault(i => i.Key.Equals(item.Key));
                if (oldElementWithKey != null)
                {
                    throw new ArgumentException($"Хеш-таблица уже содержит элемент с ключом {key}. Ключ должен быть уникален.", nameof(key));
                }

                items[hash].Add(item);
            }
            else
            {

                hashTableItem = new List<Item> { item };

                items.Add(hash, hashTableItem);
            }
        }

        public void Delete(PassportData key)
        {
            var hash = GetHash(key);

            if (!items.ContainsKey(hash))
            {
                return;
            }

            var hashTableItem = items[hash];


            var item = hashTableItem.SingleOrDefault(i => i.Key.Equals(key));


            if (item != null)
            {
                hashTableItem.Remove(item);
            }
        }


        public string Search(PassportData key)
        {

            var hash = GetHash(key);

            if (!items.ContainsKey(hash))
            {
                return "Not found";
            }

            var hashTableItem = items[hash];

            if (hashTableItem != null)
            {
                var item = hashTableItem.SingleOrDefault(i => i.Key.Equals(key));

                if (item != null)
                {
                    return item.Value.ToString();
                }
            }

            return "Not found";
        }


        private int GetHash(PassportData value)
        {

            var hash = value.MonthOfIssue*100+value.DayOfIssue;
            return hash;
        }
    }
}
