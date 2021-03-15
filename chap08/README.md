# C# 객체 지향 문법

microsoft C# 가이드를 참고하였습니다.</br>
(https://docs.microsoft.com/ko-kr/dotnet/csharp/)

## 인터페이스
인터페이스는 계약을 정의합니다. 클래스 또는 구조체는 인터페이스를 구현 하는 계약을 따라야 합니다.</br>
여러 기본 인터페이스에서 상속할 수 및 클래스 또는 구조체는 여러 인터페이스를 구현할 수 있습니다.</br>
인터페이스는 메서드, 속성, 이벤트 및 인덱서를 포함할 수 있습니다. 자체 인터페이스를 정의 하는 멤버에 대한 구현을 제공 하지 않습니다.</br>
인터페이스는 단순히 인터페이스를 구현 하는 클래스 또는 구조체에서 제공 해야 하는 멤버를 지정 합니다.

__- 인터페이스 선언__

```csharp
interface_declaration
    : attributes? interface_modifier* 'partial'? 'interface'
      identifier variant_type_parameter_list? interface_base?
      type_parameter_constraints_clause* interface_body ';'?
    ;
```

__- 인터페이스 멤버__

인터페이스의 멤버는 기본 인터페이스에서 상속 된 멤버 및 멤버 자체 인터페이스에서 선언 합니다.

```csharp
interface_member_declaration
    : interface_method_declaration
    | interface_property_declaration
    | interface_event_declaration
    | interface_indexer_declaration
    ;
```

인터페이스 선언 0 개 이상의 멤버를 선언할 수 있습니다. 메서드, 속성, 이벤트 또는 인덱서는 인터페이스의 멤버 여야 합니다.</br>
인터페이스는 상수, 필드, 연산자, 인스턴스 생성자, 소멸자 또는 형식을 포함할 수 없으며 인터페이스로 모든 종류의 정적 멤버를 포함할 수 있습니다.</br>
모든 인터페이스 멤버는 암시적으로 공용 액세스를 갖습니다. 특히 한정자를 사용하여 인터페이스 멤버를 선언할 수 없습니다.</br>
(abstract, public, protected, internal, private, virtual override, static)

```csharp
// 예시
public delegate void StringListEvent(IStringList sender);

public interface IStringList
{
    void Add(string s);
    int Count { get; }
    event StringListEvent Changed;
    string this[int index] { get; set; }
}
```




