namespace Lecture_1
{
    public class Solution1
    {

        public static void GenerateCombinations(int n, int k, List<int> currentCombination, List<List<int>> result)
        {
            // Base case: If k becomes 0, add the current combination to the result
            if (k == 0)
            {
                result.Add(new List<int>(currentCombination));
                return;
            }

            // Recursive call for each element in the set
            for (int i = 1; i <= n; i++)
            {
                // Include the current element in the combination
                currentCombination.Add(i);

                // Recursive call with updated combination and decreased k
                GenerateCombinations(n, k - 1, currentCombination, result);

                // Backtrack: Remove the last added element for the next iteration
                currentCombination.RemoveAt(currentCombination.Count - 1);
            }
        }

    }
}