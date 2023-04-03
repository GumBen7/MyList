/// <summary>
/// Универсальный класс <c>Node</c> моделирует односвязный узел.
/// </summary>
/// <typeparam name="T">Тип данных узла.</typeparam>
public class Node<T> {
    /// <value>
    /// Свойство <c>Data</c> представляет данные узла типа
    /// <typeparamref name="T"/>.
    /// </value>
    public T Data { get; init; }

    /// <value>
    /// Свойство <c>Next</c> представляет ссылку на следющий узел.
    /// </value>    
    public Node<T> Next { get; private set; }  

    /// <summary>
    /// Этот конструктор инициализирует новый экзмепляр класса
    /// <c>Node&lt;<typeparamref name="T"/>&gt;</c> c данными
    /// <paramref name="data"/> и указателем на 
    /// объект <paramref name="next"/> в роли следующего.
    /// </summary>
    public Node(T data, Node<T> next) {
        this.Data = data;
        this.Next = next;
    }  

    /// <summary>
    /// Этот метод меняет ссылку на следующий узел.
    /// </summary>
    public void ChangeNext(Node<T> next) {
        this.Next = next;
    }
}