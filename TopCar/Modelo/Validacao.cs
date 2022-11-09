using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCar.Modelo
{
    public class Validacao
    {
        public String mensagem { get; set; }


        public void validarUsuario(List<String>ListaUsuarios)
        {
            this.mensagem = "";

            if (ListaUsuarios[1].Length < 5)
                this.mensagem += "Nome deve ter mais que 5 caracteres \n";
            if (ListaUsuarios[1].Length > 20)
                this.mensagem += "Nome deve ter menos que 20 caracteres \n";


            if (ListaUsuarios[2].Length < 7)
                this.mensagem += "Data de nascimento deve ter mais que 7 caracteres \n";
            if (ListaUsuarios[2].Length > 9)
                this.mensagem += "Data de nascimento deve ter menos que 9 caracteres \n";


            if (ListaUsuarios[3].Length < 10)
                this.mensagem += "CPF deve ter mais que 10 caracteres \n";
            if (ListaUsuarios[3].Length > 12)
                this.mensagem += "CPF deve ter menos que 12 caracteres \n";


            if (ListaUsuarios[4].Length < 4)
                this.mensagem += "Senha para cadastro deve ter mais que 4 caracteres \n";
            if (ListaUsuarios[4].Length > 6)
                this.mensagem += "Senha para cadastro deve ter menos que 6 caracteres \n";

            if (ListaUsuarios[5].Length < 5)
                this.mensagem += "email deve ter mais que 3 caracteres \n";
            if (ListaUsuarios[5].Length > 10)
                this.mensagem += "email deve ter menos que 10 caracteres \n";

        }
    }
}
