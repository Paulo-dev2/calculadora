class Calculadora
{
 
    public void operacoes(int num1,int num2,int opcao)
    {
        int result = 0;

        switch (opcao)
        {
            case 1: 
                {
                    result = num1 + num2;
                    break;
                }
            case 2:
                {
                    result = num1 - num2;
                    break;
                }
            case 3:
                {
                    result = num1 * num2;
                    break;
                }
            case 4:
                {
                    result = num1 / num2;
                    break;
                }
            default:
                {
                    Console.WriteLine("Opcao invalida");
                    break;
                }
        }
        if(result != 0)
            Console.WriteLine("Resultado da operacao eh: " + result);
    }

    public static void Main(string[] args)
    {

        int number_one, number_two, opcao;

        Console.WriteLine("[1] para Adicao\n");
        Console.WriteLine("[2] para Subtracao\n");
        Console.WriteLine("[3] para Multiplicacao\n");
        Console.WriteLine("[4] para Divisao \n");
        Console.WriteLine("Selecione uma das opcoes: \n");
        opcao = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o primeiro numero: \n");
        number_one = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o segundo numero: \n");
        number_two = Convert.ToInt32(Console.ReadLine());

        Calculadora calc = new Calculadora(); 
        calc.operacoes(number_one, number_two, opcao);
    }
}