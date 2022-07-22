 public class Node
    {
        public object value { get; set; }
        public object? next { get; set; }

        public Node(object value)
        {
            this.value = value;
            this.next = null;
        }
    }