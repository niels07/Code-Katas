#include <stdio.h>
#include "kata_collection.h"

static KataCollection *katas;

static int GetKata()
{
	char name[255];
	printf("Name of kata to run : ");
	fgets(name, 255, stdin);

	

}

int main()
{
	katas = kataCollection_create();
    return 0;
}

