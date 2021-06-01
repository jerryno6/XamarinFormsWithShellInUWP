using System;

namespace XamarinWithShell.Models
{
    public class Item
    {
        public Item(string name = null)
        {
            Id = Guid.NewGuid().ToString().Substring(0, 6);
            Name = name;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}