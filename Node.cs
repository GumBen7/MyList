/// <summary>
/// Универсальный класс <c>Node</c> моделирует узел листа.
/// </summary>
/// <typeparam name="T">Тип данных узла</typeparam>
public class Node<T> {
    /// <summary>
    /// Этот конструктор 
    /// </summary>
    public Node(T data, Node<T> next) {
        this.Data = data;
        this.Next = next;
    }
    
    /// <value>
    /// Свойство 
    /// </value>
    public T Data {get; init;}

    /// <value>
    /// Свойство 
    /// </value>
    public Node<T> Next {get; private set;}
}