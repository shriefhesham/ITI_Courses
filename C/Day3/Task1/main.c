#include <stdio.h>
#include <stdlib.h>

//  1) Input and output an array using 2 for loops.

int main()
{
    int size ,i;
    printf("Enter Size of Array :");
    scanf("%d",&size);
    int Arr[size];
    printf("Enter Element of Array %d: " ,i+1);
    for (i =0 ; i < size ; i++ )
    {
        scanf("%d",&Arr[i]);
    }

    for (i =0 ; i < size ; i++ )
    {
        printf("%d",Arr[i]);
    }

    return 0;
}
