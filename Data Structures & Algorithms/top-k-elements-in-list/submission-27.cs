public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
      
        int n = nums.Length;
        var dict = new Dictionary<int, int>();
      
       
        for(int i=0;i<n;i++){
            if(dict.ContainsKey(nums[i])) dict[nums[i]]++;
            else dict[nums[i]] = 1;
        }
         var minHeap = new PriorityQueue<int,int>();

        foreach(var(key,v) in dict){
            minHeap.Enqueue(key,v);
            if(minHeap.Count>k) minHeap.Dequeue();
        }
        var rez = new int[k];
        int j=0;
        while(j<k){
            rez[j] = minHeap.Dequeue();
            j++;
        }
        return rez;
    }
}
