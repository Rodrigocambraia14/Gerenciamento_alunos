using System;
using System.Collections.Generic;

namespace Sistema_turma.Models
{
    public class CadastroAluno 
    {
        public static List<Aluno> alunos1 = new List<Aluno>();
        public static List<Aluno> alunos2 = new List<Aluno>();
        public static List<Aluno> alunos3 = new List<Aluno>();
        public static void Incluir (Aluno aluno)
        {
            switch(aluno.Turma)
            {
                case 1:
                    alunos1.Add(aluno);
                break;

                case 2:

                    alunos2.Add(aluno);
                break;

                case 3:

                    alunos3.Add(aluno);
                break;
            }
            
        }

        public static void CalcularMedia(Aluno aluno)
        {
            aluno.Media = (float)((aluno.Nota1 + (aluno.Nota2 * 1.2) + (aluno.Nota3 * 1.4))/ 3.6);
            
        }
        public static List<Aluno> Listar1()
        {
            return alunos1;
        }
        public static List<Aluno> Listar2()
        {
            return alunos2;
        }
        public static List<Aluno> Listar3()
        {
            return alunos3;
        }
    }
}