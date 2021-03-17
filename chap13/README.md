# C# 추가 학습

microsoft C# 가이드, 닷넷정복(책)을 참고하였습니다.</br>
(https://docs.microsoft.com/ko-kr/dotnet/csharp/ , http://soen.kr/)

## 대리자
대리자(delegate)는 메서드를 가리키는 참조형입니다. 메서드도 메모리에 존재하므로 위치를 가리키거나</br>
다른 메서드의 인수로 전달할 수 있습니다. C++의 함수 포인터에 대응하는 개념이되 타입 체크가 더 엄격하고</br>
클래스 소속의 메서드도 가리킬 수 있어 객체지향적입니다.

```csharp
지정자 delegate 리턴타입 이름(인수목록);
```

액세스 가능한 클래스 또는 대리자 형식과 일치하는 구조의 모든 메서드는 대리자에 할당할 수 있습니다.</br>
메서드는 정적 메서드이거나 인스턴스 메서드일 수 있습니다. 이러한 유연성은 프로그래밍 방식으로</br>
메서드 호출을 변경하거나 기존 클래스에 새 코드를 삽입할 수 있음을 의미합니다.</br>

대리자에서는 이와 같이 메서드를 매개 변수로 취급할 수 있으므로 __대리자는 콜백 메서드 정의에 이상적__ 입니다.</br>

__- 대리자 개요__

> 대리자는 C++ 함수 포인터와 유사하지만 C++ 함수 포인터와 달리 멤버 함수에 대해 완전히 개체 지향입니다.</br>
> 대리자는 개체 인스턴스 및 메서드를 모두 캡슐화합니다.
>
> 대리자를 통해 메서드를 매개 변수로 전달할 수 있습니다.</br>
> 
> 대리자를 사용하여 콜백 메서드를 정의할 수 있습니다.</br>
> 
> 여러 대리자를 연결할 수 있습니다. 예를 들어 단일 이벤트에 대해 여러 메서드를 호출할 수 있습니다.</br>
> 
> 메서드는 대리자 형식과 정확히 일치하지 않아도 됩니다. (자세한 내용은 대리자의 가변성 사용을 참조하세요.)</br>
> 
> 람다 식은 인라인 코드 블록을 작성하는 더욱 간단한 방법입니다. 특정 컨텍스트에서는 람다 식이 대리자 형식으로 컴파일됩니다.


[이전](https://github.com/1994wjdwodbs/StudyCSharp21)