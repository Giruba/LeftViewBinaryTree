using System;
using System.Collections.Generic;
using System.Text;

namespace LeftViewOfBinaryTree
{
    class TreeNode
    {
        int data;
        TreeNode leftNode;
        TreeNode rightNode;

        public TreeNode(int data) {
            this.data = data;
        }

        public int GetData() {
            return data;
        }

        public void SetData(int data) {
            this.data = data;
        }

        public TreeNode GetLeftNode() {
            return leftNode;
        }

        public TreeNode GetRightNode(){
            return rightNode;
        }

        public void SetLeftNode(TreeNode left) {
            leftNode = left;
        }

        public void SetRightNode(TreeNode right){
            rightNode = right;
        }
    }
}
