//  int[] myFirstArray = new int[3];

//  myFirstArray[0] = 72;
//  myFirstArray[1] = 64;
//  myFirstArray[2] = 50;


// int [] mySecondArray = new int [myFirstArray.Length * 2];
// Array.Copy(myFirstArray, mySecondArray, myFirstArray.Length);


//  // Array.Resize(ref myFirstArray, myFirstArray.Length * 2);

//  Console.WriteLine("Percorrendo o Array com o FOR");
//  for(int contador = 0; contador < myFirstArray.Length; contador++)
//  {
//      Console.WriteLine($"Contagem {contador} - {myFirstArray[contador]}");
//  }




 Console.WriteLine("Lista dos estados brasileiros");

 List<string> estadosBrasileiros = new List<string>();

 estadosBrasileiros.Add("PE");
 estadosBrasileiros.Add("RJ");
 estadosBrasileiros.Add("PB\n");

 int contador = 0;
 foreach(string item in estadosBrasileiros)
 {
     Console.WriteLine($"Posição N° {contador} - {item}");
     contador++;
 }

 Console.WriteLine("Lista das capitais dos estados");

 List<string> capitaisDosEstados = new List<string>();

 capitaisDosEstados.Add("Recife");
 capitaisDosEstados.Add("Rio de Janeiro");
 capitaisDosEstados.Add("João Pessoa");

 int contCapital = 0;
 foreach(string item in capitaisDosEstados)
 {
     Console.WriteLine($"Posição N° {contCapital} - {item}");
     contCapital++;
 }











// Console.WriteLine("Percorrendo o Array com o FOREACH");

// foreach(int valor in myFirstArray)
// {
//     Console.WriteLine(valor);
// } 



// string[] tropaDoCalango = new string [3];
// tropaDoCalango[0] = "Lucas";
// tropaDoCalango[1] = "Fábio";
// tropaDoCalango[2] = "Kauã";

// for(int contador = 0; contador < tropaDoCalango.Length; contador++)
// {
//     Console.WriteLine($"Integrante da Tropa N° {contador}: {tropaDoCalango[contador]}");
// }