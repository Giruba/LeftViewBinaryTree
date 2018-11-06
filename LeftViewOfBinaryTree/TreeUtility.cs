using System;
using System.Collections.Generic;
using System.Text;

namespace LeftViewOfBinaryTree
{
    static class TreeUtility
    {
        static int maxLevel = 0;
        public static void LeftView(TreeNode treeNode) {

            int level = 1;
            int maxLevel = 0;
            Console.WriteLine("--------The Result------------");
            LeftViewPrinter(treeNode, level);
        }

        static void LeftViewPrinter(TreeNode treeNode, int level) {
            if (treeNode == null) {
                return;
            }
            
            if (level > maxLevel) {
                Console.WriteLine(treeNode.GetData());
                maxLevel = level;
            }
            level = level + 1;
            LeftViewPrinter(treeNode.GetLeftNode(), level);
            LeftViewPrinter(treeNode.GetRightNode(), level);
        }
    }
}
