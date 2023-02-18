#include <stdio.h>
#include <stdlib.h>

//Calculate average of each column in a 2D Array.

int main()
{
    // initialize the Matrix
    int Matrix1[3][2];
    int Matrix2[2][1];

    printf("Enter the elements of the matrix 1\n");

    // loop of matrix 1 to scan it

    for(int i=0;i<3;i++)
    {
        for(int j=0;j<2;j++)
        {
            printf(" Enter integer neumber in row %i , coulmn %i :" , i+1 , j+1);
            scanf("%d",&Matrix1[i][j]);
        }
    }
    printf("\nElements in the matrix 2\n");

    // loop to print Matrix

    for(int i=0;i<3;i++)
   {
        for(int j=0;j<2;j++)
        {

            printf("%d ",Matrix1[i][j]);
        }
        printf("\n");
    }

    printf("Enter the elements of the matrix 2 \n");

    // loop of matrix 2 to scan it

    for(int i=0;i<2;i++)
    {
        for(int j=0;j<1;j++)
        {
             printf(" Enter integer neumber in row %i , coulmn %i :" , i+1 , j+1);
            scanf("%d",&Matrix2[i][j]);
        }
    }
    printf("\nElements in the matrix 2 \n");

     // loop to print Matrix

    for(int i=0;i<2;i++)
   {
        for(int j=0;j<1;j++)
        {
            printf("%d ",Matrix2[i][j]);
        }
        printf("\n");
    }


      int matrix3[3][1];

      for(int i=0;i<3;i++)
        {
            for(int j=0;j<1;j++)
            {
                matrix3[i][j]=0;

                for(int k=0;k<2;k++)
                {
                    matrix3[i][j]+=Matrix1[i][k]*Matrix2[k][j];
                }
            }
        }

    printf("\nElements in the matrix3 \n");
    for(int i=0;i<3;i++)
   {
        for(int j=0;j<1;j++)
        {
            printf("%d ",matrix3[i][j]);
        }

    }
}
