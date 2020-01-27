// BasicsCPP.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <stdlib.h>
#include <stdio.h>
#include <iostream>

using namespace std;
void helloWorld();

int _tmain(int argc, _TCHAR* argv[])
{
	helloWorld();
	return 0;
}

void helloWorld()
{
	cout << "Hello World";
	cin.get();
}