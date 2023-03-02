/// <summary>
/// Универсальный класс <c>Node</c> моделирует односвязный узел.
/// </summary>
/// <typeparam name="T">Тип данных узла</typeparam>
public class Node<T> {
    /// <summary>
    /// Этот конструктор инициализирует новый экзмепляр класса 
    /// <c>Node&lt;<typeparamref name="T"/>&gt;</c> c (<paramref name="data"/>,<paramref name="next"/>)
    /// </summary>
    public Node(T data, Node<T> next) {
        this.Data = data;
        this.Next = next;
    }
    
    /// <value>
    /// Свойство Data хранит данные узла в типе 
    /// <typeparamref name="T"/>
    /// </value>
    public T Data {get; init;}

    /// <value>
    /// Свойство Next хранит ссылку на следующий узел
    /// </value>
    public Node<T> Next {get; private set;}

    
}