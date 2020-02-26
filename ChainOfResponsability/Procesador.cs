using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsability
{
    public class Procesador
    {
        IControlador coordinador = new Coordinador();
        IControlador gerente = new Gerente();
        IControlador subdirector = new Subdirector();
        IControlador director = new Director();

        public void procesar(double dImporte, string cConcepto)
        {
            coordinador.setNext(gerente);
            gerente.setNext(subdirector);
            subdirector.setNext(director);

            coordinador.validaImporte(dImporte, cConcepto);

        }





    }
}
