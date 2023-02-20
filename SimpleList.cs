public class SimpleList<T> {
    public SimpleList() {
        this._head = new Node<T>();
        this._penult = this._head;
    }
    private Node<T> _head;
    private Node<T> _penult;

    public void Push(T data) {
        this._penult.Next = new Node<T>(data);
        this._penult = this._penult.Next;
    }

    public T Pop() {
        if (!IsEmpty()) {
            Node<T> popped = this._head;
            T data = popped.Data;
            this._head = this._head.Next;
            popped = null;
            return data;
        }
        return default(T);
    }
    
    public bool IsEmpty() {
        return _head == _penult;
    }
}