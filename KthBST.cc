// Kth in BST tree dfs
public class Solution {
    public int KthSmallest(TreeNode root, int k) {
        if (root == null)
            return -1;
        List<int> res = new List<int>();
        
        
        return dfs(res, root, 0, k);
        
    }
    
    private int dfs (List<int> res, TreeNode root, int st, int k)
    {
        if (root == null)
            return 0;
         
        dfs(res, root.left, st, k);
        if (st + 1 == k)
            return root.val;
        st ++;
        return dfs(res, root.right,st, k);
    }
}
