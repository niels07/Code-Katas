#ifndef KATA_H
#define KATA_H

typedef struct kata Kata;

typedef void (kata_Method)();

extern void kata_run(const Kata * /* kata */);
extern char *kata_getName(const Kata * /* kata */);

#endif /* KATA_H */
