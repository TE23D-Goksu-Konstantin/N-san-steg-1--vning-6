string input;
int output;
bool senap = false;

Console.WriteLine("Skriv in en siffra, int eller vafan du vill sålänge det kan bli en integer, snälla rara barn");

while(senap == false){
    input = Console.ReadLine();
if(int.TryParse(input, out output)){
    Console.WriteLine("Bra jobbat, du kan skriva siffror");
    senap = true;
    Thread.Sleep(3000);
    Environment.Exit(0);
}else{
    Console.WriteLine("Sämst.");
}
}

