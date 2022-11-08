using System;
using System.Collections.Generic;
using System.Text;

namespace AppConselho.Model
{
     public class Conselho
    {

        public string Id { get; set; }
        public string Mensagem { get; set; }

      
        public Conselho()
        {

            this.Id = "";
            this.Mensagem = "";
        }
    }
}
