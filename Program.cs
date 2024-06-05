﻿// See https://aka.ms/new-console-template for more information
decimal number1, number2;

Console.Write( "Enter number1 : " );
number1 = Convert.ToDecimal( Console.ReadLine() );

Console.Write( "Enter number2 : " );
number2 = Convert.ToDecimal( Console.ReadLine() );

Console.WriteLine( $"{number1} * {number2} = {number1*number2}" );
Console.WriteLine( $"{number1} - {number2} = {number1-number2}" );
Console.WriteLine( $"{number1} / {number2} = {number1/number2}" );
Console.WriteLine( $"{number1} + {number2} = {number1+number2}" );
Console.WriteLine( $"{number1} % {number2} = {number1%number2}" );
