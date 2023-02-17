#include <stdio.h>
#include <stdlib.h>

int main()
{
    printf ("MENU\n");
      printf ("1 --> choice  1 \n");
      printf ("2 --> choice  2 \n");
      printf ("3 --> choice  3 \n");


      int selc;
      while(selc!= 4){
        printf("Enter your choice \n");
        scanf("%d",&selc);
        switch(selc)
        {
        case 1:
            printf ("meal 1 \n");
            break;
        case 2:
            printf ("meal 2 \n");
            break;
        case 3:
            printf ("meal 3\n");
            break;
        default:
            printf ("Invalid choice");
        break;
        }
      }

    return 0;
}
