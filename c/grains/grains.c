#include "grains.h"
#include <math.h>
#include <stdint.h>

uint64_t square(uint8_t index) {
    return (index > 0 && index < 65) ? 1ul << (index - 1) : 0;
}

uint64_t total(void) {
    return (((1ull << 63) - 1) << 1) + 1;
}
