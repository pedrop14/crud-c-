using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    static class Estrutura
    {
        static public string RetornaEstruturaInsert(string tabela)
        {
            string query = " ";
            string tab = tabela;
            switch (tab)
            {
                case "Alunos":
                    query = "INSERT INTO `sgati`.`aluno` (`nome_Aluno`) VALUES ('NOME DO ALUNO');";
                    break;

                case "Professores":
                    query = "INSERT INTO `sgati`.`professor` (`nome_Prof`) VALUES ('NOME DO PROFESSOR');";
                    break;

                case "Cursos":
                    query = "INSERT INTO `sgati`.`curso` (`nome_Curso`) VALUES('NOME DO CURSO');";
                    break;

                case "Disciplinas":
                    query = "INSERT INTO `sgati`.`disciplina` (`carga_Horária`, `nome_Disc`) VALUES ('Carga', 'Nome da Disciplina');";
                    break;

            }
            return query;
        }

        static public string RetornaEstruturaUpdate(string tabela)
        {
            string query = " ";
            string tab = tabela;
            switch (tab)
            {
                case "Alunos":
                    query = "UPDATE `sgati`.`aluno` SET `nome_Aluno`='NOVO NOME' WHERE `CodMatricula`='MATRICULA';";
                    break;

                case "Professores":
                    query = "UPDATE `sgati`.`professor` SET `nome_Prof`='NOVO NOME' WHERE `CodProfessor`='CODIGO PROFESSOR';";
                    break;

                case "Cursos":
                    query = "UPDATE `sgati`.`curso` SET `nome_Curso`='NOVO NOME' WHERE `CodCurso`='CODIGO CURSO';";
                    break;

                case "Disciplinas":
                    query = "UPDATE `sgati`.`disciplina` SET `nome_Disc`='NOVO NOME' WHERE `CodDisciplina`='CODIGO DISCIPLINA';";
                    break;

            }
            return query;
        }

        static public string RetornaEstruturaDelete(string tabela)
        {
            string query = " ";
            string tab = tabela;
            switch (tab)
            {
                case "Alunos":
                    query = "DELETE FROM `sgati`.`aluno` WHERE `CodMatricula`='CODIGO ALUNO';";
                    break;

                case "Professores":
                    query = "DELETE FROM `sgati`.`professor` WHERE `CodProfessor`='CODIGO PROFESSOR';";
                    break;

                case "Cursos":
                    query = "DELETE FROM `sgati`.`curso` WHERE `CodCurso`='CODIGO CURSO';";
                    break;

                case "Disciplinas":
                    query = "DELETE FROM `sgati`.`disciplina` WHERE `CodDisciplina`='CODIGO DISCIPLINA';";
                    break;

            }
            return query;
        }


        static public string ConsultasComplexas(int pos)
        {
            string query = " ";
            switch (pos)
            {
                case 0:
                    query = "select p.nome_Prof from professor p join turma t on p.CodProfessor = t.CodProfessor join disciplina d on t.CodDisciplina = d.CodDisciplina join grade g on g.CodDisciplina = d.CodDisciplina join curso c on c.CodCurso = g.CodCurso where d.nome_Disc = \"Bancos de Dados\" and c.nome_Curso = \"Sistemas de Informação\"; "; 
                    break;
                case 1:
                    query = "select count(m.CodMatricula),d.Nome_Disc from matricula m join turma t on m.CodTurma = t.CodTurma join disciplina d on t.CodDisciplina = d.CodDisciplina join grade g on g.CodDisciplina = d.CodDisciplina join curso c on c.CodCurso = g.CodCurso where m.NotaFinal < 60 and c.nome_Curso = \"Sistemas de Informação\" group by d. nome_Disc;";
                    break;
                case 2:
                    query = "select a.nome_Aluno, m.NotaFinal from aluno a , matricula m join turma t on t.CodTurma = m.CodTurma join disciplina d on d.CodDisciplina = t.CodDisciplina join semestre s on s.codSemestre = t.codSemestre where a.CodMatricula = m.CodMatricula and d.nome_Disc = 'Bancos de Dados' and s.ano = 2010 and m.NotaFinal < all (select avg (m.NotaFinal) from matricula where d.nome_Disc = 'Bancos de Dados' and s.ano = 2010) group by m.NotaFinal desc;";
                    break;
                case 3:
                    query = "select m.CodMatricula, avg(m.NotaFinal) from matricula m join turma t on m.CodTurma = t.CodTurma join disciplina d on d.CodDisciplina = t.CodDisciplina where d.nome_Disc = \"Bancos de Dados\" group by m.CodMatricula having avg(m.NotaFinal) < all (select avg(m.NotaFinal));";
                    break;
                case 4:
                    query = "select p.nome_Prof from professor p join turma t on p.CodProfessor = t.CodProfessor join disciplina d on t.CodDisciplina = d.CodDisciplina join semestre s on t.codSemestre = s.codSemestre where d.nome_Disc = \"AED\" AND s.ano between 1990 and 1995;";
                    break;
                case 5:
                    query = "select count(m.CodMatricula), m.NotaFinal from professor p, turma t, semestre s, matricula m where p.CodProfessor = t.CodProfessor and t.codSemestre = s.codSemestre and m.CodTurma = t.CodTurma and p.nome_Prof like ('%Claudinei%')and s.ano = 2015 and m.NotaFinal >80 group by m.NotaFinal having count(m.CodMatricula) > 5;";
                    break;
                case 6:
                    query = "select a.nome_Aluno as nomes from aluno a, matricula m, turma t where a.CodMatricula = m.CodMatricula and t.CodTurma = m.CodTurma and a.nome_Aluno like ('%son%') union select p.nome_Prof as nomes from professor p, turma t where p.CodProfessor = t.CodProfessor and p.nome_Prof like ('%son%');";
                    break;
                case 7:
                    query = "Select distinct nome_Aluno FROM aluno a where a.nome_Aluno IN (select a.nome_Aluno from aluno a, matricula m, turma t, semestre s, disciplina d where a.CodMatricula = m.CodMatricula and t.CodTurma = m.CodTurma and s.CodSemestre = t.CodSemestre and t.CodDisciplina = d.CodDisciplina and d.nome_Disc = \"POO\" and t.CodSemestre = 20162) AND a.nome_Aluno IN (select nome_Aluno from aluno a, matricula m, turma t, semestre s, disciplina d where a.CodMatricula = m.CodMatricula and t.CodTurma = m.CodTurma and s.CodSemestre = t.CodSemestre and t.CodDisciplina = d.CodDisciplina and d.nome_Disc = \"AED\" and t.CodSemestre = 20162);";
                    break;
                case 8:
                    query = "select i.nome_instituicao from instituicao i where i.nome_instituicao not in (select i.nome_instituicao from instituicao i, oferta o, curso c where i.CodInstituicao = o. CodInstituicao and o.CodCurso = c.CodCurso and c.nome_Curso = \"Sistemas de Informação\");";
                    break;
                case 9:
                    query = "create view aluno_prof as select a.nome_Aluno as aluno, p.nome_Prof as professor from turma t join professor p on t.CodProfessor = p.CodProfessor join matricula m on t.CodTurma = m.CodTurma join aluno a on a.CodMatricula = m.CodMatricula;";
                    break;
                case 10:
                    query = "create view curso_disc as select c.nome_Curso as curso, d.nome_Disc as disciplina from curso c join grade g on c.CodCurso= g.CodCurso join disciplina d on d.CodDisciplina = g.CodDisciplina where c.nome_Curso = \"Sistemas de Informação\";";
                    break;

            }
            return query;
        }


    }
}
