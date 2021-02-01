using System.Text;

class MainClass {
  public static void Main (string[] args) {
        String  animal1;
        String  animal2; 
        String  animal3;

        animal1 = Console.ReadLine();
        animal2 = Console.ReadLine();
        animal3 = Console.ReadLine();

    if ((animal1 == "vertebrado") && (animal2 == "ave")  && (animal3 == "carnivoro")) {
      Console.WriteLine("aguia\n");
    }

    if ((animal1 == "vertebrado") && (animal2 == "ave")  && (animal3 == "onivoro")) {
      Console.WriteLine("pomba\n");
    }

    if ((animal1 == "vertebrado") && (animal2 == "mamifero")  && (animal3 == "onivoro")) {
      Console.WriteLine("homem\n");
    }

    if ((animal1 == "vertebrado") && (animal2 == "mamifero")  && (animal3 == "herbivoro")) {
      Console.WriteLine("vaca\n");
    }

    if ((animal1 == "invertebrado") && (animal2 == "inseto")  && (animal3 == "hematofago")) {
      Console.WriteLine("pulga\n");
    }

    if ((animal1 ==  "invertebrado") && (animal2 == "inseto")  && (animal3 == "herbivoro")) {
      Console.WriteLine("lagarta\n");
    }
    
    if ((animal1  == "invertebrado") && (animal2 == "anelideo") && (animal3 == "hematofago")) {
      Console.WriteLine("sanguessuga\n");
    }

    if ((animal1  == "invertebrado") && (animal2 == "anelideo") && (animal3 == "onivoro")) {
      Console.WriteLine("minhoca\n");
    }

  }
}