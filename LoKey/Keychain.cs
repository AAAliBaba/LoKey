using System;
using System.Collections.Generic;

namespace LoKey
{
    public class Keychain
    {
        public String Owner { get; set; }
        public List<Key> Keys { get; set; }
        public int Count { get; set; }

        public Keychain(String o)
        {
            this.Owner = o;
            this.Count = 0;
            this.Keys = new List<Key>();
        }

        public void AddKey(string name)
        {
            Key x = new Key(name, this.Count);
            Keys.Add(x);
            this.Count++;
        }
    }
}
