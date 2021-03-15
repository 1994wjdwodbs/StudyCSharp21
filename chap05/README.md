# C# 기초
microsoft C# 가이드를 참고하였습니다.</br>
(https://docs.microsoft.com/ko-kr/dotnet/csharp/)

## 제어문
__- if문__

if 문은 부울 식의 값에 따라 실행할 문을 선택 합니다.

```csharp
if_statement
    : 'if' '(' boolean_expression ')' embedded_statement
    | 'if' '(' boolean_expression ')' embedded_statement 'else' embedded_statement
    ;
```

__- Switch 문__

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

__- While 문__

while 문은 조건에 따라 포함 문을 0번 이상 실행 합니다.

```csharp
while_statement
    : 'while' '(' boolean_expression ')' embedded_statement
    ;
```

__- Do-While 문__

do 문은 한 번 이상 포함된 문을 조건부로 실행 합니다.

```csharp
do_statement
    : 'do' embedded_statement 'while' '(' boolean_expression ')' ';'
    ;
```

__- For 문__

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

__- Foreach 문__

foreach 문은 컬렉션의 각 요소에 대해 포함 문을 실행 하여 컬렉션의 요소를 열거 합니다.

```csharp
foreach_statement
    : 'foreach' '(' local_variable_type identifier 'in' expression ')' embedded_statement
    ;
```

__- 점프 문__

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

__- Break 문__

break 문은 가장 가까운 바깥쪽 switch, while, do, for또는 foreach 문을 종료 합니다.

```csharp
break_statement
    : 'break' ';'
    ;
```

__- Continue 문__

continue 문은 가장 가까운 바깥쪽 while, do, for또는 foreach 문의 새 반복을 시작 합니다.

```csharp
continue_statement
    : 'continue' ';'
    ;
```

__- goto 문__

goto 문은 레이블로 표시 된 문으로 제어를 전달 합니다.

```csharp
goto_statement
    : 'goto' identifier ';'
    | 'goto' 'case' constant_expression ';'
    | 'goto' 'default' ';'
    ;
```

__- Return 문__

return 문은 return 문이 표시 되는 함수의 현재 호출자에 게 제어를 반환 합니다.

```csharp
return_statement
    : 'return' expression? ';'
    ;
```

__- Try 문__

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

__- Throw 문__

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

__- using 문__

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
