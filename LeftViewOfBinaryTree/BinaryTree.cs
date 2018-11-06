using System;
using System.Collections.Generic;
using System.Text;

namespace LeftViewOfBinaryTree
{
    class BinaryTree
    {
        TreeNode rootNode;

        public BinaryTree() { }

        public TreeNode GetRootNode() {
            return rootNode;
        }

        public void InsertInTree(int data) {
            rootNode = Insert(data, this.rootNode);
        }

        private TreeNode Insert(int data, TreeNode treeNode) {

            if (treeNode == null)
            {
                treeNode = new TreeNode(data);
                return treeNode;
            }
            else {
                if (data < treeNode.GetData())
                {
                    treeNode.SetLeftNode(Insert(data, treeNode.GetLeftNode()));
                }
                else {
                    treeNode.SetRightNode(Insert(data, treeNode.GetRightNode()));
                }
            }
            return treeNode;
        }

    }
}
