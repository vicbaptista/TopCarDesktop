using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCar.Modelo
{
    public class Usuario
    {
        // variáveis da tela Cadastro Usuário
        public int Id { get; set; }

        public String nome { get; set; }
        
        public String dataNasc  { get; set; }
        public String cpf  { get; set; }

        public String senhaCadastro { get; set; }

        public String email { get; set; }


        //variáveis da tela Mudar senha

        public String mudarSenha { get; set; }


        // Variável da tela Relatar problema
        public  String relatarProblema { get; set; }

     
        //Variáveis da página Simular seguro 
        public String marcaCarro { get; set; }

        public String anoDeFabricacao { get; set; }

        public String anoModelo { get; set; }

        public String modeloCarro { get; set; }

        public String placaCarro { get; set; }


        //Variáveis da página Sim.Seg 1
        public String nomeSegurado { get; set; }

        public String emailSegurado { get; set; }

        public String celularCegurado { get; set; }

        public String dataNascimento { get; set; }

        // Variáveis da página Sim.Seg 2
        public String km { get; set; }
    }
}
