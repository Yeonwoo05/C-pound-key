﻿using System;

// > 할당연산자
/// - 왼쪽피연산자(변수)에 오른쪽 피연산자 데이터를 할당하는 연산자입니다.
///   산술연산자, 비트연산자에 '='를 붙여서 사용합니다.

// > 산술연산자 + 할당연산자
/// - [ += , -=, *=, /=, %= ]
/// - 덧셈, 뺄셈, 곱샘, 나눗셈, 나머지 할당 연산자입니다.

// > 비트연산자 + 할당연산자
/// - [ &=, |=, ^=, <<=, >>= ]
/// - 논리곱, 논리합, 베타적 논리합, 왼쪽시프트, 오른쪽 시프트 할당 연산자입니다.


namespace _03_연산자._07_할당연산자
{
	class _01_할당연산자
	{
		static void Main()
		{
			int A = 10;
			int B = 20;

			// > A = A + B;
			A += B;
			Console.WriteLine("A = " + A);

			// > A = A - B;
			A -= B;
			Console.WriteLine("A = " + A);
		}
	}
}
