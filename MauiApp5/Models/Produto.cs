using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace MauiApp5.Models
{
    public class Produto
    {
        [PrimaryKey, AutoIncrement]

        public int Id { get; set; }
        public string Descrição { get; set; }
        public double Quantidade { get; set; }
        public double Preco { get; set; }
        public double total { get => Quantidade * Preco; }

    }
}
