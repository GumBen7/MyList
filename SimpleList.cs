public class SimpleList<T> {
    public SimpleList(T data) {
        this._head = new Node<T>(data);
        this._last = new Node<T>();
    }
    private Node<T> _head;
    private Node<T> _last;

    public void Push(T data) {
        this._last.Next = new Node<T>(data);
        this._last = this._last.Next;
    }

    public T Pop() {
        if (!IsEmpty) {
            Node<T> popped = this._head;
            T data = popped.Data;
            this._head = this._head.Next;
            popped = null;
            return data;
        }
        return null;
    }
    
    public bool IsEmpty() {
        return _head == _last;
    }
}