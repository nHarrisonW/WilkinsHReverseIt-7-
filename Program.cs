//N. Harrison Wilkins
//10-19-2022
//Github Project Part 7 - REVERSE IT
//This console project will allow the user to enter a number value and have it  reversed back to them
//the console will also reject inputs that are not numbers
//PEER REVIEW IN READ ME

Console.Clear();

//VARIABLES ARE DECLARED HERE
string userInput, rvrsInput, defaultNumber;
bool isNum;
int intNum;
int i;
i =0;


Console.Write("GREETINGS! ");
do{
//NUMBER HAS NOW BEEN VALIDATED
// userInput = Console.ReadLine();
isNum = false;
while(!isNum){
Console.WriteLine("ENTER A NUMBER FOR ME AND I WILL REVERSE! ");
    userInput = Console.ReadLine();
    isNum = Int32.TryParse(userInput, out intNum);

    if(isNum == false){
    Console.WriteLine("I STRICTLY ACCEPT NUMBER VALUES, TRY AGAIN. ");
    }
rvrsInput = string.Empty;

for( i = userInput.Length - 1; i>= 0; i--)
  rvrsInput += userInput[i];

Console.WriteLine($"YOUR NUMBER REVERSED IS {rvrsInput}");
} 
    Console.WriteLine("ENTER \"Y\" IF YOU LIKE TO PLAY AGAIN, OR ENTER ANY KEY TO EXIT.");
}while(Console.ReadLine().ToUpper() == "Y");


