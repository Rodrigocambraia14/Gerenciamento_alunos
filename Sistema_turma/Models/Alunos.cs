using System;
using System.Collections.Generic;

namespace Sistema_turma.Models
{
    public class Alunos
    {
        public string Nome {get;set;}
    
        public float Nota1 {get;set;}
    
        public float Nota2 {get;set;}
     
        public float Nota3 {get;set;}
        public float NotaFinal {get;set;}
        public float Media {get;set;}
        public float MediaFinal {get;set;}
        public float MaiorMedia {get;set;}

        public string Mensagem {get;set;}
        public string MensagemFinal {get;set;}
       
    }

}