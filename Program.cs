// using System.Data.Common;
// using System.IO.Compression;
// using System.Runtime.InteropServices;

// // #region tuplas

// // List<(int id, string name, DateTime born)> list = new();
// // list.Add((id: 10, name: "Helder", born: new DateTime(1987, 9, 24)));
// // list.Add((11, "Nicole", new DateTime(2000, 9, 24)));
// // list.Add((12, "Lorena", new DateTime(1982, 6, 8)));
// // list.ForEach(x => Console.WriteLine($"Lista : {x.name}, {x.id}, {x.born.ToShortDateString()}"));
// // #endregion

// #region Questao1
// String name = Console.ReadLine()!;
// //DateTime dtNascimento = DateTime.Parse( Console.ReadLine()!);
// try
// {
//     DateTime dtNascimento =  DateTime.Parse( Console.ReadLine()!);
//     Console.WriteLine($"{CalcAge(name, dtNascimento}");
// }
// catch (FormatException)
// {
//     Console.WriteLine("Formato de data invalido.")
    
// }
// catch (Exception ex){
//  Console.WriteLine(ex.Message)
// }

// (string, int) CalcAge(string nome, DateTime dtNascimento){
//     int age = (DateTime.Today.Year- dtNascimento.Date.Year);
//     //caso não ten
//     if (DateTime.Today.DayOfYear < dtNascimento.DayOfYear)
//     {
//         age--;
//     }
//     return (nome, age);

// }

// #endregion

// #region exemplos
// // String[] pessoas = {"Lorena", "Ademir", "Gabriel", "Diego", "Chico", "Andre", "Alice"};
// // char letra='A';
// // Console.WriteLine($"Todas as pessoas da lista: {String.Join(", ", pessoas)}");
// // Console.WriteLine($"Pessoas com nome começando com '{letra}': {String.Join(", ", pessoas.Where(x => x.StartsWith(letra)))}");

// List<int> list = new () {1, 2, 3, 4, 5};
// var squareList = list.Select(x => x * x);
// Console.WriteLine($"Lista Original: {string.Join(", ", list)}");
// Console.WriteLine($"Lista Square: {string.Join(", ", squareList)}");

// var summedList = list.Select((x, index) => x + squareList.ElementAt(index));
// Console.WriteLine($"Summed List: {string.Join(", ", summedList)}");

// var listMultipleOfThree = list.Where(x => x % 3 == 0).ToList();
// listMultipleOfThree.AddRange(squareList.Where(x => x % 3 ==0));
// listMultipleOfThree.AddRange(summedList.Where(x => x % 3 ==0));    
// listMultipleOfThree.AddRange(summedList.Where(x => x % 3 == 0).ToList());
// Console.WriteLine($"List Multiple of Three: {string.Join(", ", listMultipleOfThree)}");
// // List Multiple of Three: 3, 9, 6, 12, 30
// Console.WriteLine($"List Multiple of Three: {string.Join(", ", listMultipleOfThree.Order())}");
// #endregion

#region Exceptions Examples

try{
   // Code that may throw an exception
   int result = Divide(10, 0);
   Console.WriteLine($"Result: {result}");
}
catch (DivideByZeroException ex){
   // Handle the specific exception
   Console.WriteLine("Error: Cannot divide by zero");
   Console.WriteLine(ex.Message);
}
catch (Exception ex){
   // Handle any other exceptions
   Console.WriteLine("An error occurred");
   Console.WriteLine(ex.Message);
}
finally{
   // Code that will always execute, regardless of whether an exception occurred or not
   Console.WriteLine("Finally block executed");
}

int Divide(int a, int b){
   if (b == 0)
   {
      // Throw a custom exception
      throw new DivideByZeroException("Cannot divide by zero");
   }
   return a / b;
}

#endregion 