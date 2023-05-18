     static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {
        // Start the count for apples and oranges at zero.
        int countApples = 0;
        int countOranges = 0;
        
        //increment countApples if the apple falls within the distance between s and t
        for(int i = 0; i < apples.Count; i++)
        {
            if(a + apples[i] >= s && a + apples[i] <= t)
                apples++;
        }    
        //increment countOranges if the orange falls within the distance between s and t
        for(int r = 0; r < oranges.Count; r++)
        {
            if(b + oranges[r] >= s && b + oranges[r] <= t)
                oranges++;
    }   //display the count for apples and oranges on different lines
        Console.Writeline(countApples);
        Console.Writeline(countOranges);

}
