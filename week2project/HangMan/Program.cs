

    int numOfGuesses=0; //initiate guesses to zero
    string[] words = { "apple", "banana", "cherry", "orange", "kiwi", "mango","pear","peach" }; //array to choose a guessable word from
    Random rand = new Random(); ///object created 
    int number = rand.Next(0, 8); //returns random number between 0-9 //pick a random number that corresponds to which word from the array will be chosen.
    string chosenWord= words[number]; //assign chosen word variable to random word chosen

    string[] guessedLetters = new string [26]; //initialize array for guessed letters

    
    while(numOfGuesses < 6){


    Console.WriteLine("Remaining Guesses: " + numOfGuesses);

    Console.WriteLine("What is your First guess?...Hint- type of fruit: ");//get the users first guess

    char userGuess = Console.ReadLine()[0];
    bool result = chosenWord.Contains(userGuess);



        if (result==true){
            Console.WriteLine("That letter is in the word!\n what is your next guess?");
            Console.WriteLine(userGuess);
            for (int i = 0; i < chosenWord.Length; i ++)
                {
                    if(chosenWord[i]==userGuess){
                        Console.Write(userGuess);
                    }
                    else{
                        Console.Write("*");
                    }
                }
        }
        else if (result==false){
            Console.WriteLine("That letter is not in the word...You have used one of your guesses.");
            numOfGuesses+=1;
            //guessedLetters[numOfGuesses]=userGuess;

        }



    }
    Console.WriteLine("The word was " + chosenWord + " Were you able to guess it?");
    Console.WriteLine("YOU ARE OUT OF GUESSES_HANGMAN");











// using System;

// namespace HangmanGame
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
// int numOfGuesses=6;
// string[] words = { "apple", "banana", "cherry", "orange", "kiwi" };
// Random rand = new Random();
// int number = rand.Next(0, 5); //returns random number between 0-6
// string chosenWord= words[number];
// char[] letterGuessed = new char[chosenWord.Length];
// bool wordGuessed = false;


// while(numOfGuesses > 0 && !wordGuessed )
// {
// // Display remaining guesses
//     Console.WriteLine("Remaining Guesses: " + numOfGuesses);

// // Promt user for guess
//     Console.Write("What is your guess?");
//     char guess = Console.ReadKey().KeyChar; //obtain the key pressed by user
//     Console.WriteLine();

// // check if letter is in the word 
//     bool result = false;
//     for (int i = 0; i < chosenWord.Length; i++)
//     {
//         if (chosenWord[i] == guess)
//         {
//             letterGuessed[i] = guess;
//             result = true;

//         }
//     }

//     if (!result)
//     {
//         Console.WriteLine("Sorry, that letter is not in the word.");
//         numOfGuesses--;
//     }
    
// // check if the word is guessed 
//     if (new string(letterGuessed)== chosenWord)
//     {
//         wordGuessed = true;
//     }

// // Display game result
//             if (wordGuessed)
//             {
//                 Console.WriteLine("Congratulations, you guessed the word!");
//             }
//             else
//             {
//                 Console.WriteLine("Sorry, you ran out of guesses");
//             }

//             Console.WriteLine("Press any key to exit.");
//             Console.ReadKey();

//     }
//         }
//     }
// }