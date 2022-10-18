using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJETOTCC
{
    class DAO_Conexao
    {
        private static MySqlConnection con;

        public static Boolean getConexao(String local, String banco, String user, String senha)
        {
            Boolean retorno = false;
            try
            {
                con = new MySqlConnection("server=" + local + ";User ID=" + user + ";database=" + banco + ";password=" + senha);
                con.Open();
                retorno = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return retorno;

        }

        public static Boolean CadAdotante(String Nome, String CPF, String Contato, String Endereço, String Numero, String Estado, String Cidade, int tipo)
        {
            bool cadAdo = false;
            try
            {
                //con.Open();
                MySqlCommand CadAdotante = new MySqlCommand("insert into CadAdotante (Nome, CPF, Endereço, Numero, Cidade, Contato, Estado) values('" + Nome + "','" + CPF + "','" + Endereço + "','" + Numero + "','" + Cidade + "','" + Contato + "','" + Estado +"')" ,con);
                CadAdotante.ExecuteNonQuery();
                cadAdo = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                //con.Close();
            }
            return cadAdo;
        }


        public static Boolean CadAnimal(String Codigo, String Nome, String Raça, String Porte, String Instituição, int tipo)
        {
            bool cadAni = false;

            try
            {
                MySqlCommand CadAnimal = new MySqlCommand("insert into CadAnimal (Codigo, Nome, Raça, Porte, Instituição) values('" + Codigo + "','" + Nome + "','" + Raça + "','" + Porte + "','" + Instituição + "')", con);
                CadAnimal.ExecuteNonQuery();
                cadAni = true;

            }
            catch(Exception exAn)
            {
                Console.WriteLine(exAn.ToString());
            }
            finally
            {

            }
            return cadAni;
        }
    }
}
