# C# 추가 학습

microsoft C# 가이드, 닷넷정복(책)을 참고하였습니다.</br>
(https://docs.microsoft.com/ko-kr/dotnet/csharp/ , http://soen.kr/)

## LINQ
LINQ(Language INtegrated Query) 는 C# 언어에 직접 쿼리 기능을 통합하는 방식을 기반으로 하는 기술 집합 이름입니다.</br>
일반적으로 데이터에 대한 쿼리는 컴파일 시간의 형식 검사나 IntelliSense 지원 없이 간단한 문자열로 표현됩니다.</br>
또한 데이터 원본의 각 유형에 대해 다른 쿼리 언어를 배워야 합니다. SQL 데이터베이스, XML 문서, 다양한 웹 서비스 등.</br>
LINQ를 사용할 경우 쿼리는 클래스, 메서드, 이벤트와 같은 고급 언어 구문이 됩니다.</br>
언어 키워드 및 친숙한 연산자를 사용하여 강력한 형식의 개체 컬렉션에 대해 쿼리를 작성합니다.</br>
LINQ 기술은 개체(LINQ to Objects), 관계형 데이터베이스(LINQ to SQL) 및 XML(LINQ to XML)에 대한 일관성 있는 쿼리 환경을 제공합니다.</br>

SQL Server 데이터베이스, XML 문서, ADO.NET 데이터 세트 및 IEnumerable 또는 제네릭 IEnumerable<T> 인터페이스를 지원하는 모든 개체 컬렉션에 대해 C#으로 LINQ 쿼리를 작성할 수 있습니다. 
  
```csharp
// LINQ 예시
class LINQQueryExpressions
{
    static void Main()
    {

        // Specify the data source.
        int[] scores = new int[] { 97, 92, 81, 60 };

        // Define the query expression.
        IEnumerable<int> scoreQuery =
            from score in scores
            where score > 80
            select score;

        // Execute the query.
        foreach (int i in scoreQuery)
        {
            Console.Write(i + " ");
        }
    }
}
// Output: 97 92 81
```
__- 쿼리 식 개요__

> 쿼리 식은 LINQ 사용 데이터 소스에서 데이터를 쿼리하고 변환하는 데 사용할 수 있습니다.</br>
> 예를 들어 단일 쿼리로 SQL 데이터베이스에서 데이터를 검색하고 XML 스트림을 출력으로 생성할 수 있습니다.</br>
> 
> 쿼리 식은 익숙한 C# 언어 구문을 많이 사용하기 때문에 쉽게 마스터할 수 있습니다.</br>
> 
> 대부분의 경우 컴파일러가 형식을 유추할 수 있기 때문에 명시적으로 형식을 제공할 필요는 없지만</br>
> 쿼리 식의 변수는 모두 강력한 형식을 갖습니다. 
> 
> 쿼리는 쿼리 변수를 반복할 때까지(예: foreach 문) 실행되지 않습니다.
> 
> 컴파일 타임에 쿼리 식은 C# 사양에 명시된 규칙에 따라 표준 쿼리 연산자 메서드 호출으로 변환됩니다.</br>
> 쿼리 구문을 사용하여 표현할 수 있는 모든 쿼리는 메서드 구문으로도 표현할 수 있습니다.</br>
> 그러나 대부분의 경우 쿼리 구문이 더 읽기 쉽고 간결합니다.
> 
> 일반적으로 LINQ 쿼리를 작성하는 경우 가능하면 쿼리 구문을 사용하고 필요한 경우 메서드 구문을 사용하는 것이 좋습니다.</br>
> 두 개의 다른 폼 간에 의미 체계 또는 성능상의 차이는 없습니다. 쿼리 식이 메서드 구문으로 작성된 동급의 식보다 읽기 쉬운 경우가 많습니다.
> 
> Count 또는 Max와 같은 일부 쿼리 작업은 해당하는 쿼리 식 절이 없으므로 메서드 호출로 표현해야 합니다.</br>
> 메서드 구문을 다양한 방법으로 쿼리 구문에 조합할 수 있습니다.
> 
> 쿼리 식은 쿼리가 적용되는 형식에 따라 식 트리 또는 대리자로 컴파일될 수 있습니다. IEnumerable<T> 쿼리는 대리자로 컴파일됩니다.</br>
>  IQueryable 및 IQueryable<T> 쿼리는 식 트리로 컴파일됩니다.


[이전](https://github.com/1994wjdwodbs/StudyCSharp21)
