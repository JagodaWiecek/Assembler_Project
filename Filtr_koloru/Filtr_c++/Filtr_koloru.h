#pragma once
#ifdef FILTR_KOLORU_EXPORTS
#define FILTR_KOLORU_API __declspec(dllexport)
#else
#define FILTR_KOLORU_API __declspec(dllimport)

#endif
#include <string>

extern "C" FILTR_KOLORU_API void Filtr_color(int &rp, int &gp, int &bp, int number); 