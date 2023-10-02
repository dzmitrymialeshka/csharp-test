using System;

public class Dictionary {
  public static void Main(string[] args) {

    Console.Write("Введите слово на русском: ");
    string weather = Console.ReadLine();

    switch (weather) {
    case "ветренно":
      Console.Write("windy");
      break;

    case "солнечно":
      Console.Write("sunny");
      break;

    case "туманно":
      Console.Write("foggy");
      break;

    case "облачно":
      Console.Write("cloudy");
      break;

    case "дождливо":
      Console.Write("rainy");
      break;

    case "холодно":
      Console.Write("cold");
      break;

    case "жарко":
      Console.Write("hot");
      break;

    case "тепло":
      Console.Write("warm");
      break;

    case "прохладно":
      Console.Write("chilly");
      break;

    case "морозно":
      Console.Write("frosty");
      break;

    default:
      Console.WriteLine("Такого слова нет.");
      break;
    }
  }
}