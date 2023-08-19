Console.WriteLine("Olá Mundo");
string escolha = " ";
List<Double> lista_de_numeros;
Double resultado = 0;
int inte = 0;

while (true)
{
    Double primeiro, segundo = 0;
    string operacao = " ";
    if(inte != 0)
    {
        Console.Write("Deseja continuar? (S/N): ");
        escolha = Console.ReadLine().ToUpper();
        if (escolha == "N") break;
    }
    inte++;
    Console.Write("Digite o primeiro valor: ");
    primeiro = Convert.ToDouble(Console.ReadLine());
    Console.Write("Digite o segundo valor: ");
    segundo = Convert.ToDouble(Console.ReadLine());
    lista_de_numeros= new List<Double>();
    lista_de_numeros.Add(primeiro);
    lista_de_numeros.Add(segundo);
    Console.Write("Tem algum outro valor?(S/N) ");
    escolha= Console.ReadLine().ToUpper();
    while(escolha == "S")
    {
        Console.Write("Digite o novo valor: ");
        lista_de_numeros.Add(Convert.ToDouble(Console.ReadLine()));
        Console.Write("Tem algum outro valor?(S/N) ");
        escolha = Console.ReadLine().ToUpper();
    }
    
    while (true)
    {
        Console.Write("Escolha a operação: " +
                         "\n(1) Soma + " +
                         "\n(2) Subtração - " +
                         "\n(3) Multiplicação x " +
                         "\n(4) Divisão /: ");
        operacao = Console.ReadLine();
        if (operacao == "1")
        {
            Console.WriteLine("Soma");
            for (int i = 0; i < lista_de_numeros.Count(); i++)
            {
                resultado += lista_de_numeros[i];
            }
            Console.WriteLine("Resultado da soma: " + resultado);
            Console.Write("Deseja salvar este resultado? (S/N): ");
            lista_de_numeros.Clear();
            escolha = Console.ReadLine().ToUpper();
            if (escolha == "S")
            {
                lista_de_numeros.Add(resultado);
            }
            break;
        }
        else if (operacao == "2")
        {
            Console.WriteLine("Subtração");
            for (int i = 0; i < lista_de_numeros.Count(); i++)
            {
                if(i == 0)
                {
                    resultado = lista_de_numeros[i];
                }
                else
                {
                    resultado -= lista_de_numeros[i];
                }
            }
            Console.WriteLine("Resultado da subtração: " + resultado);
            Console.Write("Deseja salvar este resultado? (S/N): ");
            lista_de_numeros.Clear();
            escolha = Console.ReadLine().ToUpper();
            if (escolha == "S")
            {
                lista_de_numeros.Add(resultado);
            }
            break;
        }
        else if (operacao == "3")
        {
            Console.WriteLine("Multiplicação");
            for (int i = 0; i < lista_de_numeros.Count(); i++)
            {
                if (i == 0)
                {
                    resultado = lista_de_numeros[i];
                }
                else
                {
                    resultado *= lista_de_numeros[i];
                }
            }
            Console.WriteLine("Resultado da subtração: " + resultado);
            Console.Write("Deseja salvar este resultado? (S/N): ");
            lista_de_numeros.Clear();
            escolha = Console.ReadLine().ToUpper();
            if (escolha == "S")
            {
                lista_de_numeros.Add(resultado);
            }
            break;
        }
        else if (operacao == "4")
        {
            Console.WriteLine("Divisão");
            for (int i = 0; i < lista_de_numeros.Count(); i++)
            {
                if (i == 0)
                {
                    resultado = lista_de_numeros[i];
                }
                else
                {
                    resultado /= lista_de_numeros[i];
                }
            }
            Console.WriteLine("Resultado da subtração: " + resultado);
            Console.Write("Deseja salvar este resultado? (S/N): ");
            lista_de_numeros.Clear();
            escolha = Console.ReadLine().ToUpper();
            if (escolha == "S")
            {
                lista_de_numeros.Add(resultado);
            }
            break;
        }
        else
        {
            Console.WriteLine("Não entendi a opção!");
            Console.ReadLine();
            break;
        }
        
    }
}
