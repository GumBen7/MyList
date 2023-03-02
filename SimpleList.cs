/// <summary>   
/// Универсальный класс <c>SimpleList</c> моделирует односвязный лист.
/// </summary>
/// <typeparam name="T">Тип элементов листа.</typeparam>
public class SimpleList<T> {
    /// <summary>
    /// Член <c>_head</c> типа <c>Node</c> хранит ссылку на головной
    /// узел листа; данные узла имеют тип: <typeparamref name="T"/>.
    /// </summary>
    private Node<T> _head;
    
    /// <summary>
    /// Член <c>_penult</c> типа <c>Node</c> хранит ссылку на
    /// предпоследний узел листа; данные узла имеют тип:
    /// <typeparamref name="T"/>.
    /// </summary>
    private Node<T> _penult;
    
    /// <summary>
    /// Этот конструктор инициализирует новый пустой экземпляр класса
    /// <c>SimpleList&lt;<typeparamref name="T"/>&gt;</c>.
    /// </summary>
    /// <remarks>
    /// Создаёт два экземпляра узлов универсального типа <c>Node</c> 
    /// </remarks>
    public SimpleList() {
        this._penult = 
            new Node<T>(default(T), new Node<T>(default(T), null));
        this._head = this._penult;
    }

    /// <summary>
    /// Этот метод доба
    /// </summary>
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
    
    /// <summary>
    /// Этот метод выполняет проверку на пустоту листа.
    /// </summary>
    /// <returns>
    /// True, если головной узел <c>_head</c> и предпоследний узел 
    /// <c>_penult</c> указывают на один и тот же объект; иначе, False
    /// </returns>
    public bool IsEmpty() => _head == _penult;
}