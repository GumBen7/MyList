public class Node<T> {
    public Node(T data) {
        this.Data = data;
    }
    private T _data;
    private Node<T> _next;
    public T Data {
        get {
            return this._data;
        }
        set {
            this._data = value;
        }
    }
    public Node<T> Next {
        get {
            return this._next;
        }
        set {
            this._next = value;
        }
    }
}