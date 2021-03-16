# C# 추가 학습

microsoft C# 가이드, 닷넷정복(책)을 참고하였습니다.</br>
(https://docs.microsoft.com/ko-kr/dotnet/csharp/ , http://soen.kr/)

## 예외 처리

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


[이전](https://github.com/1994wjdwodbs/StudyCSharp21)
