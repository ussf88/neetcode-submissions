public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int total = 0;
        int n = position.Length;
        var arr = new Item[n];
        for(int i=0;i<n;i++){
               arr[i] = new Item(position[i],((double)target-position[i])/speed[i]);
        }
        Array.Sort(arr, (x, y) => y.pos.CompareTo(x.pos));

        double time = arr[0].time;
        total++;
        for(int i=1;i<n;i++){
           if(arr[i].time > time){
            time = arr[i].time;
            total ++;
           }
        }
        //Console.WriteLine(string.Join("//",arr.Select(e=> e.ToString())));
        return total;
        
    }
     public struct Item{ 
        public int pos;
        public double time;
        public Item(int pos, double time){
            this.pos=pos;
            this.time= time;
        }
        public override string ToString() => $"pos {pos} , time {time}";
    }
}
