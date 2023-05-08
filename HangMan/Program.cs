string[] MysteryWord = new string[6];

//Country, shoe types, NBA teams
//MysteryWord[0] = "Banana";
MysteryWord[0] = "Thursday";
MysteryWord[1] = "Lakers";
MysteryWord[2] = "Airport";
MysteryWord[3] = "Candle";
MysteryWord[4] = "Algorithm";
MysteryWord[5] = "Ireland";

for (int i = 0; i < MysteryWord.Length; i++)
{
    MysteryWord[i] = MysteryWord[i].ToUpper();
}

Random random = new Random();

//Selects a number at random
int randomIndex = random.Next(0, MysteryWord.Length);
string KnownWord = MysteryWord[randomIndex];

//Console.WriteLine(KnownWord);

//Convert string to char array
char[] WordToGuess = KnownWord.ToCharArray();



//Randomly set some of the letters to _
for (int i = 0; i < KnownWord.Length; i++)
{
    //generate a random number
    int randomNumber = random.Next(0, KnownWord.Length);
    if (randomNumber <= KnownWord.Length)
    {
        WordToGuess[randomNumber] = '_';

        //Console.WriteLine(WordToGuess);
    }
}
//Convert char array back to string
string shownWord = new string(WordToGuess);

Console.WriteLine(shownWord);


//Console.WriteLine("Can you guess the missing letters in this Mystery word? " + WordToGuess);




//Dictionary<char, int> MissingDict = new Dictionary<char, int>();
Dictionary<char, int> MissingDict = new Dictionary<char, int>();


for (int k = 0; k < KnownWord.Length; k++)
{
    /*if (MissingDict.ContainsKey(KnownWord[k]))
    {
        MissingDict[KnownWord[k]].ToString().Add(k);
    } */
    if (shownWord[k] == '_')
    {
        MissingDict.TryAdd(KnownWord[k],k);
    }

}
//Console.WriteLine(MissingDict.keys);

var MissingLettrers = MissingDict.Keys.Except(shownWord);
string missingLettersString = new string(MissingLettrers.ToArray());


//6 chances for failure to type the right letter
int NumChances = 6;
char[] Shownwords = shownWord.ToCharArray();
for (int j = 0; j < KnownWord.Length; j++)
{
    Console.Write("Type a missing character, One letter at time : ");
    //char LetterTyped = Console.ReadKey().KeyChar;

    string input = Console.ReadLine();
    
    char LetterTyped = input.ToUpper()[0];
    //char LetterTyped = Console.ReadKey().KeyChar;
    //char LetterTyped = args[j+1].ToUpper().ToCharArray()[0];
    //char LetterTyped = args[0][0];
    char upperCaseLetter = char.ToUpper(LetterTyped);

    //LetterTyped = h, missingLettersString =Addi(h)
    if (missingLettersString.Contains(upperCaseLetter))
    {
        Shownwords[MissingDict[upperCaseLetter]] = upperCaseLetter;
        Console.WriteLine("  You guess it right ");
        Console.WriteLine("Guess Another Letter");

        string GuessedWord = new string(Shownwords);
        Console.WriteLine("Your Progress " + GuessedWord);
        //Console.WriteLine("The WordToGuess word is " + KnownWord);


        if (GuessedWord == KnownWord)
        {
            Console.WriteLine("You won the Game");
            break;
        }
    }
    else
    {
        NumChances--;
        Console.WriteLine(" You got it wrong, you have " + NumChances + " chances ");
        if (NumChances == 0)
        {
            Console.WriteLine("You don't have anymore chances, You lost the Game");
            break;
        }
    }




}