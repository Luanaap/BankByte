using System;
using BankByte.Sistemas;

namespace BankByte
{
    public class ParceiroComercial : IAutenticavel
    {
      public string Senha { get; set; }

      public bool Autenticar(string senha)
      {
            return Senha == senha;
      }
    }
}
