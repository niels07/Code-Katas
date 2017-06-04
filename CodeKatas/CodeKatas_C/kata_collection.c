#include <stdio.h>
#include <stdlib.h>
#include "kata.h"
#include "kata_collection.h"

struct kataCollection {	
	size_t size;
	int count;
	Kata **katas;
};

static unsigned long hash(const char *str, unsigned long m) {
	unsigned long h = 0;
	unsigned const char *ustr = (unsigned const char *)str;

	while (*ustr != '\0') {
		h = (h * 256 + *ustr) % m;
		ustr++;
	}

	return h;
}

KataCollection *kataCollection_create(size_t size) {
	KataCollection *kc = malloc(sizeof(KataCollection));

	if (!kc) {
		return NULL;
	}

	kc->size = size;
	kc->count = 0;
	kc->katas = calloc(sizeof(struct kata *), kc->size);

	if (!kc->katas) {
		free(kc);
		return NULL;
	}

	return kc;
}

void kataCollection_add(KataCollection kc, const char *name, kata_Method *method)
{

}
