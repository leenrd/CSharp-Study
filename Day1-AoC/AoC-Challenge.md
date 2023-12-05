## Challenge

In this coding challenge using C#, the task is to create a program that reads lines of text, extracts numbers from each line, and then adds up all these numbers to calculate the total. This involves working with text parsing and numerical operations in the context of C# programming.

## What i learn

I can't convert the digit i extracted from a string '0', i tried using Convert.ToInt32() but it outputted wrong, After researching i found out about asciis. Converting string '0' using Convert.ToInt32() will not work because it will point to another number in the ascii, what I should do instead is to minus the item to 0 because the 0 int in ascii starts at 48. By minusing int 0 to the item it will convert it from string item to int item.

For example:

    '0' (char) - '0' (char) equals 0 (int)
    '1' (char) - '0' (char) equals 1 (int)
    '2' (char) - '0' (char) equals 2 (int)
