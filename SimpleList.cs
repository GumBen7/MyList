/// <summary>   
/// Универсальный класс <c>SimpleList</c> моделирует односвязный лист.
/// </summary>
/// <typeparam name="T">Тип элементов листа.</typeparam>
public class SimpleList<T> {
    /// <summary>
    /// Член <c>_head</c> хранит ссылку на головной узел листа
    /// </summary>
    private Node<T> _head;
    
    /// <summary>
    /// Член <c>_penult</c> хранит ссылку на предпоследний узел листа.
    /// </summary>
    private Node<T> _penult;
    
    /// <summary>
    /// Этот конструктор инициализирует новый пустой экземпляр класса
    /// <c>SimpleList&lt;<typeparamref name="T"/>&gt;</c>.
    /// </summary>
    public SimpleList() {
        this._penult = 
            new Node<T>(default(T), new Node<T>(default(T), null));
        this._head = this._penult;
    }

    /// <summary>
    /// Этот метод добавляет объект в конец 
    /// <c>SimpleList&lt;<typeparamref name="T"/>&gt;</c>.
    /// </summary>
    public void Push(T data) {
        this._penult.
        this._penult = this._penult.Next;
    }

    public T Pop() {
        if (!IsEmpty()) {
            Node<T> popped = this._head.Next;
            this._head.SetNext(popped.Next);
            T poppedData = popped.Data;
            popped = null;
            return poppedData;
        }
        return default(T);
    }
    
    /// <summary>
    /// Этот метод выполняет проверку на пустоту листа.
    /// </summary>
    /// <returns>
    /// True, если головной узел <c>_head</c> и предпоследний узел 
    /// <c>_penult</c> указывают на один и тот же объект; иначе, False
    /// </returns>
    public bool IsEmpty() => _head == _penult;
}