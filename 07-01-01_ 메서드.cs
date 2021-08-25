﻿using System;

// > 메서드(Method)? 
/// - 어떤 코드들을 하나의 이름 아래로 묶은것을 의미합니다.
/// - 이렇게 묶여진 코드는 이름을 불러서 호출할수 있습니다.
/// 호출 = 사용

// > 메서드 정의 방법
/// - 한정자 반환형식 메서드이름 (매개변수 목록...) {
///				호출 되었을 때 실행시킬 코드;
/// }

// > 한정자 : 메서드의 속성을 수식

// > 반환 형식 : 메서드의 반환 값이 어떤 형식인지 명시

// > 메서드 이름 : 메서드를 호출할 때 사용할 이름을 지정합니다.

// > 매개 변수 목록 : 메서드에서 사용할 데이터를 전달받아 저장하는 일

class _01__메서드
{
	// PrintHello() 메서드를 정의
	static void PrintHello()
	{
		// static : PrintHello() 메서드를 정적 메서드로 선언

		// void : PrintHello() 메서드가 반환값이 없다는 것을 의미
		// void 반환형 메서드는 보통 묶여진 코드를 실행말 할 때 사용합니다.
		Console.WriteLine("Hello!!!");
	}

	static void Main()
	{
		PrintHello();
	}
}