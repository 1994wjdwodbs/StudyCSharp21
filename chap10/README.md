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
제네릭은 컬렉션 및 해당 컬렉션에서 작동하는 메서드에서 가장 자주 사용됩니다.</br>
System.Collections.Generic 네임스페이스에는 몇 가지 제네릭 기반 컬렉션 클래스가 있습니다.</br>
(ArrayList와 같은 제네릭이 아닌 컬렉션은 권장되지 않으며 호환성을 위해 유지 관리됩니다.)

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
