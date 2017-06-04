#include "kata.h"

struct kata {
	char *name;
	kata_Method *method;
	struct kata *next;
};

void kata_run(const Kata *kata) {
	kata->method();
}

char *kata_getName(const Kata *kata) {
	return kata->name;
}