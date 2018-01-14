using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AprollSupport
{
    public class RoleManager
    {
        private static RoleManager roleManager = null;
        List<string> lstItems = new List<string>();

        private RoleManager()
        {}

        public static RoleManager getInstance()
        {
            if (roleManager == null)
                roleManager = new RoleManager();

            return roleManager;
        }

        public static void addItem(string[] items)
        {
            getInstance().addItem_(items);
        }

        public void addItem_(string[] items)
        {
            lstItems.AddRange(items);
        }

        public static void addItem(string item)
        {
            getInstance().addItem_(item);
        }

        public void addItem_(string item)
        {
            lstItems.Add(item);
        }

        public static void removeItem(string item)
        {
            getInstance().removeItem_(item);
        }

        public void removeItem_(string item)
        {
            lstItems.Remove(item);
        }

        public static void removeItem(string[] items)
        {
            getInstance().removeItem_(items);    
        }

        public void removeItem_(string[] items)
        {
            for(int i = 0; i < items.Length; i++)
                lstItems.Remove(items[i]);
        }

        public static void clearItem()
        {
            getInstance().clearItem_();
        }

        public void clearItem_()
        {
            lstItems.Clear();
        }

        public static string[] getRoleNames()
        {
            return getInstance().getRoleNames_();
        }

        public string[] getRoleNames_()
        {
            return (lstItems.Count == 0) ? null : lstItems.ToArray();
        }

    }
}
