﻿Console.Clear();
//Console.SetCursorPosition(10, 4); // Отступ от левого и верхнего края в символах. Аргумент(левый,верхний)
//Console.WriteLine("+");

int xa = 40;
int ya = 1;
int xb = 1;
int yb = 30;
int xc = 60;
int yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa;

int count = 0;

while (count < 10000)
{
    int what = new Random().Next(0, 3): // [0;3) 0 1 2
    if (what == 0)
    {
        x = (x + xa) / 2;
        ya = (ya + ya) / 2;
    }

    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (what == 2)
    {
        x = (x + xc) / 2;
        ya = (ya + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count = count + 1; // count +=1; or count++ [в случае если увеличение на 1]
}