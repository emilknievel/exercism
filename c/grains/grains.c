#include "grains.h"
#include <math.h>
#include <stdint.h>

uint64_t square(uint8_t index) {
    return (index == 0 || index > 64) ? 0 : pow(2, index - 1);
}

uint64_t total(void) {
    uint64_t sum = 0;

    for (int i = 1; i < 65; ++i) {
        sum += square(i);
    }

    return sum;
}
