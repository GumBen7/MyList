public class Node<T> {
    public Node() {
        this._data = default(T);
        this._next = null;
    }
    public Node(T data, Node<T> next) {
        this._data = data;
        this._next = next;
    }
    private T _data;
    private Node<T> _next;
    public T Data {
        get {
            return this._data;
        }
    }
    public Node<T> Next {
        get {
            return this._next;
        }
    }

    public void SetNext(Node<T> next) {
        this._next = next;
    }
}