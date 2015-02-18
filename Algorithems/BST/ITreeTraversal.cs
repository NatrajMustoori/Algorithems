using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
   public interface ITreeTraversal
   {
       void PreOder(Node rooNode);
       void PostOder(Node rooNode);
       void InOrder(Node rooNode);
       void LevelOrder(Node rooNode);
   }
}
