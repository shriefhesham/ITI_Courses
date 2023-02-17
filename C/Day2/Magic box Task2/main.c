#include <stdio.h>
#include <stdlib.h>
#include <windows.h>
void gotoxy(int column , int line){
    COORD coord;
    coord.X=column;
    coord.Y=line;
    SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE),coord);

}
int main()
{
    int i,R,C,n;
    printf("Enter the N for the matrix\n");
    scanf("%d",&n);
    R=1;C=(n/2)+1;
    int NewRow=5+((n-1)*2);
    int NewCol=10+((n-1)*3);
    for(i=1;i<=(n*n);i++){
            if(n%2==0)
             {
               printf(" you must enter odd number  ! \n");
              break;
            }

        gotoxy(NewCol-((3-C)*3),NewRow-((3-R)*2));
        printf("%i",i);

        if(i%n==0)
            R++;
        else{
            R--;
            C--;
        }
            if(R==0)
                R=n;
            else if(R==n+1){
                R=1;
            }

            if(C==0)
                C=n;
            else if(C==n+1){
                C=1;
            }

    }

    return 0;
}
