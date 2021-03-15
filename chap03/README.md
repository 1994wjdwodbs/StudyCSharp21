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

- 명시적 변환

[이전](https://github.com/1994wjdwodbs/StudyCSharp21)
