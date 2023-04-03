/// <summary>   
/// Универсальный класс <c>SimpleList</c> моделирует односвязный лист.
/// </summary>
/// <typeparam name="T">Тип элементов листа.</typeparam>
public class SimpleList<T> {
    /// <value>
    /// Свойство <c>Head</c> представляет головной узел с данными типа
    /// <typeparamref name="T"/>; головной узел всегда указывает
    /// на незначимый объект листа.
    /// </value>
    private Node<T> Head { get; set; }
    /// <value>
    /// Свойство <c>Penult</c> представляет предпоследний узел с данными типа
    /// <typeparamref name="T"/>; предпоследний узел в пустом листе 
    /// указывает на незначимый объект.
    /// </value>
    private Node<T> Penult { get; set; }

    /// <summary>
    /// Этот конструктор инициализирует новый пустой экземпляр класса
    /// <c>SimpleList&lt;<typeparamref name="T"/>&gt;</c>.
    /// </summary>
    public SimpleList() {
        // Лист создаётся с двумя обязательными узлами: последним и 
        // предпоследний; в пустом (новом) листе головной узел
        // указывает на предпоследний; лист начинается с следующего 
        // узла после головного; предпоследний 
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
    /// Этот метод изымает первый элемент
    /// <c>SimpleList&lt;<typeparamref name="T"/>&gt;</c>.
    /// </summary>
    /// <returns>
    /// Значение данных первого (удалённого) элемента, если лист не пустой; 
    /// иначе, значение по умолчанию типа <typeparamref name="T"/>
    /// </returns>
    public T Pop() {
        if (!IsEmpty()) {
            var beingCleared = this.Head;
            this.Head = this.Head.Next;
            beingCleared = null;
            // Головной узел уже указывает на незначимый, удалённый элемент;
            return this.Head.Data;
        }
        return default(T);
    }
    
    /// <summary>
    /// Этот метод выполняет проверку на пустоту листа.
    /// </summary>
    /// <returns>
    /// True, если лист пустой; иначе, False.
    /// </returns>
    // Лист считается пустым, если головной узел Head и предпоследний 
    // узел Penult указывают на один и тот же объект.
    public bool IsEmpty() => this.Head == this.Penult;
}