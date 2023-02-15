public class SimpleList<T> {
    public SimpleList(T data) {
        this._head = new Node<T>(data);
        this._last = this._head;
    }
    private Node<T> _head;
    private Node<T> _last;

    public void Push(T data) {
        this._last.Next = new Node<T>(data);
        this._last = this._last.Next;
    }

    /*public T Pop() {
        return new T;
    }//*/
}