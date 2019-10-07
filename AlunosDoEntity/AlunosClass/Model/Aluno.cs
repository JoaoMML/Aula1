using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlunosClass.Model
{
    public class Aluno
    {
        [Key]
        public int Id { get; set; }
        //[Required, Range(2, 200)]
        public string Nome { get; set; }
    }
}
