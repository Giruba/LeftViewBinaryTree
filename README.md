# LeftViewBinaryTree
C# program for printing left view of Binary Tree 

Given a tree for exampe 1->2->3

  2 (Root
----------
|           |
(Left)1     3 (Right)

When visiting from left, the nodes visible are 2 and 1.

Therefore, 2 and 1 should be printed for Left view.

Logic/Algorithm:
-----------------

Simple Traversal (PreOrder)

1. Initialise maxLevel as 0 and Level as 1 for Root
2. Call Recurive function which will do the following
    
   2.a If root is null return
   2.b If level is greater than maxlevel, print the node's data
       Assign level to maxLevel
   2.c Recur over left and right with level+1
   
   
Illustration
-------------
  1. Since 2 is Root, and since we have level as 1 and maxLevel as 0, 2 will be printed.
   Now maxlevel becomes level, so maxlevel= level = 1
   
  2. Now recuring over left subtree, we have level = 2 but maxLevel is still 1
     Therefore 1 gets printed
     Now, maxelevel becomes 2
     
 3. Left recursion stops. Now right recursion starts with level = 2 but maxLevel is still 2
    Therefore 3 does not get printed.
   
