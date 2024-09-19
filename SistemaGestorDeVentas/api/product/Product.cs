using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestorDeVentas.api.product
{
    internal interface IProduct
    {
        int codProduct{get; set;}
        string name { get; set; }
        string description { get; set; }
        decimal price { get; set; }
        int quantity { get; set; }
        bool status { get; set; }
    }
}
