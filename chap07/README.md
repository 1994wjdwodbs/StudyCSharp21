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

클래스 선언에는 클래스의 직접 기본 클래스와 클래스에서 직접 구현 하는 인터페이스 (인터페이스)를 정의 하는 class_base 사양이 포함 될 수 있습니다.</br>

```csharp
class_base
    : ':' class_type
    | ':' interface_type_list
    | ':' class_type ',' interface_type_list
    ;

interface_type_list
    : interface_type (',' interface_type)*
    ;
```

클래스 선언에 지정 된 기본 클래스는 생성 된 클래스 형식 (생성 된형식)이 될 수 있습니다.</br>
범위에 있는 형식 매개 변수를 포함할 수 있지만 기본 클래스는 형식 매개 변수가 될 수 없습니다.

__- 필드__

필드는 개체 또는 클래스와 연결 된 변수를 나타내는 멤버입니다. Field_declaration 는 지정된 형식의 하나 이상의 필드를 소개합니다.

```csharp
field_declaration
    : attributes? field_modifier* type variable_declarators ';'
    ;

field_modifier
    : 'new'
    | 'public'
    | 'protected'
    | 'internal'
    | 'private'
    | 'static'
    | 'readonly'
    | 'volatile'
    | field_modifier_unsafe
    ;

variable_declarators
    : variable_declarator (',' variable_declarator)*
    ;

variable_declarator
    : identifier ('=' variable_initializer)?
    ;

variable_initializer
    : expression
    | array_initializer
    ;
```

Field_declaration 에는 특성 집합 (특성), new 한정자 (새 한정자), 네 가지 액세스 한정자 (액세스 한정자)의 유효한 조합 및 static 한정자 (정적 및 인스턴스 필드)가 포함 될 수 있습니다.

__- 정적 및 인스턴스 멤버__

클래스의 멤버는 정적 멤버 또는 인스턴스 멤버입니다. 일반적으로 정적 멤버를 개체 (클래스 형식의 인스턴스)에 속하는</br>
클래스 형식 및 인스턴스 멤버에 속하는 것으로 생각하면 유용합니다.</br>
필드, 메서드, 속성, 이벤트, 연산자 또는 생성자 선언에 static 한정자가 포함된 경우 정적 멤버를 선언합니다.</br>
또한 상수 또는 형식 선언은 정적 멤버를 암시적으로 선언합니다. 정적 멤버에는 다음과 같은 특징이 있습니다.

> 정적 멤버(M)가 member_access(멤버 액세스E.M)에서 참조되는 경우는 E를 포함하는 M 형식을 나타내야합니다. 인스턴스를 나타내는 E는 컴파일 타임 오류입니다.

> 정적 필드는 지정 된 폐쇄형 클래스 형식의 모든 인스턴스가 공유 하는 저장소 위치를 정확 하 게 식별 합니다.</br>
> 생성된 폐쇄형 클래스 형식의 인스턴스 수에 관계 없이 정적 필드의 복사본은 하나 뿐입니다.

> 정적 함수 멤버 (메서드, 속성, 이벤트, 연산자 또는 생성자)는 특정 인스턴스에서 작동 하지 않으며, 이러한 함수 멤버의 this을 참조 하는 것은 컴파일 타임 오류입니다.

__- 메서드__

메서드는 개체 또는 클래스에서 수행할 수 있는 계산이나 작업을 구현하는 멤버입니다. 메서드는 method_declarations를 사용하여 선언됩니다.

```csharp
method_declaration
    : method_header method_body
    ;

method_header
    : attributes? method_modifier* 'partial'? return_type member_name type_parameter_list?
      '(' formal_parameter_list? ')' type_parameter_constraints_clause*
    ;

method_modifier
    : 'new'
    | 'public'
    | 'protected'
    | 'internal'
    | 'private'
    | 'static'
    | 'virtual'
    | 'sealed'
    | 'override'
    | 'abstract'
    | 'extern'
    | 'async'
    | method_modifier_unsafe
    ;

return_type
    : type
    | 'void'
    ;

member_name
    : identifier
    | interface_type '.' identifier
    ;

method_body
    : block
    | '=>' expression ';'
    | ';'
    ;
```

Method_declaration 에는 특성 (특성) 집합, 네 가지 액세스 한정자인 new (새 한정자), static (정적 및 인스턴스 메서드),</br>
virtual (가상 메서드), override (재정의 메서드), sealed (봉인 된 메서드), abstract (추상 메서드) 및 extern (외부 메서드) 한정자가 포함 될 수 있습니다.

__- 정적 및 인스턴스 메서드__

메서드 선언에 static 한정자가 포함 된 경우 해당 메서드는 정적 메서드 라고 합니다.</br>
static 한정자가 없는 경우 메서드는 인스턴스 메서드 라고 합니다.</br>
정적 메서드는 특정 인스턴스에서 작동하지 않으며 정적 메서드에서 this를 참조 하는 컴파일 타임 오류입니다.</br>
인스턴스 메서드는 클래스의 지정 된 인스턴스에 대해 작동하며 이 인스턴스는 this (이 액세스)로 액세스할 수 있습니다.

__- 가상 메서드__

인스턴스 메서드 선언에 virtual 한정자가 포함 된 경우 해당 메서드는 가상 메서드 라고 합니다. virtual 한정자가 없는 경우</br>
이 메서드는 비가상 메서드 라고 합니다. 비가상 메서드의 구현은 고정입니다. 구현이 선언된 클래스의 인스턴스 또는 파생 클래스의 인스턴스에 대해</br>
메서드가 호출 되는지에 관계 없이 구현은 동일 합니다. 반면, 가상 메서드의 구현은 파생 클래스로 대체 될 수 있습니다.</br>
상속된 가상 메서드의 구현을 대체 하는 프로세스를 오버라이드 메서드 (Override 메서드) 라고 합니다.

__- 오버라이드 메서드__

인스턴스 메서드 선언에 override 한정자가 포함된 경우 메서드는 override 메서드라고 합니다.</br>
override 메서드는 시그니처가 같은 상속 된 가상 메서드를 재정의 합니다. 가상 메서드 선언은 새 메서드를 도입하지만,</br>
override 메서드 선언은 해당 메서드의 새 구현을 제공하여 기존의 상속된 가상 메서드를 특수화합니다.

__- Sealed 메서드__

인스턴스 메서드 선언에 sealed 한정자가 포함 된 경우 해당 메서드는 sealed 메서드라고 합니다.</br>
인스턴스 메서드 선언에 sealed 한정자가 포함 된 경우에는 override 한정자도 포함 해야 합니다.</br>
sealed 한정자를 사용 하면 파생 클래스가 메서드를 추가로 재정의 하지 않습니다.

__- 추상 메서드__

인스턴스 메서드 선언에 abstract 한정자가 포함 된 경우 해당 메서드는 추상 메서드라고 합니다.</br>
추상 메서드는 암시적이기도 하지만 virtual한정자를 사용할 수 없습니다.</br>
추상 메서드 선언은 새 가상 메서드를 도입 하지만 해당 메서드의 구현을 제공 하지 않습니다.</br>
대신, 해당 메서드를 재정의하여 고유한 구현을 제공 하려면 비추상 파생 클래스가 필요 합니다.</br>
추상 메서드는 실제 구현을 제공하지 않으므로 추상 메서드의 method_body는 세미콜론으로 구성됩니다.</br>
추상 메서드 선언은 추상 클래스에서만 사용할 수 있습니다.

__- 외부 메서드__

메서드 선언에 extern 한정자가 포함 된 경우 해당 메서드는 외부 메서드라고 합니다.</br>
외부 메서드는 일반적으로 이외의 C#언어를 사용하여 외부에서 구현 됩니다.</br> 
외부 메서드 선언은 실제 구현을 제공하지 않으므로 외부 메서드의 method_body는 세미콜론으로 구성 됩니다. 외부 메서드는 제네릭이 될 수 없습니다.</br>
extern 한정자는 일반적으로 Dll (동적 연결 라이브러리)에서 외부 메서드를 구현할 수 있도록 하는 DllImport 특성</br>
(COM 및 Win32 구성 요소와의 상호 운용)과 함께 사용 됩니다. 실행 환경에서는 외부 메서드 구현을 제공할 수 있는 다른 메커니즘을 지원할 수 있습니다.

__- 부분 메서드__

메서드 선언에 partial 한정자가 포함 된 경우 해당 메서드는 부분 메서드 (partial method) 라고 합니다.</br>
부분 메서드(partial types)의멤버만 선언할 수 있으며 여러 제한 사항이 적용 됩니다. 부분 메서드는 부분 메서드 (partialmethod)에 자세히 설명 되어 있습니다.

__- 생성자__

> __인스턴스 생성자__
> 
> 인스턴스 생성자는 클래스의 인스턴스를 초기화하는 데 필요한 작업을 구현하는 멤버입니다. 인스턴스 생성자는 constructor_declarations를 사용하여 선언됩니다.

```csharp
constructor_declaration
    : attributes? constructor_modifier* constructor_declarator constructor_body
    ;

constructor_modifier
    : 'public'
    | 'protected'
    | 'internal'
    | 'private'
    | 'extern'
    | constructor_modifier_unsafe
    ;

constructor_declarator
    : identifier '(' formal_parameter_list? ')' constructor_initializer?
    ;

constructor_initializer
    : ':' 'base' '(' argument_list? ')'
    | ':' 'this' '(' argument_list? ')'
    ;

constructor_body
    : block
    | ';'
    ;
```

> Constructor_declaration 에는 특성 집합, 네 가지 액세스 한정자 (액세스 한정자)의 유효한 조합 및 extern (외부 메서드) 한정자가 포함 될 수 있습니다.</br>
> 생성자 선언에는 동일한 한정자를 여러 번 포함할 수 없습니다.


__- 소멸자__

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
new 한정자가 중첩된 클래스 선언이 아닌 클래스 선언에 표시 되는 컴파일 시간 오류입니다.</br>

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

__- Partial 한정자__

partial 한정자는이 class_declaration 부분 형식 선언 임을 나타내는 데 사용 됩니다. 바깥쪽 네임 스페이스 또는 형식 선언 내에서</br>
이름이 같은 여러 부분 형식 선언이 결합 되어 부분 형식에 지정 된 규칙에 따라 하나의 형식 선언이 형성 됩니다.</br>
프로그램 텍스트의 개별 세그먼트에 분산 된 클래스 선언이 있으면 이러한 세그먼트를 여러 컨텍스트에서 생성 하거나 유지 관리 하는 경우 유용할 수 있습니다.</br>
예를 들어 클래스 선언의 한 부분은 컴퓨터에서 생성 될 수 있지만 다른 부분은 수동으로 작성 됩니다. 두 항목의 텍스트 분리는 업데이트와 충돌 하는 업데이트를 방지 합니다.



## 상속
클래스는 직접 기본 클래스 형식의 멤버를 상속 합니다. 상속은 기본 클래스의 인스턴스 생성자, 소멸자 및 정적 생성자를 제외하고,</br>
클래스에 직접 기본 클래스 형식의 모든 멤버를 암시적으로 포함 하는 것을 의미 합니다. 상속의 몇 가지 중요 한 측면은 다음과 같습니다.</br>

> __상속은 전이적입니다.__ C -> B, B -> A로 파생 되는 경우, A C에 선언 된 멤버와 B에 선언 된 멤버를 상속 합니다.

> __파생 클래스는 직접 기본 클래스를 확장합니다.__ 파생된 클래스를 상속하는 대상에 새 멤버를 추가할 수 있지만 상속된 멤버의 정의를 제거할 수 없습니다.
 
> __인스턴스 생성자, 소멸자 및 정적 생성자는 상속 되지 않지만 다른 모든 멤버는 엑세스 가능성에 상관없이 상속됩니다.__
> 그러나 선언 된 액세스 가능성에 따라 파생 된 클래스에서 상속 된 멤버에 액세스 하지 못할 수 있습니다.

> __파생된 클래스는 동일한 이름이나 서명으로 새 멤버를 선언하여 상속된 멤버를 숨길 수 있습니다.__</br>
>  그러나 상속된 멤버를 숨기면 해당 멤버가 제거 되지 않습니다. 단순히 해당 멤버를 파생 클래스를 통해 직접 액세스할 수 없게 만듭니다.
  
> __클래스의 인스턴스에는 클래스와 해당 기본 클래스에 선언된 모든 인스턴스 필드 집합이 포함되며, 파생된 클래스 형식에서</br>
> 해당 기본 클래스 형식으로의 암시적 변환 (암시적 참조 변환)__ 이 있습니다. 따라서 일부 파생 클래스의 인스턴스에 대한 참조는</br>
> 해당 기본 클래스의 인스턴스에 대 한 참조로 처리 될 수 있습니다.

> __클래스는 가상 메서드, 속성 및 인덱서를 선언할 수 있으며, 파생 클래스는 이러한 함수 멤버의 구현을 재정의할 수 있습니다.__</br>
>  이렇게 하면 클래스에서 함수 멤버 호출에 의해 수행 되는 작업은 해당 함수 멤버가 호출 되는 인스턴스의 런타임 형식에 따라 달라 지는 다형성 동작을 나타낼 수 있습니다.

생성된 클래스 형식의 멤버는 직접 기본 클래스 형식 (기본 클래스)의 멤버입니다.이 멤버는 생성된 형식의 형식 인수를 class_base 사양에 있는</br>
해당 형식 매개 변수의 각 항목에 대체하여 찾을 수 있습니다. 이러한 멤버는 멤버 선언의 각 type_parameter 에 대해 해당 class_base 사양의 type_argument 를 대체하여 변환됩니다.

```csharp
class B<U>
{
    public U F(long index) {...}
}

class D<T>: B<T[]>
{
    public T G(string s) {...}
}
```



[이전](https://github.com/1994wjdwodbs/StudyCSharp21)
