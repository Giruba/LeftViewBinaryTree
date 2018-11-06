using System;

namespace LeftViewOfBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Left View of a tree!");
            Console.WriteLine("--------------------");

            try
            {
                Console.WriteLine("Enter the number of nodes in the tree");
                int noOfNodes = int.Parse(Console.ReadLine());
                TreeNode rootNode = null;
                BinaryTree binaryTree = new BinaryTree();

                for (int i = 0; i < noOfNodes; i++)
                {
                    Console.WriteLine("Enter the element:");
                    binaryTree.InsertInTree(int.Parse(Console.ReadLine()));
                }

                rootNode = binaryTree.GetRootNode();
                TreeUtility.LeftView(rootNode);
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is"+exception.Message);
            }

            Console.ReadLine();
        }
    }
}
