#include <stdio.h>
#include <stdlib.h>

int main()
 {
    int n, sum = 0 ;
    int   i=0 ;
    while(sum<100)
    {
        printf("enter Your Number : ");
        scanf("%d",&n);
        sum = sum+n ;
        i++;
    }


    return 0;
}
