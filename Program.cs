//Shaun Aguirre-Reyes
//10/18/22
// this project the computer gives you difficulty choices then picks a random number in which the user tries to guess what the number is


Console.Clear();

string playAgain = "yes";
while(playAgain == "yes"){
{
    Console.WriteLine("Hello, Today i will try to guess the number you're thinking of");
    Console.WriteLine("Lets select a difficulty. Would you like. Easy? Medium? or Hard?");

    string unknownDifficulty = Console.ReadLine().ToLower();
    switch(unknownDifficulty){
        case "easy":{
        Random rndNum = new Random();
        int num = rndNum.Next(0,10);
        bool facts = true;
        bool theNumber;
        long blank = 0;
        int i = 0;
        

        while(facts == true){
            Console.WriteLine("Guess a number between 0-10");
            string easyGuess = Console.ReadLine();
            theNumber = Int64.TryParse(easyGuess, out blank);
            i++;

        if(blank >= 0 && blank <= 10){
            Console.WriteLine("Your guess is: " + easyGuess);
            facts = false;

            if(blank == num){
                Console.WriteLine("Congrats! The number was " + num + "!");
                Console.WriteLine("It took you " + i + " guesses");
            }

            else if(blank < num){
                Console.WriteLine("Try again, aim a little higher");
                facts = true;
            }else{
                Console.WriteLine("Try again, aiming too high. Come down a little");
                facts = true;
            }
        }else{
            Console.WriteLine("That is not the number");
        }
            
        }



    
  


        break;
        }

        case "medium":{
            

        Random rndNum = new Random();
        int num = rndNum.Next(0,50);
        bool factsTwo = true;
        bool theNumber;
        long blank = 0;
        int i = 0;
        
        while(factsTwo == true){
            Console.WriteLine("Guess a number between 0-50");
            string easyGuess = Console.ReadLine();
            theNumber = Int64.TryParse(easyGuess, out blank);
            i++;

        if(blank >= 0 && blank <= 50){
            Console.WriteLine("Your guess is: " + easyGuess);
            factsTwo = false;

            if(blank == num){
                Console.WriteLine("Congrats! The number was " + num + "!");
                Console.WriteLine("It took you " + i + " guesses");
                 }
            else if(blank < num){
                Console.WriteLine("Try again, aim a little higher");
                factsTwo = true;
            }else{
                Console.WriteLine("Try again, aiming too high. Come down a little");
                factsTwo = true;
            }
        }else{
            Console.WriteLine("That is not the number");
        }
        
            
        }


        break;
        }
        case "hard":{

        Random rndNum = new Random();
        int num = rndNum.Next(0,100);
        bool factsThree = true;
        bool theNumber;
        long blank = 0;
        int i = 0;
         while(factsThree == true){
            Console.WriteLine("Guess a number between 0-100");
            string easyGuess = Console.ReadLine();
           theNumber = Int64.TryParse(easyGuess, out blank);
            i++;

        if(blank >= 0 && blank <= 100){
            Console.WriteLine("Your guess is: " + easyGuess);
            factsThree = false;

            if(blank == num){
                Console.WriteLine("Congrats! The number was " + num + "!");
                Console.WriteLine("It took you " + i + " guesses");

            }

            else if(blank < num){
                Console.WriteLine("Try again, aim a little higher");
                factsThree = true;
            }else{
                Console.WriteLine("Try again, aiming too high. Come down a little");
                factsThree = true;
            }
        }else{
            Console.WriteLine("That is not the number");
        }
            
        }

}


        break;
        
            
        }
        Console.WriteLine("Do you want to play again?");
        playAgain = Console.ReadLine();
        if(playAgain == "yes"){
        Console.WriteLine("Lets play again");
        }else{
        Console.WriteLine("Have a great day :)");
        }
        }
    }

