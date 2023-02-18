#include <stdio.h>
#include <stdlib.h>

//3) Calculate sum of each row in a 2D Array.

int main()
{
    int Arr[3][3] , sum[3] = {0};
    int i ,j ;

    for( i=0 ; i<3 ; i++)
        for (j=0 ; j < 3 ; j++ )
        {
            printf(" Enter integer neumber in row %i , coulmn %i :" , i+1 , j+1);
            scanf("%d" , &Arr[i][j]) ;
              sum[i] += Arr[i][j];
        }

/*    for( i=0 ; i<3 ; i++)
        for (j=0 ; j < 5  ; j++ )
        {
            sum[i] += Arr[i][j];
        }
*/

    for( i=0 ; i<3 ; i++)
      {
         printf(" sum of row  %d = %d \n " , i+1 , sum[i] );
      }


    return 0;
}
