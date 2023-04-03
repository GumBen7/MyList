/// <summary>   
/// Универсальный класс <c>SimpleList</c> моделирует односвязный лист.
/// </summary>
/// <typeparam name="T">Тип элементов листа.</typeparam>
public class SimpleList<T> {
    /// <value>
    /// Свойство <c>Head</c> представляет головной узел тип
    /// <typeparamref name="T">.
    /// </value>
    private Node<T> Head { get; set; }
    /// <value>
    /// Свойство <c>Penult</c> представляет предпоследний узел типа.
    /// <typeparamref name="T">.
    /// </value>
    private Node<T> Penult { get; set; }

    /// <summary>
    /// Этот конструктор инициализирует новый пустой экземпляр класса
    /// <c>SimpleList&lt;<typeparamref name="T"/>&gt;</c>.
    /// </summary>
    public SimpleList() {
        // Лист создаётся с двумя обязательными узлами: последним и 
        // предпоследни. В пустом (новом) листе головной узел
        // указывает на предпоследний.
        this.Penult = 
            new Node<T>(default(T), new Node<T>(default(T), null));
        this.Head = this.Penult;
    }

    /// <summary>
    /// Этот метод добавляет объект в конец 
    /// <c>SimpleList&lt;<typeparamref name="T"/>&gt;</c>.
    /// </summary>
    public void Push(T data) {
        this.Penult.ChangeNext(new Node<T>(data, this.Penult.Next));
        this.Penult = this.Penult.Next;
    }

    /// <summary>
    // Этот метод изымает первый элемент
    /// <c>SimpleList&lt;<typeparamref name="T"/>&gt;</c>.
    /// </summary>
    /// <returns>
    /// Значение данных первого (удалённого) элемента.
    /// </returns>
    public T Pop() {
        if (!IsEmpty()) {
            var beingDeleted = this.Head;
            this.Head = this.Head.Next;
            beingDeleted = null;
            return this.Head.Data;
        }
        return default(T);
    }
    
    /// <summary>
    /// Этот метод выполняет проверку на пустоту листа.
    /// </summary>
    /// <returns>
    /// True, если головной узел <c>Head</c> и предпоследний узел 
    /// <c>Penult</c> указывают на один и тот же объект; иначе, False.
    /// </returns>
    public bool IsEmpty() => this.Head == this.Penult;
}