# 2022-04-21 - Address unit, char and cell sizes
The Standard imposes the following restrictions on data sizes:

* address unit <= char <= cell (3.1.2)
* 8b <= char (3.1.2)
* cell = n * char, for some integer n (3.1.3)
* 16b <= cell (3.1.3)
* 255 characters <= max counted string length (3.1.3.4)
* data-stack elements, return-stack elements, addresses, execution tokens, flags, and integers = 1 cell (3.1.3)
* double-cell integers = 2 cells, obviously (3.1.4.1)

Data space areas restrictions:

* 80 characters <= input buffer (3.3.3.5)
* 84 characters <= scratch pad area (3.3.3.6)
* 33 characters <= region identified by WORD (3.3.3.6)
* (2*n) + 2 character <= pictured numeric output string buffer, where n is the number of bits in a cell (3.3.3.6)
    * 16bit cell -> 34 characters
    * 32bit cell -> 66 characters
    * 64bit cell -> 130 characters

Section 4.1.1 lists every(?) implementation-defined option a system shall document the values for.
This includes the above size options.

C#'s char is 16b wide, so I think it'd be better if I made everything 16b wide too:

address unit = char = cell = 16b

# 2022-04-22 - Starting subset of words

I spent the day reading the CORE word set trying to find a good subset to implement first, 
to have something working before tackling the harder words.
I found 48 words that deal only with the data-stack, no control flow, allocation or compilation shenanigans. 
They're listed in Issue #1 on Github.
