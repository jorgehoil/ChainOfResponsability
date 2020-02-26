using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsability
{
    public interface IControlador
    {
       void setNext(IControlador controlador);
       void validaImporte(double dImporte, string cConcepto);
    }
}
