namespace prjTreeExample
{
    class TreeNode<T>
    {
        public T Data { get; set; }

        public TreeNode<T> Parent { get; set; }

        public List<TreeNode<T>> Children { get; set; }
        = new List<TreeNode<T>>();
    }
}