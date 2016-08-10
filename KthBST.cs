// Kth in BST tree dfs
public class Solution {
    public int KthSmallest(TreeNode root, int k) {
		 if (root == null)
			return -1;
		Stack<TreeNode> myS = new Stack<TreeNode>();
		while (myS.Count > 0 || root != null)
		{
			while (root != null)
			{
				myS.Push(root);
				root = root.left;
			}
			TreeNode curr = myS.Pop();
			if (k - 1 == 0)
				return curr.val;
			k--;
			root = curr.right;
		}
		
		return -1;
	
        
    }
    
    
}

//