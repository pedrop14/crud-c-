using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace BD
{
    public class ConexaoBD
    {
        
        private DataSet mDataSet;
        private MySqlConnection mConn;  //conexão 
        private MySqlDataAdapter mAdapter;

        static ConexaoBD instanciaBanco = null;

        private ConexaoBD()
        {
            mDataSet = new DataSet();
            mConn = new MySqlConnection(" Persist Security Info=False;server=localhost;database=sgati;uid = root; pwd =");
        } 

        static public ConexaoBD Instanciar_Banco()
        {
            if (instanciaBanco == null)
                instanciaBanco = new ConexaoBD();
            return instanciaBanco;
        }
        
        public bool AbrirConexao()
         {
            try
            {
                mConn.Open();
              
                return true;
               
            }
            catch (Exception e)
            {
                // Banco de Dados não conectado
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                mConn.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }
        }

        public bool InsertAluno(string nome_Aluno, string CodMatricula)
        {
           string query = "INSERT INTO aluno (nome_Aluno, CodMatricula) VALUES('" + nome_Aluno.ToString() + "', '" + int.Parse(CodMatricula) + "')";
            if(ConectInsert(query) == true)
            {
                return true;
            }
            return false;
        }

        public bool InsertProfessor(string nome_Prof, string CodProfessor)
        {
            string query = "INSERT INTO professor (nome_Prof, CodProfessor) VALUES('" + nome_Prof.ToString() + "', '" + int.Parse(CodProfessor) + "')";
            if (ConectInsert(query) == true)
            {
                return true;
            }
            return false;
        }

        public bool InsertCurso(string CodCurso, string nome_Curso)
        {
            string query = "INSERT INTO curso (CodCurso, nome_Curso) VALUES('" + int.Parse(CodCurso) + "', '" + nome_Curso.ToString() + "')";
            if (ConectInsert(query) == true)
            {
                return true;
            }
            return false;
        }

        public bool InsertTurma(string codTurma, string codProfessor, string codDisciplina)
        {
            string query = "INSERT INTO turma (CodTurma, CodProfessor, CodDisciplina) VALUES('" + int.Parse(codTurma) + "', '" + int.Parse(codProfessor) + "','"+int.Parse(codDisciplina)+"')";
            if (ConectInsert(query) == true)
            {
                return true;
            }
            return false;
        }

        public bool InsertCursa(string CodCurso, string CodMatricula)
        {
            string query = "INSERT INTO cursa (CodCurso, CodMatricula) VALUES('" + int.Parse(CodCurso) + "', '" + int.Parse(CodMatricula) + "')";
            if (ConectInsert(query) == true)
            {
                return true;
            }
            return false;
        }

        public bool InsertDisciplina(string CodDisciplina, string carga_Horaria, string nome_Disc)
        {
            string query = "INSERT INTO disciplina (CodDisciplina, carga_Horaria,nome_Disc) VALUES('" + int.Parse(CodDisciplina) + "', '" + int.Parse(carga_Horaria) + "','" + nome_Disc.ToString() +"')";
            if (ConectInsert(query) == true)
            {
                return true;
            }
            return false;
        }

        public bool InsertMatricula(string CodTurma, string CodMatricula)
        {
            string query = "INSERT INTO matricula (CodTurma, CodMatricula) VALUES('" + int.Parse(CodTurma) + "', '" + int.Parse(CodMatricula) + "')";
            if (ConectInsert(query) == true)
            {
                return true;
            }
            return false;
        }

        public bool ConectInsert(string querySQL)
        {
            if (this.AbrirConexao() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(querySQL, mConn);

                //Execute command
                int execute = cmd.ExecuteNonQuery();
                if(execute < 1)
                {
                    return false;
                }
                if (this.CloseConnection()== false)
                {
                    return false;
                }
                return true;
            }
            return false;
        }

        public DataTable SelectAll(string query)
        {
            try
            {
                if (AbrirConexao() == true)
                {
                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(query, mConn);
                    // int rows = cmd.ExecuteNonQuery();
                    MySqlDataAdapter dAdap = new MySqlDataAdapter(cmd);
                    DataSet dSet = new DataSet();
                    DataTable table = new DataTable();
                    dAdap.Fill(table);
                    CloseConnection();
                    return table;
                }

                return default(DataTable);
            }
            catch (Exception)
            {
                return default(DataTable);
            }
        }

        public DataTable SelectAlunos(int codCurso)
        {
            string query = "SELECT CR.CodMatricula, A.nome_Aluno from aluno A, curso C, cursa CR where A.CodMatricula = CR.CodMatricula AND C.CodCurso = CR.CodCurso AND C.CodCurso ="+codCurso;
            return SelectAll(query);
        }

        public DataTable SelectCursos()
        {
            string query = "SELECT * FROM `curso`";
            return SelectAll(query);
        }

        public DataTable SelectGrades(int curso)
        {
            string query = "SELECT grade.codGrade, grade.CodCurso FROM `grade` WHERE CodCurso ="+curso;
            return SelectAll(query);
        }

        public DataTable SelectDisciplina(int grade)
        {
            string query = "select D.CodDisciplina, D.nome_Disc, D.carga_Horária from disciplina D, grade G where D.CodDisciplina = G.CodDisciplina and G.codGrade =" + grade;
            return SelectAll(query);
        }

        public DataTable SelectTurmas(int disc)
        {
            string query = "select T.CodTurma, D.nome_Disc, P.nome_Prof, T.codSemestre from disciplina D, turma T, professor P where D.CodDisciplina = T.CodDisciplina AND T.CodProfessor = P.CodProfessor AND T.CodDisciplina =" + disc;
            return SelectAll(query);
        }

        public DataTable SelectAlunosTurma(int codTurma)
        {
            string query = "select A.CodMatricula, A.nome_Aluno, M.Frequencia from aluno A, matricula M where A.CodMatricula = M.CodMatricula and M.CodTurma =" + codTurma;
            return SelectAll(query);
        }

        public DataTable HistoricoAluno(int codAluno)
        {
            string query = "select A.CodMatricula, D.nome_Disc, M.Frequencia, M.NotaFinal, T.codSemestre from aluno A, matricula M, turma T, disciplina D  where A.CodMatricula = M.CodMatricula and M.CodTurma = T.CodTurma and D.CodDisciplina = T.CodDisciplina and A.CodMatricula =" + codAluno;
            return SelectAll(query);
        }

    }
}
