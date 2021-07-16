using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SectionC.Classes;

namespace ListToTree
{
    public class Program
    {

        /// <summary>
        /// 
        /// Your task here is to implement 2 extension method ToTreeItem and GetMap.
        /// 
        /// ToTreeItem
        /// this method will transform list to tree
        ///   - tree save reference to children in form of object while list save reference to parent Id.
        /// 
        /// GetMap
        /// this method will return string representation of tree item
        /// 
        /// Expected output for GetMap()
        /// Id : 1, Name : Alpha
        /// --Id : 11, Name : Alpha-01
        /// --Id : 12, Name : Alpha-02
        /// ----Id : 121, Name : Alpha-02-Ace
        /// Id : 2, Name : Beta
        /// --Id : 21, Name : Beta-01
        /// ----Id : 211, Name : Beta-01-One
        /// ----Id : 212, Name : Beta-01-Two
        /// ----Id : 213, Name : Beta-01-Three
        /// --Id : 22, Name : Beta-02
        /// ----Id : 221, Name : Beta-02-One
        /// ----Id : 222, Name : Beta-02-Two
        /// ----Id : 223, Name : Beta-02-Three
        /// 
        /// 
        /// Your scope is limited to this file except class Program and Main method, so you are free to :
        ///   - Change CollectionExtensions class
        ///   - Add new method in CollectionExtensions class
        ///   - Add new class in this file
        /// 
        /// You're NOT allowed to :
        ///   - Change class Program
        ///   - Change Main method
        ///   - Change any file other than this file
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var listItems = Init.InitListItems();
            var treeItems = CollectionExtensions.ToTreeItem(listItems);

            Console.WriteLine(Environment.NewLine + "=====================================" + Environment.NewLine);
            Console.WriteLine(CollectionExtensions.GetMap(treeItems));
            Console.ReadLine();
        }
    }

    public static class CollectionExtensions
    {
        public static List<TreeItem> ToTreeItem(List<ListItem> listItems)
        {
            return new List<TreeItem>();
        }

        public static string GetMap(IEnumerable<TreeItem> treeItems)
        {
            string map = string.Empty;

            return map;
        }
    }
}
