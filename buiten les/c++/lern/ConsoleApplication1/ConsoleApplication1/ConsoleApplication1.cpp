// ConsoleApplication1.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include <iostream>
#include <string>

// zorgt ervoor dat je niet telkens "std" moet tiepen voor elke cout (output)
using namespace std;
int main()
{
					//  vars
//	int - stores integers(whole numbers), without decimals, such as 123 or -123
//	double - stores floating point numbers, with decimals, such as 19.99 or -19.99
//	char - stores single characters, such as 'a' or 'B'.Char values are surrounded by single quotes
//	string - stores text, such as "Hello World".String values are surrounded by double quotes
//	bool - stores values with two states : true or false

				// output 
	int num1 = 6;
	int num2 = 9;
	int num3 = num1 + num2;

	// cout is output 
		//add "cout << "text" << varName <<"text";"
	cout << " 6 + 9 = " << num3  <<"\n";


	 num1 = 6;
	 num2 = 9;
	 num3 = num1 * num2;

	// cout is output 
		//add "cout << "text" << varName <<"text";"
	cout << " 6 - 9 = " << num3 << "\n";
	num1 = 6;
	num2 = 9;
	num3 = num1 - num2;

	// cout is output 
		//add "cout << "text" << varName <<"text";"
	cout << " 6 * 9 = " << num3 << "\n";

	num1 = 6;
	num2 = 9;
	num3 = num1 / num2;

	// cout is output 
		//add "cout << "text" << varName <<"text";"
	cout << " 6 / 9 = " << num3 << "\n";
	cout << "Output sentence"; // prints Output sentence on screen
	cout << 120;               // prints number 120 on screen
	cout << num3;                 // prints the value of x on screen 
	cout << "what is your age ";

					// input 


	int age;
	cin >> age;
	cout << "\n you just claimed that your age is" << age;
	

	int i;
	cout << "\n Please enter an integer a second value: ";
	cin >> i;
	cout << "\n The value you entered is " << i;
	cout << "\n and its double is " << i * 2 << ".\n";
	return 0;
	// --------------------------------------------------------------------------
	string mystr;
	cout << "What's your name? ";
	getline(cin, mystr);
	cout << "Hello " << mystr << ".\n";
	cout << "What is your favorite team? ";
	getline(cin, mystr);
	cout << "I like " << mystr << " too!\n";
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
