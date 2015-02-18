using System.Collections.Generic;
using System.Linq;

namespace BST
{
   public class TreeTraversal : ITreeTraversal
    {
        public void PreOder(Node rooNode)
        {
            if (rooNode == null) return;
            System.Console.Write(rooNode.Value);
            if (rooNode.Left != null) PreOder(rooNode.Left);
            if (rooNode.Right != null) PreOder(rooNode.Right);
        }

        public void PostOder(Node rooNode)
        {
            if (rooNode == null) return;
            if (rooNode.Left != null) PostOder(rooNode.Left);
            if (rooNode.Right != null) PostOder(rooNode.Right);
            System.Console.Write(rooNode.Value);
        }

        public void InOrder(Node rooNode)
        {
            if (rooNode == null) return;
            if (rooNode.Left != null) InOrder(rooNode.Left);
            System.Console.Write(rooNode.Value);
            if (rooNode.Right != null) InOrder(rooNode.Right);
        }

       public void LevelOrder(Node rootNode)
       {
           if (rootNode == null) return;
           var queue = new Queue<Node>();
           queue.Enqueue(rootNode);
           while (queue.Any())
           {
               var n = queue.Dequeue();
               System.Console.Write(n.Value);
               if (n.Left != null) queue.Enqueue(n.Left);
               if (n.Right != null) queue.Enqueue(n.Right);
           }
       }

       public void printTreeLevel_iter1(Node root)
       {
           int h = 4;
           bool ltr;
           int i;
           for (i = 1, ltr = true; i <= h; i++, ltr = !ltr)
           {
               zigzagRec(root, i, ltr);
           }
       }

       private void zigzagRec(Node node, int desired, bool ltr)
      {
          if (node == null || desired < 0) return;
          if (desired == 1)
          {
              System.Console.Write(node.Value);
              return;
          }
          /* Based on the flag call the recursive function accordingly */
           if (ltr)
           {
               zigzagRec(node.Left, desired - 1, ltr);
               zigzagRec(node.Right, desired - 1, ltr);
           }
           else
           {
               zigzagRec(node.Right, desired - 1, ltr);
               zigzagRec(node.Left, desired - 1, ltr);
           }
       }

    }
}