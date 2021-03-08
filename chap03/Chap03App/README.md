# HTML 기본학습

## 웹 페이지 기본 구조와 작성 방법
태그, 요소, 속성의 의미 이해 및 HTML, CSS, JS 작성방법 따라하기

## HTML5 기본 태그
```html
<!DOCTYPE html>
<html>
    <head>
        <title>HTML5 + CSS3 TEXT</title>
    </head>

    <body>
        <h1>제목 글자 태그 1</h1>
        <h2>제목 글자 태그 2</h2>
        <h3>제목 글자 태그 3</h3>
        <h4>제목 글자 태그 4</h4>
        <h5>제목 글자 태그 5</h5>
        <p>Paragraphs 문장</p>
        <h6>제목 글자 태그 6</h6>
        <p><i><b><small>
            <h1>Lorem</h1></small> <sub>ipsum</sub> <sup>dolor</sup>, sit amet consectetur adipisicing elit.
             Obcaecati adipisci maxime accusamus, quis, </b>
             praesentium ipsam omnis sint molestiae similique, </i><br>
             doloribus cum incidunt ex voluptatem quam. 
             Fugit sapiente sed recusandae? Doloremque?
        </p>
        <hr>
        <a href="https://www.naver.com" target="_blank">NAVER</a><br>
        <!-- _blank : 새 창에서 열기 -->
        <a href="https://www.youtube.com" target="_parent"> Youtube</a><br>
        <a href="https://www.microsoft.com" target="_parent"> Microsoft</a><br>
        <a href="mailto:16jwodbs@naver.com" target=""> 정재윤 이메일</a>
    </body>

</html>
```

## HTML5 기본 태그

## HTML5 입력 양식 태그
```html
<!DOCTYPE html>
<html>
<head>
    <meta charset='utf-8'>
    <meta http-equiv='X-UA-Compatible' content='IE=edge'>
    <title>Page Title</title>
    <meta name='viewport' content='width=device-width, initial-scale=1'>
</head>
<body>
    <!-- 사용자 입력 양식 -->
    <form>
        <input type="text" name="txt_userid" value="personar95"><br>
        <input type="password" name="password" value="12345"><br>
        <input type="file" name="attach_file"><br>
        <input type="checkbox" name="chk_hobby_swim" value="SWIM">수영<br>
        <input type="checkbox" name="chk_hobby_marathon" value="MARATHON">마라톤<br>
        <input type="radio" name="rdo_gender" value="M">남자
        <input type="radio" name="rdo_gender" value="F">여자
        <input type="radio" name="rdo_gender" value="G">중성<br>

        <!--<input type="datetime" name="dt_today" value="2021-01-28 14:50:00"><br>-->
        
        <!-- 보이지 않는 양식 -->
        <input type="hidden" name="hdn_temp_val" value="25683252923"><br>
        <!-- 버튼 -->
        <input type="button" name="btn_normal" value="버튼"><br>
        <input type="reset" name="btn_reset" value="리셋"><br>
        <input type="submit" name="btn_submit" value="제출"><br>
        <!-- 기타 -->
        <input type="image" src="https://placehold.it/400x250"><br>

    </form>
    <!-- 사용자 입력 양식 -->
</body>
```
## HTML5 구조화 태그

[이전](https://github.com/1994wjdwodbs/StudyCSharp21)
