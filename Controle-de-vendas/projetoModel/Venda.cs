﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_vendas.projetoModel
{
    public class Venda
    {
        public int id { get; set; }
        public int cliente_id { get; set; }
        public DateTime data_venda { get; set; }
        public decimal total_venda { get; set; }
        public string observacoes { get; set; }
    }
}
