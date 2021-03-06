﻿using System;
using System.Collections.Generic;
using System.Text;
using XF.MVVMBasic.Model;

namespace XF.MVVMBasic.ViewModel
{
    class AlunoViewModel
    {
        #region
        public string RM { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        #endregion

        public AlunoViewModel(Aluno aluno)
        {
            this.RM = aluno.RM;
            this.Nome = aluno.Nome;
            this.Email = aluno.Email;
        }
        public static Aluno GetAluno()
        {
            var aluno = new Aluno
            {
                Id = Guid.NewGuid(),
                RM = "54321",
                Nome = "Anderson Silva",
                Email = "anderson@aluno.ifsp.edu.br"
            };
            return aluno;
        }
    }
}
