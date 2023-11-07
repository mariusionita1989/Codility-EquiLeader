using Codility_EquiLeader;

namespace Codility_EquiLeaderTests
{
    public class SolutionTests
    {
        [Fact]
        public void Test_NoEquiLeader()
        {
            int[] A = { 1, 2, 3, 4, 5 };
            Solution solution = new Solution();
            int equiLeaderCount = solution.solution(A);
            Assert.Equal(0, equiLeaderCount);
        }

        [Fact]
        public void Test_SixEquiLeader()
        {
            int[] A = { 4, 3, 4, 4, 4, 2, 4, 4 };
            Solution solution = new Solution();
            int equiLeaderCount = solution.solution(A);
            Assert.Equal(6, equiLeaderCount);
        }

        [Fact]
        public void Test_TwoEquiLeaders()
        {
            int[] A = { 4, 3, 4, 4, 4, 2 };
            Solution solution = new Solution();
            int equiLeaderCount = solution.solution(A);
            Assert.Equal(2, equiLeaderCount);
        }

        [Fact]
        public void Test_NoLeader()
        {
            int[] A = { 1, 2, 3, 1, 2, 3 };
            Solution solution = new Solution();
            int equiLeaderCount = solution.solution(A);
            Assert.Equal(0, equiLeaderCount);
        }

        [Fact]
        public void Test_SmallestInput()
        {
            int[] A = { 1 };
            Solution solution = new Solution();
            int equiLeaderCount = solution.solution(A);
            Assert.Equal(0, equiLeaderCount);
        }

        [Fact]
        public void Test_LargestInput()
        {
            int[] A = new int[100000];
            for (int i = 0; i < 100000; i++)
                A[i] = i % 2 == 0 ? 1 : 2;

            Solution solution = new Solution();
            int equiLeaderCount = solution.solution(A);
            Assert.Equal(0, equiLeaderCount);
        }
    }
}