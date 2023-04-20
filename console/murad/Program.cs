// Console.Write("Adiniz: ");
// string username = Console.ReadLine();

// Console.Write("Soyadiniz: ");
// string surname = Console.ReadLine();

// Console.Write("Ata adiniz: ");
// string ataAdiniz = Console.ReadLine();

// Console.Write("Dogum tarixiniz: ");
// string dogum = Console.ReadLine();

// Console.Write("Oxuduqunuz Universitet: ");
// string uni = Console.ReadLine();

// Console.Write("Fakulte: ");
// string fakulte = Console.ReadLine();

// Console.Write("Ixtisas: ");
// string ixtisas = Console.ReadLine();

// Console.Write("Qrup nomresi: ");
// string qrup = Console.ReadLine();

// Console.Write("Oxuduqunuz kurs: ");
// string kurs = Console.ReadLine();

// Console.Write("Oyrendiyiniz proqramlasdirma dili: ");
// string pd = Console.ReadLine();

// Console.Write("Muelliminiz: ");
// string muellim = Console.ReadLine();

// // Console.WriteLine("Xos gelmisiniz " + username + " " + usersurname + " " + kurs );
// // Console.WriteLine("Adiniz: " + username);
// // Console.WriteLine("Soyadiniz: " + surname);
// // Console.WriteLine("Ata adiniz: " + ataAdiniz);
// // Console.WriteLine("Dogum tarixiniz: " + dogum);
// // Console.WriteLine("Oxuduqunuz Universitet: " +uni);
// // Console.WriteLine("Fakulte: " + fakulte);
// // Console.WriteLine("Ixtisas: " + ixtisas);
// // Console.WriteLine("Qrup nomresi: " + qrup);
// // Console.WriteLine("Oxuduqunuz kurs: " + kurs);
// // Console.WriteLine("Oyrendiyiniz proqramlasdirma dili: " + pd);
// // Console.WriteLine("Muelliminiz: " + muellim);

// Console.WriteLine("Xos Gelmisiniz " + " " + username + " " + surname + " " + ataAdiniz + " " + dogum + " " + uni + " " + fakulte + " " + ixtisas + " " + qrup + " " + pd + " " + muellim);



/// LINQ 

// string[] students = {"Murad","Qonce","Semral"};00
///Qonceden basqa qalanlarinin ekrana cixmasi

    // for (int i = 0; i < students.Length; i++)
    // {
    //     if (students[i] != "Qonce")
    //     {
    //         Console.WriteLine(students[i]);
    //     }
    // }

// var res = students.Where(x=>x == "Qonce").ToArray();
// Console.WriteLine(res);


// string word = "aabbbccd";

// var res = word.GroupBy(x=>x)
//               .Where(x=>x.Count()>1)
//               .Select(a=> new {say = a.Count(), soz = a.Key})
//               .ToArray();    //a deyiskendi

// foreach (var data in res)
// {
//     Console.WriteLine(data.soz + " " + data.say);
// }

// int a = 1; 
// do
// {
//     a++;
//     Console.WriteLine("Murad");
// } while (a==5);


// string[] students = {"Murad","Ehmed","Senan","Eli","Qismet"};


// Console.WriteLine("<div>");
// for (int i = 0; i < students.Length; i++)
// {
//     Console.WriteLine($"<h1>{students[i]}</h1>");
// }
// Console.WriteLine("</div>");



// string[] students = {"Murad","Ehmed","Senan","Eli","Qismet"};

// var aye = students.Skip(2).Take(3).ToArray();

// Console.WriteLine("<div>");
// for (int i = 0; i < aye.Length; i++)
// {
//     Console.WriteLine($"<h1>{aye[i]}</h1>");
// }
// Console.WriteLine("</div>");

          // bize lazim olan yer comparin blog yeri
          // datani backend goturur

/////////////////////////////

// string[] students = {"Murad","Ehmed","Senan","Eli","Qismet"};

// var a = students.First(x=>x == "Qismet");

// Console.WriteLine(a);

////////////////////


// string bos = "";

// if (string.IsNullOrEmpty(bos))
// {
//     Console.WriteLine("bosdur");
// }

                   // Goto

// string[] students = {"Murad","Ehmed","Senan","Eli","Qismet"};

// evvele:
// string username = Console.ReadLine();

// var a = students.FirstOrDefault(x=>x == username);

// if (a==null)
// {

//     Console.WriteLine("Bele istifadeci yoxdur");
//     goto evvele;
// }else{

//     Console.WriteLine(a);

// }


// int[] a = {1,2,3};
// int[] b = {4,6};
// int[] c = {5,8};

// b=c;
// b[0]=200;
// a=c;

// foreach (var item in a)
// {
//     Console.WriteLine(item);
// }

