Input: [1, 2, 3, 4, 5, 6]

ReverseArray:
1. Create a new array to store the reversed elements.
   reversed = []
2. Set currentIndex = 0
3. Start iterating from the end of the input array (i = length - 1) to the beginning (i >= 0).
   i = 5, currentIndex = 0
      reversed[0] = inputArray[5] => reversed = [6]
      currentIndex = 1
   i = 4, currentIndex = 1
      reversed[1] = inputArray[4] => reversed = [6, 5]
      currentIndex = 2
   i = 3, currentIndex = 2
      reversed[2] = inputArray[3] => reversed = [6, 5, 4]
      currentIndex = 3
   i = 2, currentIndex = 3
      reversed[3] = inputArray[2] => reversed = [6, 5, 4, 3]
      currentIndex = 4
   i = 1, currentIndex = 4
      reversed[4] = inputArray[1] => reversed = [6, 5, 4, 3, 2]
      currentIndex = 5
   i = 0, currentIndex = 5
      reversed[5] = inputArray[0] => reversed = [6, 5, 4, 3, 2, 1]
      currentIndex = 6
4. Return the reversed array.

ReverseArrayWithSwap:
1. Set start = 0 and end = length - 1
   start = 0, end = 5
2. While start < end:
   2.1 Swap the elements at start and end positions in the input array.
       SwapElements(array, 0, 5) => array = [6, 2, 3, 4, 5, 1]
       start = 1, end = 4
   2.2 Swap the elements at start and end positions in the input array.
       SwapElements(array, 1, 4) => array = [6, 5, 3, 4, 2, 1]
       start = 2, end = 3
   2.3 Swap the elements at start and end positions in the input array.
       SwapElements(array, 2, 3) => array = [6, 5, 4, 3, 2, 1]
       start = 3, end = 2 (breaks the loop)
3. Return the modified input array.

Output:
Reversed array (using ReverseArray):
6 5 4 3 2 1

Reversed array (using ReverseArrayWithSwap):
6 5 4 3 2 1
