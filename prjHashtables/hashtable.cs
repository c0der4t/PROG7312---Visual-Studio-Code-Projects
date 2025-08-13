using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjHashtables
{
    internal class HashTable
    {
        private readonly List<Influencer>[] indexus;
        public HashTable(int size)
        {
            indexus = new List<Influencer>[size];
            for (int i = 0; i < size; i++)
            {
                indexus[i] = new List<Influencer>();
            }
        }
        private int GetContentIndex(string key)
        {
            return Math.Abs(key.GetHashCode()) % indexus.Length;
        }
        public void Add(string key, Influencer influencer)
        {
            int index = GetContentIndex(key);
            var content = indexus[index];
            foreach (var item in content)
            {
                if (item.Username == key)
                {
                    throw new ArgumentException("An element with the same key already exists.");
                }
                content.Add(influencer);
            }
        }
        public Influencer Get(string key)
        {
            int index = GetContentIndex(key);
            var bucket = indexus[index];
            foreach (var item in bucket)
            {
                if (item.Username == key)
                {
                    return item;
                }
            }
            return null;
        }
        public Influencer remove(string key)
        {
            int index = GetContentIndex(key);
            var content = indexus[index];
            for (int i = 0; i < content.Count; i++)
            {
                if (content[i].Username == key)
                {
                    Influencer influencer = content[i];
                    content.RemoveAt(i);
                    return influencer;
                }
            }
            return null;
        }
    }
}