using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeraEtrega
{
    public class ProductoVendido
    {
        private int _id;
        private int _idProducto;
        private int _stock;
        private int _idVenta;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public int IdProducto
        {
            get { return _idProducto; }
            set { _idProducto = value; }
        }
        public int Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }
        public int IdVenta
        {
            get { return _idVenta; }
            set { _idVenta = value; }
        }
    }
}