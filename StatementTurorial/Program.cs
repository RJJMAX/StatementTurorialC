
int[] nbrs = {

   754, 233, 509, 792, 700, 596, 833, 658, 998, 742,

   187, 754, 308, 914, 489, 867, 717, 586, 929, 467,

   460, 241, 770, 324, 599, 259, 120, 800, 336, 609,

   690, 134, 598, 249, 282, 574, 334, 956, 659, 214,

   435, 643, 809, 874, 906, 620, 328, 369, 426, 561

};
int high = 0;
int low = 1000;
foreach (int nbr in nbrs) {
    if (nbr < low) {
         low = nbr;
    }
    if (nbr > high) {
        high = nbr;
    }
}

Console.WriteLine($"{low} | {high}");
/* FOR EACH
string[] names = { "rob", "trevor", "jason", "zach", "jake", "lynn", "tim" };
foreach (string name in names) {
    Console.WriteLine(name);
}
*/





// FOR LOOP
//-----------------------------------------------------------------------------
// add up odd numbers from 1 to 50 inclusive
//int total = 0;
//for(int i = 1; i <= 50; i = i++) {
  //  if (i % 2 == 0) {
    //    continue;
   // }
     //   total = total + i;
//}

//Console.WriteLine($"{total}");

/*
//long version of slide 92 
int sum = 0;
int i = 1;
while (i <= 10) {
    sum = sum + i;
    i++;
}


// short version
int sum = 1;
for (int i = 1; i < 50; i = i++) {
    sum = sum = i ;
    Console.WriteLine($"i = {i}, sum = {sum}");
}
----------------------------------------------------------------------------------
*/

// IFF STATEMENT
/* -------------------------------------------------------------------------------
Console.Write("Enter and integers: ");
string? answerString = Console.ReadLine();

int answer = Convert.ToInt32(answerString);

string evenOdd = "";

if (answer % 2 == 0) {
    evenOdd = "even";
} else {
    evenOdd = "odd";
}

Console.WriteLine($"The number {answer} is {evenOdd}.");
----------------------------------------------------------------------------------
*/