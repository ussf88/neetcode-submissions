public class Solution {
    public string DecodeString(string s) {
        int n = s.Length;
        var rez = "";
        var stack = new Stack<string>();
        for (int i = 0; i < n; i++) {
            if (s[i] == '[')
                continue;
            if (s[i] == ']') {
                var strToRepeat = "";
                int times = 0;
                while (!int.TryParse(stack.Peek(), out _)) strToRepeat = stack.Pop() + strToRepeat;
                times = int.Parse(stack.Pop());
                stack.Push(Repeat(strToRepeat, times));
                continue;
            }
            if (char.IsDigit(s[i])) {
                int start = i;
                while (i < n && char.IsDigit(s[i])) i++;
                i--;
                int end = i;
                stack.Push(s[start..(end + 1)]);
                continue;
            }
            stack.Push(s[i].ToString());
        }

        return string.Join("", stack.Reverse());
    }

    private string Repeat(string str, int times) {
        if (times < 2)
            return str;
        StringBuilder sb = new StringBuilder(str);
        int i = 1;
        while (i < times) {
            sb.Append(str);
            i++;
        }
        return sb.ToString();
    }
}