using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsability
{
    public class Coordinador: IControlador
    {
        IControlador controlador;
        public void setNext(IControlador controlador)
        {
            this.controlador = controlador;
        }

        public void validaImporte(double _dImporte, string cConcepto)
        {

            if (_dImporte <= 5000)
                Console.WriteLine("{0}\"AUTORIZADA\" Por El Coordinador", cConcepto);
            else
                Console.WriteLine("{0}\"DENEGADA\" Por El Coordinador", cConcepto);
            controlador.validaImporte(_dImporte, cConcepto);

        }
        
    }
}
