# C# 추가 학습

microsoft C# 가이드, 닷넷정복(책)을 참고하였습니다.</br>
(https://docs.microsoft.com/ko-kr/dotnet/csharp/ , http://soen.kr/)

## 제너릭
제너릭(Generic)은 타입 인수를 사용하여 일반화된 클래스나 메서드를 정의하는 기법입니다.</br>
내부 구조나 알고리즘은 동일하되 취급하는 타입만 다를 때 제너릭으로 한 번만 정의해두면 비슷한 클래스나</br>
메서드를 얼마든지 생성할 수 있습니다. (C++의 템플릿과 개념상 같지만, 비타입 인수/특수화/부분 특수화 등의 기능은</br>
제외하여 단순화한 것입니다.)</br>

코드의 재사용성을 높이고 타입 안전성을 극대화하는 장점이 있는 반면</br>
단점으로 프로그램이 비대해지고 가독성이 떨어지는 불리함이 있습니다.

```csharp
// Declare the generic class.
public class GenericList<T>
{
    public void Add(T input) { }
}
class TestGenericList
{
    private class ExampleClass { }
    static void Main()
    {
        // Declare a list of type int.
        GenericList<int> list1 = new GenericList<int>();
        list1.Add(1);

        // Declare a list of type string.
        GenericList<string> list2 = new GenericList<string>();
        list2.Add("");

        // Declare a list of type ExampleClass.
        GenericList<ExampleClass> list3 = new GenericList<ExampleClass>();
        list3.Add(new ExampleClass());
    }
}
```

제네릭 클래스 및 메서드는 제네릭이 아닌 클래스 및 메서드에서는 결합할 수 없는 방식으로 재사용성, 형식 안전성 및 효율성을 결합합니다.</br>

물론, 사용자 지정 제네릭 형식 및 메서드를 만들어 형식이 안전하고 효율적인 일반화된 솔루션 및 디자인 패턴을 직접 제공할 수도 있습니다.</br>
다음 코드 예제에서는 데모용으로 간단한 제네릭 연결된 목록 클래스를 보여 줍니다.</br>
(대부분의 경우 직접 만드는 대신 .NET에서 제공하는 List<T> 클래스를 사용해야 합니다.) 

```csharp
// 제너릭 사용 예시
public class GenericList<T>
{
    // The nested class is also generic on T.
    private class Node
    {
        // T used in non-generic constructor.
        public Node(T t)
        {
            next = null;
            data = t;
        }

        private Node next;
        public Node Next
        {
            get { return next; }
            set { next = value; }
        }

        // T as private member data type.
        private T data;

        // T as return type of property.
        public T Data
        {
            get { return data; }
            set { data = value; }
        }
    }

    private Node head;

    // constructor
    public GenericList()
    {
        head = null;
    }

    // T as method parameter type:
    public void AddHead(T t)
    {
        Node n = new Node(t);
        n.Next = head;
        head = n;
    }

    public IEnumerator<T> GetEnumerator()
    {
        Node current = head;

        while (current != null)
        {
            yield return current.Data;
            current = current.Next;
        }
    }
}
```

__- 제너릭 개요__

> 제네릭 형식을 사용하여 코드 재사용, 형식 안전성 및 성능을 최대화합니다.</br>
> 
> 가장 일반적으로 제네릭은 컬렉션 클래스를 만드는 데 사용됩니다.</br>
> 
> .NET 클래스 라이브러리에는 System.Collections.Generic 네임스페이스의 여러 제네릭 컬렉션 클래스가 포함됩니다.</br>
> 이러한 제네릭 컬렉션 클래스는 가능할 때마다 System.Collections 네임스페이스의 ArrayList처럼 클래스 대신 사용되어야 합니다.</br>
> 
> 사용자 고유의 제네릭 인터페이스, 클래스, 메서드, 이벤트 및 대리자를 만들 수 있습니다.</br>
> 
> 제네릭 클래스는 특정 데이터 형식의 메서드에 액세스할 수 있도록 제한될 수 있습니다.</br>
> 
> 제네릭 데이터 형식에 사용되는 형식에 대한 정보는 리플렉션을 사용하여 런타임 시 얻을 수 있습니다.</br>
> 

제네릭은 컬렉션 및 해당 컬렉션에서 작동하는 메서드에서 가장 자주 사용됩니다.</br>
System.Collections.Generic 네임스페이스에는 몇 가지 제네릭 기반 컬렉션 클래스가 있습니다.</br>
(ArrayList와 같은 제네릭이 아닌 컬렉션은 권장되지 않으며 호환성을 위해 유지 관리됩니다.)


### System.Collections.Generic 네임스페이스

제네릭 컬렉션을 정의하는 클래스와 인터페이스가 포함되어 있습니다. 이를 통해 사용자는 제네릭이 아닌 컬렉션보다</br>
형식 안전성과 성능이 높은 컬렉션을 만들 수 있습니다.

__- 클래스__

> __- CollectionExtensions__</br>
> 제네릭 컬렉션에 대한 확장 메서드를 제공합니다.

> __- Comparer<T>__</br>
> IComparer<T> 제네릭 인터페이스의 구현에 대한 기본 클래스를 제공합니다.
    
> __- Dictionary<TKey,TValue>.KeyCollection__</br>
> Dictionary<TKey,TValue>의 키 컬렉션을 나타냅니다. 이 클래스는 상속될 수 없습니다.

> __- Dictionary<TKey,TValue>.ValueCollection__</br>
> Dictionary<TKey,TValue>의 값 컬렉션을 나타냅니다. 이 클래스는 상속될 수 없습니다.

> __- Dictionary<TKey,TValue>__</br>
> 키와 값의 컬렉션을 나타냅니다.

> __- EqualityComparer__<T></br>
> IEqualityComparer<T> 제네릭 인터페이스의 구현에 대한 기본 클래스를 제공합니다.
    
> __- HashSet<T>__</br>
> 값 집합을 나타냅니다.
    
> __- KeyNotFoundException__</br>
> 컬렉션의 요소에 액세스하기 위해 지정한 키가 컬렉션의 키와 일치하지 않으면 예외가 throw됩니다.

> __- KeyValuePair__</br>
> KeyValuePair<TKey,TValue> 구조체의 인스턴스를 만듭니다.

> __- LinkedList__<T></br>
> 이중 연결 목록을 나타냅니다.
    
> __- LinkedListNode<T>__</br>
> LinkedList<T>의 노드를 나타냅니다. 이 클래스는 상속될 수 없습니다.
    
> __- List<T>__
> 인덱스로 액세스할 수 있는 강력한 형식의 개체 목록을 나타냅니다. 목록의 검색, 정렬 및 조작에 사용할 수 있는 메서드를 제공합니다.
    
> __- Queue<T>__
> 개체의 선입선출(FIFO) 컬렉션을 나타냅니다.
    
> __- ReferenceEqualityComparer__</br>
> 두 개의 개체 인스턴스를 비교할 때 값 동등성(Equals(Object)) 대신 참조 동등성(ReferenceEquals(Object, Object))을 사용하는 IEqualityComparer<T>입니다.
    
> __- SortedDictionary<TKey,TValue>.KeyCollection__</br>
> SortedDictionary<TKey,TValue>의 키 컬렉션을 나타냅니다. 이 클래스는 상속될 수 없습니다.

> __- SortedDictionary<TKey,TValue>.ValueCollection__</br>
> SortedDictionary<TKey,TValue>의 값 컬렉션을 나타냅니다. 이 클래스는 상속될 수 없습니다.

> __- SortedDictionary<TKey,TValue>__</br>
> 키에 따라 정렬된 키/값 쌍의 컬렉션을 나타냅니다.

> __- SortedList<TKey,TValue>__</br>
> 연관된 IComparer<T> 구현을 기반으로 키에 따라 정렬된 키/값 쌍의 컬렉션을 나타냅니다.
    
> __- SortedSet<T>__</br>
> 정렬된 순서대로 유지 관리되는 개체의 컬렉션을 나타냅니다.
    
> __- Stack<T>__</br>
> 지정한 동일 형식의 인스턴스로 이루어진 가변 크기 LIFO(후입선출) 방식의 컬렉션을 나타냅니다.
    
__- 구조체__

> __- Dictionary<TKey,TValue>.Enumerator__</br>
> Dictionary<TKey,TValue>의 요소를 열거합니다.

> __- Dictionary<TKey,TValue>.KeyCollection.Enumerator__</br>
> Dictionary<TKey,TValue>.KeyCollection의 요소를 열거합니다.

> __- Dictionary<TKey,TValue>.ValueCollection.Enumerator__</br>
> Dictionary<TKey,TValue>.ValueCollection의 요소를 열거합니다.

> __- HashSet<T>.Enumerator__</br>
> HashSet<T> 개체의 요소를 열거합니다.

> __- KeyValuePair<TKey,TValue>__</br>
> 설정하거나 검색할 수 있는 키/값 쌍을 정의합니다.

> __- LinkedList<T>.Enumerator__</br>
> LinkedList<T>의 요소를 열거합니다.

> __- List<T>.Enumerator__</br>
> List<T>의 요소를 열거합니다.

> __- Queue<T>.Enumerator__</br>
> Queue<T>의 요소를 열거합니다.

> __- SortedDictionary<TKey,TValue>.Enumerator__</br>
> SortedDictionary<TKey,TValue>의 요소를 열거합니다.

> __- SortedDictionary<TKey,TValue>.KeyCollection.Enumerator__</br>
> SortedDictionary<TKey,TValue>.KeyCollection의 요소를 열거합니다.

> __- SortedDictionary<TKey,TValue>.ValueCollection.Enumerator__</br>
> SortedDictionary<TKey,TValue>.ValueCollection의 요소를 열거합니다.

> __- SortedSet<T>.Enumerator__</br>
> SortedSet<T> 개체의 요소를 열거합니다.

> __- Stack<T>.Enumerator__</br>
> Stack<T>의 요소를 열거합니다.

__- 인터페이스__

> __- IAsyncEnumerable<T>__</br>
> 지정된 형식의 값에 대해 비동기 반복을 제공하는 열거자를 노출합니다.
    
> __- IAsyncEnumerator<T>__</br>
> 제네릭 컬렉션에 대한 간단한 비동기 반복을 지원합니다.
    
> __- ICollection<T>__</br>
> 제네릭 컬렉션을 조작할 메서드를 정의합니다.
    
> __- IComparer<T>__</br>
> 형식에서 두 개체를 비교하기 위해 구현하는 메서드를 정의합니다.
    
> __- IDictionary<TKey,TValue>__</br>
> 키/값 쌍의 제네릭 컬렉션을 나타냅니다.

> __- IEnumerable<T>__</br>
> 지정된 형식의 컬렉션을 단순하게 반복할 수 있도록 지원하는 열거자를 노출합니다.
    
> __- IEnumerator<T>__</br>
> 제네릭 컬렉션을 단순하게 반복할 수 있도록 지원합니다.
    
> __- IEqualityComparer<T>__</br>
> 개체가 같은지 비교할 수 있는 메서드를 정의합니다.
    
> __- IList<T>__</br>
> 개별적으로 인덱스에 의해 액세스될 수 있는 개체의 컬렉션을 나타냅니다.
    
> __- IReadOnlyCollection<T>__</br>
> 강력한 유형의 읽기 전용 요소 모음을 표현한다.
    
> __- IReadOnlyDictionary<TKey,TValue>__</br>
> 키/값 쌍의 제네릭 읽기 전용 컬렉션을 나타냅니다.

> __- IReadOnlyList<T>__</br>
> 인덱스로 액세스할 수 있는 요소의 읽기 전용 컬렉션을 나타냅니다.
    
> __- IReadOnlySet<T>__</br>
> 집합의 읽기 전용 추상화를 제공합니다.
    
> __- ISet<T>__</br>
> 집합 추상화를 위한 기본 인터페이스를 제공합니다.
    
