using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsability
{
    public class Gerente : IControlador
    {
        IControlador controlador;
        public void setNext(IControlador controlador)
        {
            this.controlador = controlador;
        }

        public void validaImporte(double _dImporte, string cConcepto)
        {

            if (_dImporte > 5000&&_dImporte<=10000)
                Console.WriteLine("{0}\"AUTORIZADA\" Por El Gerente", cConcepto);
            else
                Console.WriteLine("{0}\"DENEGADA\" Por El Gerente", cConcepto);
            controlador.validaImporte(_dImporte, cConcepto);
        }
    }
}
