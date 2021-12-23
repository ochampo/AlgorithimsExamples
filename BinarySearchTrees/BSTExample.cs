using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTrees
{
    public class BSTExample
    {
        public static Node Insert(Node root, int value )
        {
            if (root == null)
            {
                root = new Node();
                root.Data = value;
            }
            else
            {
                if (value < root.Data)
                {
                  // insert left 
                  root.Left = Insert(root.Left, value);
                
                }
                else if(value > root.Data)
                {
                    //insert on right
                    root.Right = Insert(root.Right, value);
                }


            }

            return root;

        }
    
    }
}
