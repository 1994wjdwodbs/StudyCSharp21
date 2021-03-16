# C# 객체 지향 문법

microsoft C# 가이드를 참고하였습니다.</br>
(https://docs.microsoft.com/ko-kr/dotnet/csharp/)

## 프로퍼티(속성)
프로퍼티(속성)은 전용 필드의 값을 읽거나 쓰거나 계산하는 유연한 메커니즘을 제공하는 멤버입니다.</br>
공용 데이터 멤버인 것처럼 속성을 사용할 수 있지만, 실제로 접근자(accessors)라는 특수 메서드입니다.</br>
이렇게 하면 데이터에 쉽게 액세스할 수 있으며, 메서드의 안전성과 유연성 수준을 올리는 데 도움이 됩니다.

__- 프로퍼티 선언__

> 프로퍼티(속성)를 사용하면 클래스가 구현 또는 검증 코드를 숨기는 동시에 값을 가져오고 설정하는 방법을 공개적으로 노출할 수 있습니다.</br>
> 
> __get 속성__ 은 속성 값을 반환하는 데 사용되고, __set 속성__ 접근자는 새 값을 할당하는 데 사용됩니다.</br>
> 이러한 접근자는 각기 다른 액세스 수준을 가질 수 있습니다.  
> 
> __value 키워드__ 는 set 접근자가 할당하는 값을 정의하는 데 사용됩니다.
> 
> 프로퍼티는 __읽기/쓰기(read-write)__ (get 및 set 접근자 모두 포함), __읽기 전용(read_only)__ (get 접근자는 포함하지만 set 접근자는 포함 안 함)</br>
> 또는 __쓰기 전용(write-only)__ (set 접근자는 포함하지만 get 접근자는 포함 안 함)일 수 있습니다.</br> 쓰기 전용 프로퍼티는 거의 사용 빈도가 적고, 주로 중요한 데이터에 대한 액세스를 제한하는 데 사용됩니다.

```csharp
// Property 예제
using System;

public class SaleItem
{
   public string Name
   { get; set; }

   public decimal Price
   { get; set; }
}

class Program
{
   static void Main(string[] args)
   {
      var item = new SaleItem{ Name = "Shoes", Price = 19.95m };
      Console.WriteLine($"{item.Name}: sells for {item.Price:C2}");
   }
}
// The example displays output like the following:
//       Shoes: sells for $19.95
```

[이전](https://github.com/1994wjdwodbs/StudyCSharp21)
