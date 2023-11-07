# Codility-EquiLeader
A non-empty array A consisting of N integers is given.</br>
The leader of this array is the value that occurs in more than half of the elements of A.</br>
An equi leader is an index S such that 0 ≤ S < N − 1 and two sequences A[0], A[1], ..., A[S] and A[S + 1],</br>
A[S + 2], ..., A[N − 1] have leaders of the same value.

For example, given array A such that:</br>
A[0] = 4</br>
A[1] = 3</br>
A[2] = 4</br>
A[3] = 4</br>
A[4] = 4</br>
A[5] = 2</br>
we can find two equi leaders:</br>
0, because sequences: (4) and (3, 4, 4, 4, 2) have the same leader, whose value is 4.</br>
2, because sequences: (4, 3, 4) and (4, 4, 2) have the same leader, whose value is 4.</br>
The goal is to count the number of equi leaders.

Write a function:</br>
class Solution { public int solution(int[] A); }</br>
that, given a non-empty array A consisting of N integers, returns the number of equi leaders.</br>

For example, given:</br>
A[0] = 4</br>
A[1] = 3</br>
A[2] = 4</br>
A[3] = 4</br>
A[4] = 4</br>
A[5] = 2</br>
the function should return 2, as explained above.

Write an efficient algorithm for the following assumptions:</br>
N is an integer within the range [1..100,000];</br>
each element of array A is an integer within the range [−1,000,000,000..1,000,000,000].
