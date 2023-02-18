#include <stdio.h>
#include <stdlib.h>

int main()
{
    /*
    int i, max =0, min , size;

    printf("Enter size of the array : \n");
    scanf("%d", &size);
    int arr[size];


    for(i=0; i<size; i++)
    {
        printf("Enter elements in the array %i :" , i+1);
        scanf("%d", &arr[i]);
    }

    for(i=0; i<size; i++)
    {

        if(arr[i] > max)
        {
            max = arr[i];
        }
    }

    for(int j =0 ; j<size ; j++)
    {
         if(arr[j] < min)
        {
            min = arr[j];
        }
    }


    printf("Maximum element = %d\n", max);
    printf("Minimum element = %d \n", min);

*/
    int max =0;
    int min;

    int arr[10]={1,2,3,4,5,6,7,8,9,10};
    for(int i=0;i<10;i++){
        if(arr[i]>max){
            max=arr[i];
        }
    }
    for(int j=0;j<11;j++){
        if(arr[j]<min){
            min=arr[j];
        }
    }
    printf("The Max Number In Array is : %i \n \n ",max);
    printf("The Min Number In Array is : %i \n \n ",min);


    return 0;
}
