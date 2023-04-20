// See https://aka.ms/new-console-template for more information
// int[] myInt = {10};
// Console.WriteLine(myInt[0]);

                                         // Task 1

// int myInt = 10;
// Console.WriteLine(myInt);


// double myDouble = 3.14;
// Console.WriteLine(myDouble);


// bool myBool = true;
// Console.WriteLine(myBool);


// char myChar = 'c';
// Console.WriteLine(myChar);


// string myString = "Hello World";
// Console.WriteLine(myString);


// decimal myDecimal= 10.5M;
// Console.WriteLine(myDecimal);


// long myLong = 10000000000;
// Console.WriteLine(myLong);


// float myFloat = 3.5F;
// Console.WriteLine(myFloat);


// short myShort = 10;
// Console.WriteLine(myShort);


// byte myByte = 255;
// Console.WriteLine(myByte);



                                         // Task 2


// int result = 5+10;
// Console.WriteLine(result);


// int a;
// Console.Write("Reqemi daxil edin: ");
// a=Convert.ToInt32(Console.ReadLine());
// if (a >=0){
// Console.WriteLine("positive ");
// }
// else{
// Console.WriteLine("negative");
// }


// int a;
// Console.Write("Reqemi daxil edin: ");
// a = Convert.ToInt32(Console.ReadLine());

// if (a % 2 == 0)
// {
//     Console.WriteLine("Even");
// }
// else
// {
//     Console.WriteLine("Odd");
// }


// int a;
// Console.Write("Reqemi daxil edin: ");
// a = Convert.ToInt32(Console.ReadLine());

// if (a % 5 == 0)
// {
//     Console.WriteLine("eded 5e bolunur");
// }
// else
// {
//     Console.WriteLine("eded 5e bolunmur");
// }


// int a;
// Console.Write("Reqemi daxil edin: ");
// a = Convert.ToInt32(Console.ReadLine());

// if (a % 5 == 0 && a % 3 ==0)
// {
//     Console.WriteLine("Dogrudur");
// }
// else
// {
//     Console.WriteLine("Dogru deyil");
// }


// int a;
// Console.Write("Daxil edin: ");
// a = Convert.ToInt32(Console.ReadLine());
// if (a==366)
// {
//     Console.WriteLine("Leap year");
// }
// else
// {
//     Console.WriteLine("No leap year");
// }


// char vowel = 'a';
// // Console.Write("Reqemi daxil edin: ");
// // vowel = Convert.ToString(Console.ReadLine());
// if (vowel == 'a' || vowel == 'e' || vowel == 'u' || vowel == 'i' || vowel == 'o')
// {
//     Console.WriteLine("Vowel");
// } 
// else
// {
//     Console.WriteLine("Consonant");
// }


// int num;
// Console.WriteLine("Ededi daxil edin: ");
// num = Convert.ToInt32(Console.ReadLine());
// if (num>=1 && num<=10)
// {
//     Console.WriteLine("Daxildir");
// }
// else
// {
//     Console.WriteLine("Daxil deyil");
// }


// string a = " ";

// if (a==" ")
// {
//     Console.WriteLine("bosdu");
// }else{
//     Console.WriteLine("bos deyil");
// }
           
                           
                            
                                 //TaSK 3
                                

// for (int i = 1; i <= 50; i++)
// {
//     Console.WriteLine(i);
// }                                



// for (int i = 1; i <= 100; i++)
// {
//     if (i % 2 == 1)
//     {
//         Console.WriteLine(i);
//     }
// }

// for (int i = 1; i < 100; i+=2)
// {
//     Console.WriteLine(i);
// }



// int a = 0; 
// for (int i = 1; i <= 20; i++)
// {
//     a+=i;
// }
// Console.WriteLine(a);



// for (int i = 1; i <= 10; i++)
// {
//     int a = i*7;
//     Console.WriteLine(a);
// }

       // 5 // Fibonaci 10

// int a = 0;
// int b = 1;
// for(int i = 0; i < 10; i++)
// {
//     Console.WriteLine(a);
//     int temp = b;
//     b += a;
//     a = temp;
// }


                       //6  // factorial

// int a = 1;
// Console.WriteLine("Ededi daxil edin: ");
// int b = Convert.ToInt32(Console.ReadLine()); 
// for (int i = 1; i <= b; i++)
// {
//     a*=i;
// }
// Console.WriteLine(a);


                   // 7 //Fibonacci 20

// int a = 0;
// int b = 1;
// for(int i = 0; i < 20; i++)
// {
//     Console.WriteLine(a);
//     int temp = b;
//     b += a;
//     a = temp;
// }


                      //8  //Reverse 

// Console.WriteLine("Daxil edin: ");
// string a = Console.ReadLine();
// string reverse = "";

// for (int i = a.Length-1; i >= 0; i--)
// {
//     reverse+=a[i];
// }
// Console.WriteLine(reverse);


// int a;
// int reverse = 0;
// int b;
// Console.WriteLine("Ededi daxil edin: ");
// a = int.Parse(Console.ReadLine());
// while (a!=0)
// {
//     b = a%10;
//     reverse=reverse*10+b;
//     a/=10;
// } 
// Console.WriteLine(reverse);

                            // 9 // Sait

// string b = Console.ReadLine();
// int a = 0; 
// for (int i = 0; i < b.Length; i++)
// {
//     if ("aeuio".Contains(b[i]))
//     {
//         a++;
//     }
// }
// Console.WriteLine(a);




                           ///Random

// Random rand = new();

// int myRand = rand.Next(0,10);
// int myNum = 4;
// int count = 0;

// while (true)
// {
//     Console.WriteLine($"{myRand} ededi cixarildi");
//     count++;
//     if (myNum == myRand)
//     {
//         break;
//     }
//     myRand = rand.Next(0,10);
// }

// Console.WriteLine($"{myNum} ededini {count} defeye tapildi");



// int[] myNum = {5,2,7};


// for (int i = 0; i < myNum.Length; i++)
// {
//     Random rand = new();
//     int randNum = rand.Next(10);
//     int count = 0;
// while (true)
// {
//     count++;
//     if (myNum[i] == randNum)
//     {
//         break;
//     }
//     randNum = rand.Next(10);
// } 
// Console.WriteLine($"{myNum[i]} ededini {count} defeye tapildi");
// }



                                            // Factorial

// Console.WriteLine("Ededi daxil edin: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int a = 1;
// for (int i = 1; i < number; i++)
// {
//     a*=i;
// }                                            
// Console.WriteLine($"Netice: {a}");

                                //faktorial string

// string userInput = Console.ReadLine();

// int count = 1;

// for (int i = 1; i <= userInput.Length; i++)
// {
//     count*=i;
// }

// Console.WriteLine($"Netice: {count}");

                    // Aranjman

// string userInput = Console.ReadLine();
// int res = 1;
// int count = 1;
// for (int f = 0; f < userInput.Length; f++)
// {
//     if ('a' == userInput[f])
//     {
//         res++;
//     }
// }
// for (int i = res; i <= userInput.Length; i++)
// {
//     count*=i;
// }

// Console.WriteLine($"Netice: {count}");

            //Aranjman

// string userInput = Console.ReadLine();
// int res = 1;
// int count = 1;
// for (int f = 0; f < userInput.Length; f++)
// {
//     for (int d = 1; d < userInput.Length; d++)
//     {
//     if (userInput[f] == userInput[d])
//     {
//         res++;
//     }   
//     }
// }
// for (int i = res-2; i <= userInput.Length; i++)
// {
//     count*=i;
// }

// Console.WriteLine($"Netice: {count}");





// int a = 0;
// int b = 1;

// for (int i = 0; i < 15; i++)
// {
//     Console.WriteLine(a);
//     int c = b;
//     b+=a;
//     a=c;
// }

/////////////////////////////////

// int a=2;
// int b=3;
// int c= a*b;
// Console.WriteLine(c);



// string[] my = {"A","C","F","B","W","E","Q","R","T","Y","U","I","O","P","S","D","G","H","J","K","L","Z","X","V","N","M"};

// Console.WriteLine(my.Sort());


/////////////////////////////////////////////////////////

                                   // Task 4


// string[] students = {"Murad","Ehmed","Senan","Eli","Qismet","Murad","Eli","Senan"};

// var a = students.GroupBy(x=>x)
//                 .Where(x=>x.Count()>=1)
//                 .Select(b=> new {say=b.Count(),soz=b.Key})
//                 .ToArray();

// foreach (var data in a)
// {
//        Console.WriteLine(data.soz + " " + data.say);
// }                


// string[] students = {"Murad","Ehmed","Senan","Eli","Qismet"};

// var a = students.Skip(2)
//                 .Take(3)
//                 .ToArray();

// foreach (var item in a)
// {
//        Console.WriteLine(item);
// }


// string[] students = {"Murad","Ehmed","Senan","Eli","Qismet"};

// var a = students.Skip(4)
//                 .ToArray();

// foreach (var item in a)
// {
//        Console.WriteLine(item);
// }


// string[] students = {"Murad","Ehmed","Senan","Eli","Qismet"};

// var a = students.First(x=>x == "Murad");

// Console.WriteLine(a);

// string[] students = {"Murad","Ehmed","Senan","Eli","Qismet"};
// Console.WriteLine("Daxil edin: ");
// var a = students.First(x=>x == Console.ReadLine());

// Console.WriteLine(a);


// Console.Write("Sutun: ");
// int rows = int.Parse(Console.ReadLine());

// Console.Write("Setir: ");
// int cols = int.Parse(Console.ReadLine());

// int[,] matrix = new int[rows, cols];

// Console.WriteLine("Matrix:");
 
// for (int row = 0; row < rows; row++)
// {
//     for (int col = 0; col < cols; col++)
//     {
//              Console.Write("matrix[{0},{1}] = ",row, col);
//              matrix[row, col] = int.Parse(Console.ReadLine());
//     }
// }
 
// for (int row = 0; row < matrix.GetLength(0); row++)
// {
//     for (int col = 0; col < matrix.GetLength(1); col++)
//     {
//              Console.Write(" " + matrix[row, col]);
//     }
//     Console.WriteLine();
// }



// Console.Write("Sayi daxil edin: ");

// int rows = int.Parse(Console.ReadLine());

// string[] matrix = new string[rows];


// for (int row = 0; row < rows; row++)
// {
//              Console.Write("",row);
//              matrix[row] = Console.ReadLine();
// }

 
// for (int row = 0; row < matrix.GetLength(0); row++)

// {
//              Console.Write(" " + matrix[row]);

//     Console.WriteLine();

// }

// int bal = Convert.ToInt32(Console.ReadLine());

// if (bal>=51 && bal<61) {
//   Console.WriteLine("E");
// }else if (bal>=61 && bal<71) {
//   Console.WriteLine("D");
// }else if (bal>=71 && bal<81) {
//     Console.WriteLine("C");
// }else if (bal>=81 && bal<91) {
//     Console.WriteLine("B");
// }else if (bal>=91 && bal<=100) {
//     Console.WriteLine("A");
// }else{
//     Console.WriteLine("Kesildin");
// }



// Console.Write("Enter the number of the rows: ");

// int rows = int.Parse(Console.ReadLine());

// string[] matrix = new string[rows];

// Console.WriteLine();

// for (int row = 0; row < rows; row++)
// {

//              Console.Write("",row);

//              matrix[row] = Console.ReadLine();

// }
 

// for (int row = 0; row < matrix.GetLength(0); row++)
// {

//              Console.Write(" " + matrix[row]);

//              Console.WriteLine();

// }



// int bal1 = Convert.ToInt32(Console.ReadLine());

// int bal2 = Convert.ToInt32(Console.ReadLine());

// int bal3 = Convert.ToInt32(Console.ReadLine());

// int bal4 = Convert.ToInt32(Console.ReadLine());

// string bal5 = Console.ReadLine(); 

// if (string.IsNullOrWhiteSpace(bal5))
// {
// int result = (bal1 +bal2 + bal3 + bal4)/6;

// System.Console.WriteLine($"{bal1} baliniz sebeke");
// System.Console.WriteLine($"{bal2} baliniz proq");
// System.Console.WriteLine($"{bal3} baliniz diskret");
// System.Console.WriteLine($"{bal4} baliniz ingilis");



// System.Console.WriteLine($"ortalama  {result}");
       
// }




//        string bal = Console.ReadLine();
// while (bal != "bitdi")
// {
//        int bal1 = Convert.ToInt32(Console.ReadLine());
//        bal1++;
// }
//        Console.WriteLine(bal1); 


