#include "stdafx.h"
#include <Windows.h>

typedef void (*Func)();

EXPORT void PrintString(const char* Str) {
	printf(">> %s\n", Str);
}

int _tmain(int argc, _TCHAR* argv[]) {
	PrintString("Loading .NET scripts");

	HMODULE NetLoader = LoadLibrary(L"NetLoader.dll");
	if (NetLoader == NULL) 
		return 1;

	Func Load = (Func)GetProcAddress(NetLoader, "Load");
	Func Unload = (Func)GetProcAddress(NetLoader, "Unload");

	if (Load == NULL || Unload == NULL)
		return 2;

	Load();
	Unload();

	printf("%s\n","Done!");
	getchar();
	return 0;
}