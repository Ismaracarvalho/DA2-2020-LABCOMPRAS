using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DA2_2020_LABCOMPRAS.Models
{
    public class Despesa
    {
        private string _nomeDespesa;
        private int _quantidade;
        private double _valor;
        private string _categoria;
        private Boolean _pago;

        public String NomeDespesa 
        {
            get { return _nomeDespesa; }
            set { value = _nomeDespesa; }
        }
        public int Quantidade
        {
            get { return  _quantidade; }
            set { value = _quantidade; }
        }
        public double Valor
        {
            get { return _valor; }
            set { value = _valor; }
        }
        public String Categoria
        {
            get { return _categoria; }
            set { value = _categoria; }
        }
        public Boolean Pago
        {
            get { return _pago; }
            set { value = _pago; }
        }

    }
}
