#include <stdio.h>
#include <stdlib.h>

//Calculate average of each column in a 2D Array.

int main()
{
    int Arr[3][3] , Avg[3] = {0};
    int i ,j ;

    for( i=0 ; i<3 ; i++)
    {
        for (j=0 ; j < 3  ; j++ )
        {
            printf(" Enter integer neumber in row %i , coulmn %i :" , i+1 , j+1);
            scanf("%i" , &Arr[i][j]) ;
            Avg[j] +=  Arr[i][j];
        }
    }
/*
        for (j=0 ; j < 3  ; j++ )
             Avg[j] /=  3;
*/

        for (j=0 ; j < 3  ; j++ )
        {
            printf("Average of column %i : %i\n" , j+1 ,Avg[j]/= 3);
        }


    return 0;
}
