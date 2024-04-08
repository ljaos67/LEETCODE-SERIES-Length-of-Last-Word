public class Solution {
    public int LengthOfLastWord(string s) 
    {
        int count = 0;
        bool start = true;
        for(int i = s.Length -1; i >= 0; i--)
        {
            if(s[i] == ' ')
            {
                if(start)
                {
                    //
                }
                else
                {
                    break;
                }
            }
            else
            {
                count++;
                start = false;
            }
        }
        return count;    
    }
}
