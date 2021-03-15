# C# 객체 지향 문법

microsoft C# 가이드를 참고하였습니다.</br>
(https://docs.microsoft.com/ko-kr/dotnet/csharp/)

## 클래스
클래스는 데이터 멤버 (상수 및 필드), 함수 멤버 (메서드, 속성, 이벤트, 인덱서, 연산자, 인스턴스 생성자, 소멸자 및 정적 생성자)</br>
및 중첩 형식이 포함 될 수 있는 데이터 구조입니다. 클래스 형식은 파생 클래스가 기본 클래스를 확장하고 특수화 할 수 있는 메커니즘인 상속을 지원 합니다.</br>

__- 클래스 선언__

Class_declaration 은 새 클래스를 선언 하는 type_declaration (형식 선언)입니다.

```csharp
class_declaration
    : attributes? class_modifier* 'partial'? 'class' identifier type_parameter_list?
      class_base? type_parameter_constraints_clause* class_body ';'?
    ;
```

Class_declaration 는 선택적 특성 집합 (특성)으로 구성되고, 선택적으로 class_modifiers (클래스 한정자)가 오고,</br>
그 뒤에 선택적 partial 한정자, 키워드 class, 클래스 이름을 지정 하는 식별자 , 선택적 type_parameter_list (형식 매개 변수),</br>
선택적인 class_base 사양 (클래스 기본 사양)이 차례로 옵니다. 선택적 type_parameter_constraints_clauses (형식 매개 변수 제약 조건)와</br>
class_body (클래스 본문)이 차례로 오고 그 뒤에 세미콜론을 추가 합니다.</br>

클래스 선언은 type_parameter_list를 제공 하지 않는 한 type_parameter_constraints_clause를 제공할 수 없습니다.</br>
Type_parameter_list 를 제공 하는 클래스 선언은 제네릭 클래스 선언입니다. 또한 제네릭 클래스 선언 또는 제네릭 구조체 선언 내에 중첩 된 모든 클래스는</br>
생성 된 형식을 만들기 위해 포함 하는 형식의 형식 매개 변수를 제공 해야 하기 때문에 제네릭 클래스 선언입니다.

__- 클래스 한정자__

Class_declaration 에는 선택적으로 클래스 한정자의 시퀀스가 포함 될 수 있습니다.

```csharp
class_modifier
    : 'new'
    | 'public'
    | 'protected'
    | 'internal'
    | 'private'
    | 'abstract'
    | 'sealed'
    | 'static'
    | class_modifier_unsafe
    ;
```

동일한 한정자가 클래스 선언에 여러 번 표시 되는 경우 컴파일 시간 오류가 발생 합니다.</br>
new 한정자는 중첩 클래스에서 허용 됩니다. 새 한정자에 설명 된 것 처럼 클래스가 상속 된 멤버를 동일한 이름으로 숨기도록 지정 합니다.</br> 
new 한정자가 중첩 된 클래스 선언이 아닌 클래스 선언에 표시 되는 컴파일 시간 오류입니다.</br>

public, protected, internal및 private 한정자는 클래스의 접근성을 제어 합니다.</br>
클래스 선언이 발생 하는 컨텍스트에 따라 이러한 한정자 중 일부가 허용 되지 않을 수 있습니다 (액세스 가능성이 선언됨).</br>

> __- 추상 클래스(abstract)__
> 
> abstract 한정자는 클래스가 완전 하지 않으며 기본 클래스로만 사용 될 것임을 나타내는 데 사용 됩니다. 추상 클래스는 다음과 같은 점에서 비추상 클래스와 다릅니다.</br>
> 추상 클래스는 직접 인스턴스화할 수 없으며, 추상 클래스에서 new 연산자를 사용 하는 컴파일 타임 오류입니다.</br>
> 컴파일 시간 형식이 추상 인 변수 및 값을 가질 수 있지만 이러한 변수 및 값은 반드시 null 되거나 추상 형식에서 파생 된 비추상 클래스의 인스턴스에 대 한 참조를 포함 해야 합니다.</br>
> 추상 클래스는 추상 멤버를 포함 하는 데 사용할 수 있지만 필수는 아닙니다.또한 추상 클래스는 sealed 일 수 없습니다.</br>

> __- 봉인 클래스(sealed)__
> 
> sealed 한정자는 클래스의 파생을 방지 하는 데 사용 됩니다. Sealed 클래스가 다른 클래스의 기본 클래스로 지정 된 경우 컴파일 시간 오류가 발생 합니다.</br>
> Sealed 클래스는 추상 클래스가 될 수도 없습니다.</br>
> sealed 한정자는 의도 하지 않은 파생을 방지 하는 데 주로 사용 되지만 특정 런타임 최적화도 가능 하 게 합니다.</br>
> 특히 sealed 클래스는 파생 클래스를 포함 하지 않는 것으로 알려져 있으므로 sealed 클래스 인스턴스에서 가상 함수 멤버 호출을 비가상 호출로 변환할 수 있습니다.</br>

> __- 정적 클래스(static)__
> 
> static 한정자는 정적 클래스로선언 되는 클래스를 표시 하는 데 사용 됩니다. 정적 클래스는 인스턴스화할 수 없고 형식으로 사용할 수 없으며</br> 
> 정적 멤버만 포함할 수 있습니다. 정적 클래스만 확장 > 메서드 (확장 메서드) 선언을 포함할 수 있습니다.
