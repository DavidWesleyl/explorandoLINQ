using ExercicioLinq.Entities;
using System.Globalization;
internal class Program
{
	private static void Main(string[] args)
	{
		

		Console.Write("Digite o endereço: ");

		string endereco = Console.ReadLine();

		List<dadosFuncionario> listaDados = new List<dadosFuncionario>();


		using(StreamReader leitorEndereco = new StreamReader(endereco)) // Stream Reader => vai ler o arquivo .csv e extrair informações!
		{
			while(!leitorEndereco.EndOfStream) 
			{
				string[] camposEndereco = leitorEndereco.ReadLine().Split(',');

				string nome = camposEndereco[0];
				string email = camposEndereco[1];
				decimal salarioFuncionario = decimal.Parse(camposEndereco[2]);

				listaDados.Add(new dadosFuncionario(nome, email, salarioFuncionario));
				
			}
		}


		Console.WriteLine();

        Console.Write("Digite o salario: ");

		decimal salario = decimal.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine($"Email das pessoas que o salário são maiores que {salario}");

		// Mostrar email das pessoas cujo o salario é abaixo do informado.

		var informeSalario = listaDados.Where(x => x.Salario > salario).OrderBy(x => x.Nome);

        Console.WriteLine();


        foreach (dadosFuncionario informacoes in informeSalario)
		{
			Console.WriteLine($"{informacoes.Email}");
		}

		Console.WriteLine();

		// Soma do salario das pessoa que começam com M 

		Console.WriteLine("Soma do salario das pessoas que começam com M:");

        

        var somaSalario = listaDados.Where(nomes => nomes.Nome.StartsWith('M')).Sum(salarioFinal => salarioFinal.Salario);

        Console.WriteLine();

        Console.WriteLine(somaSalario);



		




    }
}