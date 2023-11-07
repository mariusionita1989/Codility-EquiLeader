using System.Runtime.CompilerServices;

namespace Codility_EquiLeader
{
    public class Solution
    {
        public const int RANGE_LOWEST_VALUE = 1;
        public const int RANGE_HIGHEST_VALUE = 100000;

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public int solution(int[] A)
        {
            int n = A.Length;
            int equiLeaderCount = 0;
            if (n >= RANGE_LOWEST_VALUE && n <= RANGE_HIGHEST_VALUE) 
            {
                // Find the leader of the array, if it exists
                int leader = FindLeader(A);
                if (leader == -1)
                    // No leader, no equi leaders
                    return 0;

                int leaderCount = CountOccurrences(A, leader);
                int leftLeaderCount = 0;
                for (int i = 0; i < n - 1; i++)
                {
                    if (A[i] == leader)
                        leftLeaderCount++;

                    int rightLeaderCount = leaderCount - leftLeaderCount;
                    if (leftLeaderCount > (i + 1) / 2 && rightLeaderCount > (n - i - 1) / 2)
                        equiLeaderCount++;
                }
            }

            return equiLeaderCount;
        }

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        private int FindLeader(int[] A)
        {
            int size = 0;
            int candidate = -1;
            int N = A.Length;
            foreach (int element in A)
            {
                if (size == 0)
                {
                    size++;
                    candidate = element;
                }
                else
                {
                    if (element == candidate)
                        size++;
                    else
                        size--;
                }
            }

            if (size <= 0)
                return -1; // No leader
           
            int candidateCount = CountOccurrences(A, candidate);
            return candidateCount > A.Length / 2 ? candidate : -1;
        }

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        private int CountOccurrences(int[] A, int value)
        {
            int count = 0;
            foreach (int element in A)
            {
                if (element == value)
                    count++;
            }

            return count;
        }
    }
}
