public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
      
        int n = nums.Length;
          Array.Sort(nums);
        int lowestFreq = 0;
        int lowestFreqNumber = nums[0];
        int currentNumber = nums[0];
        int currentFreq = 0;
        var dict = new SortedDictionary<int, HashSet<int>>(
    Comparer<int>.Create((x, y) => y.CompareTo(x))
);
      
       
        for(int i=0;i<n;i++){
         if(nums[i]==currentNumber) currentFreq++;
         else {
         
            if(dict.ContainsKey(currentFreq)) dict[currentFreq].Add(currentNumber);
            else dict[currentFreq] = new HashSet<int>{currentNumber};
            currentNumber=nums[i];
            currentFreq = 1;

         }
         if(i==n-1){
          
            if(dict.ContainsKey(currentFreq)) dict[currentFreq].Add(currentNumber);
            else dict[currentFreq] = new HashSet<int>{currentNumber};
         }
        }
         
        Console.WriteLine(string.Join(" | ", dict.Select(kvp => $"{kvp.Key}: [{string.Join(",", kvp.Value)}]")));
        //Console.WriteLine(nums.Length>15 ? "" :string.Join("|",nums));

// Output Layout: 3: [10,20,30] | 2: [40,50] | 1: [60]

        return dict.Values.SelectMany(e=>e).Take(k).ToArray();
    }
}
