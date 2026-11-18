public class Solution {
    public void Rotate(int[] nums, int k) {
        
        int n= nums.Length;
        k=k%n;
        int[] arr = new int[k];
        int j=0;
        for(int i=n-k;i<n;i++){
            arr[j++]=nums[i];
        }
        //shift everyhting by k 
        j=n-k-1;
       while(j>=0){
            nums[j+k]=nums[j];
            j--;
        }
         for(int i=0;i<k;i++){
            nums[i]=arr[i];
        }
    }
    //[1,2,3,4,5,6,7]
    //n=7 , k=4 , i =4 => nums[i]=5
    // arr[0] = 5, nums[4]=nums[0]
}