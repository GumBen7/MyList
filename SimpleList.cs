public class SimpleList<T> {
    public SimpleList() {
        this._head = new Node<T>(default(T), new Node<T>());
        this._penult = this._head;
    }
    private Node<T> _head;
    private Node<T> _penult;

    public void Push(T data) {
        this._penult.SetNext(new Node<T>(data, this._penult.Next));
        this._penult = this._penult.Next;
    }

    public T Pop() {
        if (!IsEmpty()) {
            
        }
        return default(T);
    }
    
    public bool IsEmpty() {
        return _head == _penult;
    }
}