#include <stdio.h>
#include <stdlib.h>
#include <windows.h>

 // Magic Box Task

void gotoxy( int column, int line )
  {
  COORD coord;
  coord.X = column;
  coord.Y = line;
  SetConsoleCursorPosition(
    GetStdHandle( STD_OUTPUT_HANDLE ),
    coord
    );
  }


int main()
{
   int i , C ,R ;
   int newRow=5+((3-1)*2);
   int NewCol=10+((3-1)*3);
   R = 1 ;  C = (3/2)+1 ;
   for ( i = 1 ; i <= 9 ; i++)
   {
   // gotoxy(C,R);
    gotoxy(NewCol-((3-C)*3),newRow-((3-R)*2));
    printf("%i" ,i);

    if (i%3==0)
        R++;
    else
    {
        C--;
        R--;
    }
    if (R==4)
        R=1;
    else if (R==0)
        R=3;

    if (C==4)
        C=1;
    else if (C==0)
        C=3;
}
    return 0;
}
