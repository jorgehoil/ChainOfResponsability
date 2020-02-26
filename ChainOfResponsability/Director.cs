using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsability
{
    public class Director : IControlador
    {
        IControlador controlador;
        public void setNext(IControlador controlador)
        {
            this.controlador = controlador;
        }

        public void validaImporte(double _dImporte, string cConcepto)
        {
            if (_dImporte > 15000 && _dImporte <= 50000)
                Console.WriteLine("{0}\"AUTORIZADA\" Por El Director", cConcepto);
            else
                Console.WriteLine("{0}\"DENEGADA\" Por El Director", cConcepto);
            if(controlador!=null)
                controlador.validaImporte(_dImporte,cConcepto);


        }
    }
}
