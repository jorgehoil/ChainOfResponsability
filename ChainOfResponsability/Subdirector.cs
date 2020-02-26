using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsability
{
    public class Subdirector: IControlador
    {
        IControlador controlador;
        public void setNext(IControlador controlador)
        {
            this.controlador = controlador;
        }

        public void validaImporte(double _dImporte, string cConcepto)
        {

            if (_dImporte > 10000 && _dImporte <= 15000)
                Console.WriteLine("{0}\"AUTORIZADA\" Por El Subdirector", cConcepto);
            else
                Console.WriteLine("{0}\"DENEGADA\" Por El Subdirector", cConcepto);
            controlador.validaImporte(_dImporte, cConcepto);

        }
    }
}
