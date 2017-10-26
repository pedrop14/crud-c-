using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD
{
    public partial class Form1 : Form
    {
        ConexaoBD banco;


        public Form1()
        {
            InitializeComponent();
            btnListarGrades.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            banco = ConexaoBD.Instanciar_Banco();
        }

        private void btnselectAlunos_Click(object sender, EventArgs e)
        {
            if(dgvCursos.CurrentRow  == null)
            {
                MessageBox.Show("Selecione um curso para listar seus alunos matriculados");
            }
            else
            {
                int codcurso = int.Parse(dgvCursos.CurrentRow.Cells[0].Value.ToString());
                DataTable alunos = banco.SelectAlunos(codcurso);
                if (alunos != default(DataTable))
                {
                    dgvAlunos.DataSource = alunos;
                }
            }
        }

        private void btnListarCursos_Click(object sender, EventArgs e)
        {
            DataTable cursos = banco.SelectCursos();
            if(cursos != default(DataTable))
            {
                dgvCursos.DataSource = cursos;
                btnListarGrades.Enabled = true;
                
            }
        }

        private void btnListarGrades_Click(object sender, EventArgs e)
        {

            if (dgvCursos.CurrentRow == null)
            {
                MessageBox.Show("Selecione um curso para listar suas grades");
            }
            else
            {
                dgvGrades.Enabled = true;
                int codcurso = int.Parse(dgvCursos.CurrentRow.Cells[0].Value.ToString());

                DataTable grades = banco.SelectGrades(codcurso);
                if (grades != default(DataTable))
                {
                   dgvGrades.DataSource = grades;
                    btnDisciplina.Enabled = true;
                }
            }
        }

        private void btnDisciplina_Click(object sender, EventArgs e)
        {
            if(dgvGrades.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma grade para listar suas disciplinas");
            }else
            {
                int Codgrade = int.Parse(dgvGrades.CurrentRow.Cells[0].Value.ToString());
                DataTable disci = banco.SelectDisciplina(Codgrade);
                if(disci != default(DataTable))
                {
                    dgvDisciplinas.DataSource = disci;
                }
            }
        }

        private void bntListarTurmas_Click(object sender, EventArgs e)
        {
            if(dgvDisciplinas.CurrentRow == null)
            {
                MessageBox.Show("Selecionar uma disciplinas para listar as turmas da disciplina.");
            }else
            {
                int codDisc = int.Parse(dgvDisciplinas.CurrentRow.Cells[0].Value.ToString());
                DataTable turmas = banco.SelectTurmas(codDisc);
                if(turmas != default(DataTable))
                {
                    dgvTurmas.DataSource = turmas;
                }
            }
        }

        private void btnAlunosTurma_Click(object sender, EventArgs e)
        {
            if(dgvTurmas.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma turma para listar o alunos da turma.");
            }else
            {
                int codTurma = int.Parse(dgvTurmas.CurrentRow.Cells[0].Value.ToString());
                DataTable alunosT = banco.SelectAlunosTurma(codTurma);
                if(alunosT != default(DataTable))
                {
                    dgvAlunos.DataSource = alunosT;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(dgvAlunos.CurrentRow == null)
            {
                MessageBox.Show("Selecione um aluno para exibir seu histórico.");
            }else
            {
                int codAluno = int.Parse(dgvAlunos.CurrentRow.Cells[0].Value.ToString());
                DataTable histAluno = banco.HistoricoAluno(codAluno);
                if(histAluno != default(DataTable))
                {
                    dgvHistorico.DataSource = histAluno;
                }
            }
        }

        private void btnCancelarConsulta_Click(object sender, EventArgs e)
        {
            dgvConsultaLivre.DataSource = null; 
            textBoxConsulta.Clear();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string query = textBoxConsulta.Text.ToLower();
            if (query.Contains("drop"))
            {
                MessageBox.Show("Comando não permitido.");
            }else
            {
                DataTable consult = banco.SelectAll(query);
                if (consult != default(DataTable))
                {
                    dgvConsultaLivre.DataSource = consult;
                    MessageBox.Show("Comando executado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Verifique a sintaxe SQL", "Erro de Consulta");

                }
            }
            
        }

        private void crudInsert_Click(object sender, EventArgs e)
        {
            if(comboTabelas.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione a entidade antes de inserir.");
            }else
            {
                textBoxConsulta.Clear();
                textBoxConsulta.Text = Estrutura.RetornaEstruturaInsert(comboTabelas.SelectedItem.ToString());
            }
        }

        private void crudUpdate_Click(object sender, EventArgs e)
        {
            if (comboTabelas.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione a entidade antes de atualizar.");
            }
            else
            {
                textBoxConsulta.Clear();
                textBoxConsulta.Text = Estrutura.RetornaEstruturaUpdate(comboTabelas.SelectedItem.ToString());

            }
        }

        private void crudDelete_Click(object sender, EventArgs e)
        {
            if (comboTabelas.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione a entidade antes de deletar.");
            }
            else
            {
                textBoxConsulta.Clear();
                textBoxConsulta.Text = Estrutura.RetornaEstruturaDelete(comboTabelas.SelectedItem.ToString());

            }
        }

        private void cbConsultasSalvas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbConsultasSalvas.SelectedIndex == -1)
            {

            }else
            {
                dgvConsultaLivre.DataSource = null;
                textBoxConsulta.Clear();
                int pos = cbConsultasSalvas.SelectedIndex;
                string query = Estrutura.ConsultasComplexas(pos);
                if(query == " ")
                {
                    MessageBox.Show("Tente novamente.");
                    cbConsultasSalvas.SelectedIndex = -1;
                    dgvConsultaLivre.DataSource = null;
                    textBoxConsulta.Clear();
                }else
                {
                    textBoxConsulta.Text = query;
                }
            }
        }
    }
}
