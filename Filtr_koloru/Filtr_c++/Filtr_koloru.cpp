#include "pch.h"
#include "Filtr_koloru.h"


void Filtr_color(int &rp, int &gp, int &bp, int number) 
{
	if (number ==1) 
	{
		if (rp<=255 && rp>=100 &&
			gp<=100 && gp>=0 &&
			bp<=100 && bp>=0)
		{
			rp = 255;
			gp = 0;
			bp = 0;
		}
		else
		{
			int suma = (rp + gp + bp)/3;
			rp = gp = bp = suma;
		}
	}
	else if (number ==2) 
	{
		if (rp <= 150 && rp >= 0 &&
			gp <= 255 && gp >= 0 &&
			bp <= 255 && bp >= 150)
		{
			rp = 0;
			gp = 0;
			bp = 255;
		}
		else
		{
			int suma = (rp + gp + bp) / 3;
			rp = gp = bp = suma;
		}
	}
	else if (number ==3)
	{
		if (rp <= 100 && rp >= 00 &&
			gp <= 255 && gp >= 50 &&
			bp <= 100 && bp >= 0)
		{
			rp = 0;
			gp = 255;
			bp = 0;
		}
		else
		{
			int suma = (rp + gp + bp) / 3;
			rp = gp = bp = suma;
		}
	}
}
//red red = <150-255> blue = <0-50> green = <0,50>
 //blue red = <0,25> blue = <200-255> green = <0-225>
//green red = <0-100> blue = <0-50> green = <150-255>