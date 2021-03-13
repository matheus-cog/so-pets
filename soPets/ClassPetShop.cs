using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soPets
{
    class ClassPetShop
    {
        conexao conexao = new conexao(); // Instância da classe de conexão com o banco
        SqlCommand cmd = new SqlCommand(); // Responsável por executar os comandos Sql - insert, update, delete
        public string mensagem; // recebe a mensagem para enviar ao usuário

        // CADASTROS

        public void cadastroFuncionario(string Nome, string Cargo, string CPF, string Matricula, string Endereco, string Contato, string Dt_nascimento, string Dt_Contratacao, string Dt_Desligamento, string Salario)
        {
            // Comando Sql - insert
            cmd.CommandText = "insert into tb_funcionario values (@Nome, @Cargo, @CPF, @Matricula, @Endereco, @Contato, @Dt_nascimento, @Dt_Contratacao, @Dt_Desligamento, @Salario)";

            // Parametros
            cmd.Parameters.AddWithValue("@Nome", Nome);
            cmd.Parameters.AddWithValue("@Cargo", Cargo);
            cmd.Parameters.AddWithValue("@CPF", CPF);
            cmd.Parameters.AddWithValue("@Matricula", Matricula);
            cmd.Parameters.AddWithValue("@Endereco", Endereco);
            cmd.Parameters.AddWithValue("@Contato", Contato);
            cmd.Parameters.AddWithValue("@Dt_nascimento", Dt_nascimento);
            cmd.Parameters.AddWithValue("@Dt_Contratacao", Dt_Contratacao);
            cmd.Parameters.AddWithValue("@Dt_Desligamento", Dt_Desligamento);
            cmd.Parameters.AddWithValue("@Salario", Salario);

            // Conectar com o banco
            try
            {
                // Conectando
                cmd.Connection = conexao.conectar();
                // Executar o comando Sql
                cmd.ExecuteNonQuery();
                // Desconectar
                conexao.desconectar();
                // Mensagem
                this.mensagem = "Funcionário cadastrado com sucesso!!";
            }
            catch (Exception ex)
            {
                this.mensagem = ex.ToString();
            }
        }

        public void cadastroAnimal(string Raca, string Especie, string Nome, string Cor, string Sexo, string Dt_nascimento, int id_cliente)
        {
            // Comando Sql - insert
            cmd.CommandText = "insert into tb_animal values (@Raca, @Especie, @Nome, @Cor, @Sexo, @Dt_nascimento, @id_cliente)";

            // Parametros
            cmd.Parameters.AddWithValue("@Raca", Raca);
            cmd.Parameters.AddWithValue("@Especie", Especie);
            cmd.Parameters.AddWithValue("@Nome", Nome);
            cmd.Parameters.AddWithValue("@Cor", Cor);
            cmd.Parameters.AddWithValue("@Sexo", Sexo);
            cmd.Parameters.AddWithValue("@Dt_nascimento", Dt_nascimento);
            cmd.Parameters.AddWithValue("@id_cliente", id_cliente);

            // Conectar com o banco
            try
            {
                // Conectando
                cmd.Connection = conexao.conectar();
                // Executar o comando Sql
                cmd.ExecuteNonQuery();
                // Desconectar
                conexao.desconectar();
                // Mensagem
                this.mensagem = "Animal cadastrado com sucesso!!";
            }
            catch (Exception ex)
            {
                this.mensagem = ex.ToString();
            }
        }

        public void cadastroClientes(string Nome, string Endereco, string Dt_nascimento, string Contato, string Sexo, string CPF)
        {
            // Comando Sql - insert
            cmd.CommandText = "insert into tb_clientes values (@Nome, @Endereco, @Dt_nascimento, @Contato, @Sexo, @CPF)";

            // Parametros
            cmd.Parameters.AddWithValue("@Nome", Nome);
            cmd.Parameters.AddWithValue("@Endereco", Endereco);
            cmd.Parameters.AddWithValue("@Dt_nascimento", Dt_nascimento);
            cmd.Parameters.AddWithValue("@Contato", Contato);
            cmd.Parameters.AddWithValue("@Sexo", Sexo);
            cmd.Parameters.AddWithValue("@CPF", CPF);

            // Conectar com o banco
            try
            {
                // Conectando
                cmd.Connection = conexao.conectar();
                // Executar o comando Sql
                cmd.ExecuteNonQuery();
                // Desconectar
                conexao.desconectar();
                // Mensagem
                this.mensagem = "Cliente cadastrado com sucesso!!";
            }
            catch (Exception ex)
            {
                this.mensagem = ex.ToString();
            }
        }

        public void cadastroConsulta(string Dt_consulta, string Exames, string Medicamentos, string Resultados, string Dt_retorno, string id_animal, string id_cliente)
        {
            // Comando Sql - insert
            cmd.CommandText = "insert into tb_consulta values (@Dt_consulta, @Exames, @Medicamentos, @Resultados, @Dt_retorno, @id_animal, @id_cliente)";

            // Parametros
            cmd.Parameters.AddWithValue("@Dt_consulta", Dt_consulta);
            cmd.Parameters.AddWithValue("@Exames", Exames);
            cmd.Parameters.AddWithValue("@Medicamentos", Medicamentos);
            cmd.Parameters.AddWithValue("@Resultados", Resultados);
            cmd.Parameters.AddWithValue("@Dt_retorno", Dt_retorno);
            cmd.Parameters.AddWithValue("@id_animal", id_animal);
            cmd.Parameters.AddWithValue("@id_cliente", id_cliente);

            // Conectar com o banco
            try
            {
                // Conectando
                cmd.Connection = conexao.conectar();
                // Executar o comando Sql
                cmd.ExecuteNonQuery();
                // Desconectar
                conexao.desconectar();
                // Mensagem
                this.mensagem = "Cliente cadastrado com sucesso!!";
            }
            catch (Exception ex)
            {
                this.mensagem = ex.ToString();
            }
        }
        //

        // UPDATES

        public void updateFuncionario(string Nome, string Cargo, string CPF, string Matricula, string Endereco, string Contato, string Dt_nascimento, string Dt_Contratacao, string Dt_Desligamento, string Salario, int id_funcionario)
        {
            // Comando Sql - update
            cmd.CommandText = "UPDATE tb_funcionario SET Nome = @Nome, Cargo = @Cargo, CPF = @CPF, Matricula = @Matricula, Endereco = @Endereco, Contato = @Contato, Dt_nascimento = @Dt_nascimento, Dt_Contratacao = @Dt_Contratacao, Dt_Desligamento = @Dt_Desligamento, Salario = @Salario, WHERE id_funcionario = @id_funcionario";

            // Parametros
            cmd.Parameters.AddWithValue("@Nome", Nome);
            cmd.Parameters.AddWithValue("@Cargo", Cargo);
            cmd.Parameters.AddWithValue("@CPF", CPF);
            cmd.Parameters.AddWithValue("@Matricula", Matricula);
            cmd.Parameters.AddWithValue("@Endereco", Endereco);
            cmd.Parameters.AddWithValue("@Contato", Contato);
            cmd.Parameters.AddWithValue("@Dt_nascimento", Dt_nascimento);
            cmd.Parameters.AddWithValue("@Dt_Contratacao", Dt_Contratacao);
            cmd.Parameters.AddWithValue("@Dt_Desligamento", Dt_Desligamento);
            cmd.Parameters.AddWithValue("@Salario", Salario);
            cmd.Parameters.AddWithValue("@id_funcionario", id_funcionario);

            // Conectar com o banco
            try
            {
                // Conectando
                cmd.Connection = conexao.conectar();
                // Executar o comando Sql
                cmd.ExecuteNonQuery();
                // Desconectar
                conexao.desconectar();
                // Mensagem
                this.mensagem = "Cadastro atualizado com sucesso!!";
            }
            catch (Exception ex)
            {
                this.mensagem = ex.ToString();
            }
        }

        public void updateClientes(string Nome, string Endereco, string Dt_nascimento, string Contato, string Sexo, string CPF, int id_cliente)
        {
            // Comando Sql - update
            cmd.CommandText = "UPDATE tb_clientes SET Nome = @Nome, Endereco = @Endereco, Dt_nascimento = @Dt_nascimento, Contato = @Contato, Sexo = @Sexo, CPF = @CPF WHERE id_cliente = @id_cliente";

            // Parametros
            cmd.Parameters.AddWithValue("@Nome", Nome);
            cmd.Parameters.AddWithValue("@Endereco", Endereco);
            cmd.Parameters.AddWithValue("@Dt_nascimento", Dt_nascimento);
            cmd.Parameters.AddWithValue("@Contato", Contato);
            cmd.Parameters.AddWithValue("@Sexo", Sexo);
            cmd.Parameters.AddWithValue("@CPF", CPF);
            cmd.Parameters.AddWithValue("@id_cliente", id_cliente);

            // Conectar com o banco
            try
            {
                // Conectando
                cmd.Connection = conexao.conectar();
                // Executar o comando Sql
                cmd.ExecuteNonQuery();
                // Desconectar
                conexao.desconectar();
                // Mensagem
                this.mensagem = "Cadastro atualizado com sucesso!!";
            }
            catch (Exception ex)
            {
                this.mensagem = ex.ToString();
            }
        }

        public void updateConsulta(string Dt_consulta, string Exames, string Medicamentos, string Resultados, string Dt_retorno, string id_animal, string id_cliente, int id_consulta)
        {
            // Comando Sql - update
            cmd.CommandText = "UPDATE tb_consulta SET Dt_consulta = @Dt_consulta, Exames = @Exames, Medicamentos = @Medicamentos, Resultados = @Resultados, Dt_retorno = @Dt_retorno, id_animal = @id_cliente WHERE id_consulta = @id_consulta";

            // Parametros
            cmd.Parameters.AddWithValue("@Dt_consulta", Dt_consulta);
            cmd.Parameters.AddWithValue("@Exames", Exames);
            cmd.Parameters.AddWithValue("@Medicamentos", Medicamentos);
            cmd.Parameters.AddWithValue("@Resultados", Resultados);
            cmd.Parameters.AddWithValue("@Dt_retorno", Dt_retorno);
            cmd.Parameters.AddWithValue("@id_animal", id_animal);
            cmd.Parameters.AddWithValue("@id_cliente", id_cliente);
            cmd.Parameters.AddWithValue("@id_consulta", id_consulta);

            // Conectar com o banco
            try
            {
                // Conectando
                cmd.Connection = conexao.conectar();
                // Executar o comando Sql
                cmd.ExecuteNonQuery();
                // Desconectar
                conexao.desconectar();
                // Mensagem
                this.mensagem = "Cadastro atualizado com sucesso!!";
            }
            catch (Exception ex)
            {
                this.mensagem = ex.ToString();
            }
        }

        public void updateAnimal(string Raca, string Especie, string Nome, string Cor, string Sexo, string Dt_nascimento, int id_cliente, int id_animal)
        {
            // Comando Sql - update
            cmd.CommandText = "UPDATE tb_animal SET Raca = @Raca, Especie = @Especie, Nome = @Nome, Cor = @Cor, Sexo = @Sexo, Dt_nascimento = @Dt_nascimento, id_cliente = @id_cliente WHERE id_animal = @id_animal";

            // Parametros
            cmd.Parameters.AddWithValue("@Raca", Raca);
            cmd.Parameters.AddWithValue("@Especie", Especie);
            cmd.Parameters.AddWithValue("@Nome", Nome);
            cmd.Parameters.AddWithValue("@Cor", Cor);
            cmd.Parameters.AddWithValue("@Sexo", Sexo);
            cmd.Parameters.AddWithValue("@Dt_nascimento", Dt_nascimento);
            cmd.Parameters.AddWithValue("@id_cliente", id_cliente);
            cmd.Parameters.AddWithValue("@id_animal", id_animal);

            // Conectar com o banco
            try
            {
                // Conectando
                cmd.Connection = conexao.conectar();
                // Executar o comando Sql
                cmd.ExecuteNonQuery();
                // Desconectar
                conexao.desconectar();
                // Mensagem
                this.mensagem = "Cadatro atualizado com sucesso!!";
            }
            catch (Exception ex)
            {
                this.mensagem = ex.ToString();
            }
        }
        //

        // DELETES

        public void deleteFuncionario(int id_funcionario)
        {
            // Comando Sql - delete
            cmd.CommandText = "DELETE tb_funcionario WHERE id_funcionario = @id_funcionario";

            // Parametros
            cmd.Parameters.AddWithValue("@id_funcionario", id_funcionario);

            // Conectar com o banco
            try
            {
                // Conectando
                cmd.Connection = conexao.conectar();
                // Executar o comando Sql
                cmd.ExecuteNonQuery();
                // Desconectar
                conexao.desconectar();
                // Mensagem
                this.mensagem = "Cadastro apagado com sucesso!!";
            }
            catch (Exception ex)
            {
                this.mensagem = ex.ToString();
            }
        }

        public void deleteConsulta(int id_consulta)
        {
            // Comando Sql - delete
            cmd.CommandText = "DELETE tb_consulta WHERE id_consulta = @id_consulta";

            // Parametros
            cmd.Parameters.AddWithValue("@id_consulta", id_consulta);

            // Conectar com o banco
            try
            {
                // Conectando
                cmd.Connection = conexao.conectar();
                // Executar o comando Sql
                cmd.ExecuteNonQuery();
                // Desconectar
                conexao.desconectar();
                // Mensagem
                this.mensagem = "Cadastro apagado com sucesso!!";
            }
            catch (Exception ex)
            {
                this.mensagem = ex.ToString();
            }
        }

        public void deleteClientes(int id_cliente)
        {
            // Comando Sql - delete
            cmd.CommandText = "DELETE tb_clientes WHERE id_cliente = @id_cliente";

            // Parametros
            cmd.Parameters.AddWithValue("@id_cliente", id_cliente);

            // Conectar com o banco
            try
            {
                // Conectando
                cmd.Connection = conexao.conectar();
                // Executar o comando Sql
                cmd.ExecuteNonQuery();
                // Desconectar
                conexao.desconectar();
                // Mensagem
                this.mensagem = "Cadastro apagado com sucesso!!";
            }
            catch (Exception ex)
            {
                this.mensagem = ex.ToString();
            }
        }

        public void deleteAnimal(int id_animal)
        {
            // Comando Sql - delete
            cmd.CommandText = "DELETE tb_animal WHERE id_animal = @id_animal";

            // Parametros
            cmd.Parameters.AddWithValue("@id_animal", id_animal);

            // Conectar com o banco
            try
            {
                // Conectando
                cmd.Connection = conexao.conectar();
                // Executar o comando Sql
                cmd.ExecuteNonQuery();
                // Desconectar
                conexao.desconectar();
                // Mensagem
                this.mensagem = "Cadastro apagado com sucesso!!";
            }
            catch (Exception ex)
            {
                this.mensagem = ex.ToString();
            }
        }
        //
    }
}
