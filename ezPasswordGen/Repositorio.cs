using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezPasswordGen
{
    public class Repositorio
    {
        public string GerarSenha(int tamanho)
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%&*";
            string senha = string.Empty;

            Random random = new Random();

            for (int i = 0; i < 1; i++)
            {
                char[] caracteresSenha = new char[tamanho];

                for (int j = 0; j < tamanho; j++)
                {
                    caracteresSenha[j] = chars[random.Next(chars.Length)];
                }

                senha = new string(caracteresSenha);
                
            }
            return senha;
        }
    }
}
