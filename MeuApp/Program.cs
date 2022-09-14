Menu();
Repetir();


static void Repetir()
{
  Console.WriteLine("Deseja realizar outra operação?(S/N)");
  string resposta = Console.ReadLine();
  while (resposta == "s" || resposta == "S")
  {
    if (resposta == "s" || resposta == "S")
    {
      Menu();
    }
    else
    {
      Console.WriteLine("Obrigado por usar nossa calculadora!");
    }
    Console.WriteLine("Deseja realizar outra operação?(S/N)");
    resposta = Console.ReadLine();
  }
}
static void Menu()
{
  Console.WriteLine("O que deseja fazer?");

  Console.WriteLine("1 - Soma");
  Console.WriteLine("2 - Subtração");
  Console.WriteLine("3 - Multiplicação");
  Console.WriteLine("4 - Divisão");
  float menu = float.Parse(Console.ReadLine());
  if (menu == 1)
    Soma();
  if (menu == 2)
    Subtracao();
  if (menu == 3)
    Multiplicacao();
  if (menu == 4)
    Divisao();
  if (menu > 4)
    Console.WriteLine("Operação invalida!");
}

static void Soma()
{
  Console.WriteLine("Primeiro valor:");
  float n1 = float.Parse(Console.ReadLine());

  Console.WriteLine("Segundo numero:");
  float n2 = float.Parse(Console.ReadLine());

  float result = n1 + n2;

  Console.WriteLine($"Resultado da soma dos numeros = {result}");

}

static void Subtracao()
{
  Console.WriteLine("Primeiro valor:");
  float n1 = float.Parse(Console.ReadLine());

  Console.WriteLine("Segundo numero:");
  float n2 = float.Parse(Console.ReadLine());

  float result = n1 - n2;
  Console.WriteLine($"Resultado da subtração dos numeros = {result}");
}

static void Divisao()
{
  Console.WriteLine("Primeiro valor:");
  float n1 = float.Parse(Console.ReadLine());

  Console.WriteLine("Segundo numero:");
  float n2 = float.Parse(Console.ReadLine());

  float result = n1 / n2;
  Console.WriteLine($"Resultado da divisão dos numeros = {result}");
}

static void Multiplicacao()
{
  Console.WriteLine("Primeiro valor:");
  float n1 = float.Parse(Console.ReadLine());

  Console.WriteLine("Segundo numero:");
  float n2 = float.Parse(Console.ReadLine());

  float result = n1 * n2;
  Console.WriteLine($"Resultado da multiplicação dos numeros = {result}");
}