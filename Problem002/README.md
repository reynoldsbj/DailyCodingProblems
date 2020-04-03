# Daily Coding Problem #2
Difficulty Rating: HARD
Good morning! Here's your coding interview problem for today.

This problem was asked by Uber.

Given an array of integers, return a new array such that each element at index i of the new array is the product of all the numbers in the original array except the one at i.

For example, if our input was[1, 2, 3, 4, 5], the expected output would be[120, 60, 40, 30, 24]. If our input was [3, 2, 1], the expected output would be[2, 3, 6].


Follow-up: what if you can't use division?

## Solution Notes
For this problem, I came up with two solutions, BruteForce and FasterSolution. In this case, BruteForce was actually the bonus, but I included FasterSolution since it is more likely what you would actually use in the real world.