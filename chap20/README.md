# C# 추가 학습

위키피디아, 닷넷정복(책)을 참고하였습니다.</br>
(https://ko.wikipedia.org/wiki/%EC%9C%88%EB%8F%84%EC%9A%B0_%ED%8F%BC , http://soen.kr/)

## 윈도우 폼(WinForm)
윈도우 폼(Windows Forms, WinForms)은 현존하는 윈도우 API를 관리 코드로 래핑(wrapping)함으로써</br>
순수 마이크로소프트 윈도우 인터페이스 요소로의 접근성을 제공하는 마이크로소프트 닷넷 프레임워크의 일부로서 포함된 API에 주어지는 이름입니다.</br>
초기의 더 복잡한 C++ 기반 마이크로소프트 파운데이션 클래스(MFC) 라이브러리를 대체하는 것으로 볼 수 있으나,</br>
모델-뷰-컨트롤러와 상응하는 패러다임을 제공하지는 않습니다. 일부 3사 라이브러리가 이 기능을 제공하고 있습니다.</br>
이들 가운데 가장 널리 쓰이는 것으로는 사용자 인터페이스 프로세스 응용 프로그램 블록이 있습니다.

윈도우 폼은 메시지 구동 방식으로 동작합니다. 메시지의 종류나 발생 시점, 인수 등이 유사해 Win32의 메시지 구동 시스템과 별다른 차이가 없습니다. 
(다만 닷넷은 델리게이트를 이용하여 메시지 핸들러를 만듭니다.)</br>
함수도 거의 비슷하여 인수, 플래그 등을 그대로 쓰지만 오버로딩을 적극 활용하여 함수의 이름이 조금씩 다르고 클래스의 멤버로 소속된다는 형식적인 차이가 있습니다.</br>

윈도우 폼은 GDI+를 활용하여 그래픽 객체를 표시합니다. 하지만 프레임버퍼 동기화 없이는 애니메이션을 구현할 수 없고 3D 래스터화가 부족합니다.</br>
(더 많은 하드웨어 기능 접근을 위해 DirectX나 OpenGL을 사용합니다.)</br>

### 폼(Form)
폼(Form) 클래스는 사용자 인터페이스를 구성하는 기본 도구이며 System.Windows.Forms 네임스페이스에 정의되어 있습니다.</br>
Object -> MashalByRefObject -> Component -> Control -> ScrollableControl -> ContainerControl ->Form 계층으로 구성됩니다.

> 컴포넌트(Component) : 캡슐화에 의해 고유 기능을 제공하며 재사용성을 구현(프로세스, 타이머 등이 컴포넌트로부터 파생됨)</br>
> 자원을 명시적으로 해제하는 Dispose() 메소드를 제공
> 
> 컨트롤(Control) : 컴포넌트 중에 가시적으로 보이는 것. 화면에 스스로를 그리며 키보드/마우스 등의 장치로부터 입력받아 사용자와</br>
> 통신을 수행(버튼, 에디트/리스트 박스 등)
> 
> 폼 : 스크롤 기능과 다른 차일드 컨트롤을 포함하는 컨테이너 기능을 추가한 특수한 컨트롤(흔히 말하는 윈도우를 칭함)</br>
> 

Win32의 윈도우는 윈도우 폼의 Control과 대응되며, 윈도우와 관련된 프로퍼티와 메서드를 제공합니다.</br>
(윈도우 핸들인 HWND에 대응되는 Handle 프로퍼티가 Control에 정의되어 있습니다.)

### 애플리케이션(Application)
애플리케이션(Application) 클래스는 응용 프로그램 자체를 표현합니다. 공개된 생성자가 없어 객체를 생성할 수 없으며</br>
봉인(Sealed)되어 있어 상속도 할 수 없습니다.</br>

Application 클래스는 응용 프로그램의 시작과 종료, 메시지 처리, 정보 조사 등의 작업을 하는 정적 메서드와 프로퍼티를 제공합니다.</br>
(Application.Run() 메서드는 메인 폼이 닫힐 때까지 메시지 루프를 돌리며 실행을 계속합니다. 메시지 루프에 의해</br>
폼과 컨트롤로 메시지가 전달되어 처리되면서 프로그램이 실행됩니다. 메인 폼이 종료되면 Run() 메서드가 리턴되며</br>
Main()이 리턴하면서 응용 프로그램이 종료됩니다.)

[이전](https://github.com/1994wjdwodbs/StudyCSharp21)
