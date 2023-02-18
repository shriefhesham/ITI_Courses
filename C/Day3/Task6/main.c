#include <stdio.h>
#include <stdlib.h>

int main()
{
    int row,col;
    printf("Enter the number of rows and column for matrix 1 \n");
    scanf("%d %d",&row,&col);
    int arr1[row][col];
     printf("Enter the elements of the matrix\n");
    for(int i=0;i<row;i++)
    {
    for(int j=0;j<col;j++)
    {
         printf(" Enter integer neumber in row %i , coulmn %i :" , i+1 , j+1);
        scanf("%d",&arr1[i][j]);
    }
}
     int k ,q;

      printf("Enter the number of row and column for matrix 2 \n");
      scanf("%d %d",&q ,&k);
   int arr2[q][k];
      printf("Enter the elements of the matrix\n");
   for(int i=0;i<q;i++)
     {

         for(int j=0;j<k;j++)
        {

           scanf("%d",&arr2[i][j]);
        }
     }
    int arr3[row][k];
    for(int i=0;i<row;i++)
        {
            for(int j=0;j<k;j++)
            {
                arr3[i][j]=0;

                for(int k=0;k<q;k++)
                {
                    arr3[i][j]+=arr1[i][k]*arr2[k][j];
                }
            }
        }

          printf("\nElements in the matrix arr3 are \n");
      for(int i=0;i<3;i++)
       {
        for(int j=0;j<1;j++)
        {
            printf("%d ",arr3[i][j]);
        }
        printf("\n");
       }
    return 0;
}
