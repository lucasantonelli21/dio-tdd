using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src
{
   public class Calculadora
    {
        private List<string> historico;
        public Calculadora()
        {
            this.historico = new List<string>();
        }
        public int somar(int valor1, int valor2){
            int resultado = valor1 + valor2;
            adicionarHistorico($"{valor1} somado por {valor2} = {resultado}");
            return resultado;
        }
        public int subtrair(int valor1, int valor2){
            int resultado = valor1 - valor2;
            adicionarHistorico($"{valor1} subtraido por {valor2} = {resultado}");
            return resultado;
        }
        public int multiplicar(int valor1, int valor2){
            int resultado = valor1 * valor2;
            adicionarHistorico($"{valor1} multiplicado por {valor2} = {resultado}");
            return resultado;
        }
        public int dividir(int valor1, int valor2){
            int resultado = valor1/valor2;
            adicionarHistorico($"{valor1} dividido por {valor2} = {resultado}");
            return resultado;
        }

        public void adicionarHistorico(string historicoNovo){
            historico.Add(historicoNovo);
        }

        public List<string> listarHistorico(){
            return this.historico;
        }
    }
}