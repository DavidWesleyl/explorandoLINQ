using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioLinq.Entities
{
	internal class dadosFuncionario
	{
        public string Nome { get; set; }

        public string Email { get; set; }

        public decimal Salario { get; set; }

		public dadosFuncionario(string nome, string email, decimal salario)
		{
			Nome = nome;
			Email = email;
			Salario = salario;
		}


		public override string ToString()
		{
			return $"Nome: {Nome} | Email: {Email} | Salário: {Salario}";
		}
	}
}
