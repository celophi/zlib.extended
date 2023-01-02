# Zlib.Extended
Zlib.Extended is an open-source port of the [zlib library](https://zlib.net/) with a few modifications to support a base-2 logarithm of the LZ77 window size up to 8 instead of the default maximum of 7.

# Version
This library is targeting zlib 1.2.5.

# TODO
At this current time, only inflate has been modified and tested to support the new window size. Deflate may or may not be functional. Use at your own discretion.
