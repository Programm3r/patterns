using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    /// <summary>
    ///     This represents the object built
    /// </summary>
    public class Menu
    {
        private List<string> _menuItems = new List<string>();

        public void AddItem(string item)
        {
            _menuItems.Add(item);
        }

        public IReadOnlyList<string> Items => _menuItems;
    }
}
