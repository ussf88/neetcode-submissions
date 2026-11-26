public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        Array.Sort(people);
        int n = people.Length;
        int left = 0, right = n - 1;
        int total = 0;
        while (left < right) {
            if (people[right] + people[left] <= limit) left++;
            
            total++;
            right--;
        }
        return left == right ? total + 1 : total;
    }
}
