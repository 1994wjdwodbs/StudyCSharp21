# C# 기초
microsoft C# 가이드를 참고하였습니다.</br>
(https://docs.microsoft.com/ko-kr/dotnet/csharp/)

## 기본 자료형
- 정수형

| C# 형식/키워드 | 범위                                                   | Size                  | .NET 형식     |
|----------------|--------------------------------------------------------|-----------------------|---------------|
| sbyte          | -128 ~ 127                                             | 부호 있는 8비트 정수  | System.SByte  |
| byte           | 0 ~ 255                                                | 부호 없는 8비트 정수  | System.Byte   |
| short          | –32,768 ~ 32,767                                       | 부호 있는 16비트 정수 | System.Int16  |
| ushort         | 0 ~ 65,535                                             | 부호 없는 16비트 정수 | System.UInt16 |
| int            | –2,147,483,648 ~ 2,147,483,647                         | 부호 있는 32비트 정수 | System.Int32  |
| uint           | 0 ~ 4,294,967,295                                      | 부호 없는 32비트 정수 | System.UInt32 |
| long           | –9,223,372,036,854,775,808 ~ 9,223,372,036,854,775,807 | 부호 있는 64비트 정수 | System.Int64  |
| ulong          | 0 ~ 18,446,744,073,709,551,615                         | 부호 없는 64비트 정수 | System.UInt64 |

- 실수형

부동 소수점 숫자 형식 은 실수를 나타냅니다.</br>
모든 부동 소수점 숫자 형식은 값 형식입니다. 이것은 기본 형식이기도 하며, 리터럴로 초기화할 수 있습니다.</br> 
모든 부동 소수점 숫자 형식은 산술, 비교 및 같음 연산자를 지원합니다.

| C# 형식/키워드 | 근사 범위                     | 전체 자릿수      | Size     | .NET 형식      |
|----------------|-------------------------------|------------------|----------|----------------|
| float          | ±1.5 x 10−45 ~ ±3.4 x 1038    | ~6-9개 자릿수    | 4바이트  | System.Single  |
| double         | ±5.0 × 10−324 ~ ±1.7 × 10308  | ~15-17개 자릿수  | 8바이트  | System.Double  |
| decimal        | ±1.0 x 10-28 ~ ±7.9228 x 1028 | 28-29개의 자릿수 | 16바이트 | System.Decimal |

- 문자형

char 형식 키워드는 유니코드 UTF-16 문자를 나타내는 .NET System.Char 구조체 형식의 별칭입니다.</br>
(char 형식의 기본값은 \0(U + 0000)입니다.)

| 형식 | 범위          | Size   | .NET 형식   |
|------|---------------|--------|-------------|
| char | U+0000~U+FFFF | 16비트 | System.Char |

- 논리형

bool 형식 키워드는 부울 값(true 또는 false)을 나타내는 .NET System.Boolean 구조체 형식의 별칭입니다.</br>
bool 형식의 값을 사용하여 논리 연산을 수행하려면 부울 논리 연산자를 사용합니다. </br>
bool 형식은 비교 및 같음 연산자의 결과 형식입니다. bool 식은 if, do, while 및 for 문과 조건부 연산자?:에서 제어하는 조건식입니다.</br>
(bool 형식의 기본값은 false입니다.)

```chsarp
bool flag = true;
```

- 열거형

열거형(또는 열거형 형식)은 기본 정수 숫자 형식의 명명된 상수 집합에 의해 정의되는 값 형식입니다.</br>
열거형을 정의하려면 enum 키워드를 정의하고 열거형 멤버 의 이름을 지정합니다.
```csharp
enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter
}
```

- 구조체 형식

‘구조체 형식’은 데이터와 관련 기능을 캡슐화할 수 있는 값 형식입니다. 구조체 형식은 struct 키워드를 사용하여 정의합니다.

```csharp
public struct Coords
{
    public Coords(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double X { get; }
    public double Y { get; }

    public override string ToString() => $"({X}, {Y})";
}
```

- 배열

배열 데이터 구조에 형식이 동일한 변수를 여러 개 저장할 수 있습니다. 요소의 형식을 지정하여 배열을 선언합니다.</br>
배열이 모든 형식의 요소를 저장하도록 하려는 경우 object를 해당 형식으로 지정할 수 있습니다.</br>
C#의 통합 형식 시스템에서 모든 형식(사전 정의되거나 사용자 정의된 형식, 참조 형식, 값 형식)은 Object에서 직접 또는 간접적으로 상속합니다.

```csharp
type[] arrayName;
```
 
 - 튜플 형식

C# 7.0 이상에서 사용할 수 있는 ‘튜플’ 기능은 간단한 데이터 구조로 여러 데이터 요소를 그룹화하는 간결한 구문을 제공합니다.</br>
다음 예제에서는 튜플 변수를 선언하고 초기화하며 관련 데이터 멤버에 액세스하는 방법을 보여 줍니다.

```csharp
(double, int) t1 = (4.5, 3);
Console.WriteLine($"Tuple with elements {t1.Item1} and {t1.Item2}.");
// Output:
// Tuple with elements 4.5 and 3.

(double Sum, int Count) t2 = (4.5, 3);
Console.WriteLine($"Sum of {t2.Count} elements is {t2.Sum}.");
// Output:
// Sum of 3 elements is 4.5.
```

- NULL 허용 값 형식

Null 허용 값 형식 T?는 기본 값 형식 T의 모든 값과 추가 null 값을 나타냅니다.</br> 
예를 들어 bool? 변수에는 true, false, null 값 중 하나를 할당할 수 있습니다.</br>
기본 값 형식 T는 null 허용 값 형식 자체일 수 없습니다.</br>
(C# 7.0부터 is형식 패턴 포함 연산자를 사용하여 null 허용 값 형식의 인스턴스에서 null 여부를 검사하고 기본 형식의 값을 검색할 수 있습니다.)

```csharp
double? pi = 3.14;
char? letter = 'a';

int m2 = 10;
int? m = m2;

bool? flag = null;

// An array of a nullable value type:
int?[] arr = new int?[10];
```

- 참조 형식

 참조 형식의 변수에는 데이터(개체)에 대한 참조가 저장되며, 값 형식의 변수에는 해당 데이터가 직접 포함됩니다.</br>
 참조 형식에서는 두 가지 변수가 같은 개체를 참조할 수 있으므로 한 변수에 대한 작업이 다른 변수에서 참조하는 개체에 영향을 미칠 수 있습니다.</br> 
 값 형식에서는 각 변수에 데이터의 자체 사본이 들어 있으며 한 변수의 작업이 다른 변수에 영향을 미칠 수 없습니다.</br>
 (in, ref 및 out 매개 변수 제외, in, ref 및 out 매개 변수 한정자 참조)
 
 | class     |
 |-----------|
| interface |
| delegate  |
| record    |

## 형변환
*Conversion _을 사용 하면 식을 특정 형식으로 처리할 수 있습니다. 변환으로 인해 지정 된 형식의 식이 다른 형식으로 처리 될 수 있거나 형식이 없는 식이 형식을 가져올 수 있습니다.</br>
변환은 *암시적* 이거나 _ 명시적 * 일 수 있으며,이는 명시적 캐스트가 필요한 지 여부를 결정 합니다.

- 암시적 변환

다음 변환은 암시적 변환으로 분류 됩니다.

| Id 변환                   |
|---------------------------|
| 암시적 숫자 변환          |
| 암시적 열거형 변환        |
| 암시적 보간된 문자열 변환 |
| 암시적 null 허용 전환     |
| Null 리터럴 변환          |
| 암시적 참조 변환          |
| Boxing 변환               |
| 암시적 동적 변환          |
| 암시적 상수 식 변환       |
| 사용자 정의 암시적 변환   |
| 익명 함수 변환            |
| 메서드 그룹 변환          |

암시적 변환은 함수 멤버 호출 (동적 오버 로드 확인의 컴파일 시간 검사), 캐스트 식 (캐스트 식) 및</br> 
할당 (대입 연산자)을 포함하여 다양 한 상황에서 발생할 수 있습니다.

- 명시적 변환

다음 변환은 명시적 변환으로 분류 됩니다.

| 모든 암시적 변환입니다.        |
|--------------------------------|
| 명시적 숫자 변환               |
| 명시적 열거형 변환입니다.      |
| 명시적 nullable 변환.          |
| 명시적 참조 변환입니다.        |
| 명시적 인터페이스 변환입니다.  |
| Unboxing 변환.                 |
| 명시적 동적 변환               |
| 사용자 정의 명시적 변환입니다. |

캐스트 식 (캐스트 식)에서 명시적 변환이 발생할 수 있습니다.</br>
명시적 변환 집합에는 모든 암시적 변환이 포함 됩니다. 즉, 중복 캐스트 식이 허용 됩니다.</br>
암시적 변환이 아닌 명시적 변환은 항상 성공 여부를 입증할 수 없는 변환, 정보가 손실 될 수 있는 것으로 알려진 변환,</br>
강력한 형식의 도메인 간 변환 등의 다양 한 명시적 표기법으로 변환 됩니다.

## 제어문
- if문

if 문은 부울 식의 값에 따라 실행할 문을 선택 합니다.

```csharp
if_statement
    : 'if' '(' boolean_expression ')' embedded_statement
    | 'if' '(' boolean_expression ')' embedded_statement 'else' embedded_statement
    ;
```

- Switch 문

Switch 문은 스위치 식의 값에 해당 하는 연결 된 스위치 레이블이 있는 문 목록 실행을 위해 선택 합니다.

```csharp
switch_statement
    : 'switch' '(' expression ')' switch_block
    ;

switch_block
    : '{' switch_section* '}'
    ;

switch_section
    : switch_label+ statement_list
    ;

switch_label
    : 'case' constant_expression ':'
    | 'default' ':'
    ;
```

- While 문

while 문은 조건에 따라 포함 문을 0번 이상 실행 합니다.

```csharp
while_statement
    : 'while' '(' boolean_expression ')' embedded_statement
    ;
```

- Do-While 문

do 문은 한 번 이상 포함된 문을 조건부로 실행 합니다.

```csharp
do_statement
    : 'do' embedded_statement 'while' '(' boolean_expression ')' ';'
    ;
```

- For 문

for 문은 초기화 식의 시퀀스를 평가한 다음 조건이 true, 이면 포함문을 반복해서 실행하고 반복 식의 시퀀스를 계산 합니다.

```csharp
for_statement
    : 'for' '(' for_initializer? ';' for_condition? ';' for_iterator? ')' embedded_statement
    ;

for_initializer
    : local_variable_declaration
    | statement_expression_list
    ;

for_condition
    : boolean_expression
    ;

for_iterator
    : statement_expression_list
    ;

statement_expression_list
    : statement_expression (',' statement_expression)*
    ;
```

- Foreach 문

foreach 문은 컬렉션의 각 요소에 대해 포함 문을 실행 하여 컬렉션의 요소를 열거 합니다.

```csharp
foreach_statement
    : 'foreach' '(' local_variable_type identifier 'in' expression ')' embedded_statement
    ;
```

- 점프 문

점프 문이 제어를 전송 하는 위치를 점프 문의 대상 이라고 합니다.</br>
점프 문이 블록 내에서 발생 하 고 해당 점프 문의 대상이 해당 블록 외부에 있는 경우 점프 문이 블록을 종료 합니다.</br>
점프 문은 블록 밖으로 제어를 전송할 수 있지만 제어를 블록으로 전송할 수는 없습니다.

```chsarp
jump_statement
    : break_statement
    | continue_statement
    | goto_statement
    | return_statement
    | throw_statement
    ;
```

- Break 문

break 문은 가장 가까운 바깥쪽 switch, while, do, for또는 foreach 문을 종료 합니다.

```csharp
break_statement
    : 'break' ';'
    ;
```

- Continue 문

continue 문은 가장 가까운 바깥쪽 while, do, for또는 foreach 문의 새 반복을 시작 합니다.

```csharp
continue_statement
    : 'continue' ';'
    ;
```

- goto 문

goto 문은 레이블로 표시 된 문으로 제어를 전달 합니다.

```csharp
goto_statement
    : 'goto' identifier ';'
    | 'goto' 'case' constant_expression ';'
    | 'goto' 'default' ';'
    ;
```

- Return 문

return 문은 return 문이 표시 되는 함수의 현재 호출자에 게 제어를 반환 합니다.

```csharp
return_statement
    : 'return' expression? ';'
    ;
```

- Try 문

try 문은 블록을 실행 하는 동안 발생 하는 예외를 catch 하는 메커니즘을 제공 합니다.</br> 
또한 try 문은 컨트롤이 try 문을 벗어날 때 항상 실행 되는 코드 블록을 지정 하는 기능을 제공 합니다.

```csharp
try_statement
    : 'try' block catch_clause+
    | 'try' block finally_clause
    | 'try' block catch_clause+ finally_clause
    ;

catch_clause
    : 'catch' exception_specifier? exception_filter?  block
    ;

exception_specifier
    : '(' type identifier? ')'
    ;

exception_filter
    : 'when' '(' expression ')'
    ;

finally_clause
    : 'finally' block
    ;
```

- Throw 문

throw 문에서 예외를 throw 합니다.

```csharp
throw_statement
    : 'throw' expression? ';'
    ;
```

식이 포함 된 throw 문은 식을 계산 하 여 생성 된 값을 throw 합니다. 식은 System.Exception에서 파생 되는 클래스 형식의 값 이나</br>
해당 기본 클래스로 System.Exception 또는 하위 클래스가 있는 형식 매개 변수 형식의 System.Exception값을 나타내야 합니다.</br>
식의 평가가 null생성 되는 경우 System.NullReferenceException 대신 throw 됩니다.</br>
식이 없는 throw 문은 catch 블록 에서만 사용할 수 있습니다 .이 경우 해당 문은 해당 catch 블록에 의해 현재 처리 되 고 있는 예외를 다시 throw 합니다.

- using 문

using 문은 하나 이상의 리소스를 가져오고 문을 실행 한 다음 리소스를 삭제 합니다.

리소스 는 Dispose라는 매개 변수가 없는 단일 메서드를 포함 하는 System.IDisposable를 구현 하는 클래스 또는 구조체입니다.</br>
리소스를 사용 하는 코드는 Dispose를 호출 하 여 리소스가 더 이상 필요 하지 않음을 나타낼 수 있습니다. Dispose를 호출 하지 않으면 가비지 수집의 결과로 자동 삭제가 발생 합니다.
```csharp
using_statement
    : 'using' '(' resource_acquisition ')' embedded_statement
    ;

resource_acquisition
    : local_variable_declaration
    | expression
    ;
```

using 문은 획득, 사용 및 삭제의 세 부분으로 변환 됩니다. 리소스 사용은 finally 절을 포함 하는 try 문에 암시적으로 포함 됩니다.</br>
이 finally 절은 리소스를 삭제 합니다. null 리소스를 획득 하면 Dispose에 대 한 호출이 수행 되지 않고 예외가 throw 되지 않습니다.</br>
리소스가 형식 dynamic 경우에는 사용 및 삭제 전에 변환이 성공적으로 수행 되도록 하기 위해 인수를 사용 하는 동안 암시적 동적 변환</br>
(암시적 동적변환)을 통해 IDisposable으로 동적으로 변환 됩니다.

[이전](https://github.com/1994wjdwodbs/StudyCSharp21)
