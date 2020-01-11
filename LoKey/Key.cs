using System;
namespace LoKey
{
    public class Key
    {
        public String Name { get; set; }
        public String Image { get; set; }
        public int UID { get; set; }

        public Key(String n, int uid)
        {
            this.Name = n;
            this.Image = "key.png";
            this.UID = uid;
        }
    }
}
