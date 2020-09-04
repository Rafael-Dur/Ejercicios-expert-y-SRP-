using System;

namespace Expert_SRP
{
    public class Kiosco 
    {
        public Boolean PuedeComprar(Alfajor a, Double dinero, String moneda) 
        {
            /*Este método debería ir en una clase que se dedique a administrar dinero, porque no cumple con el criterio SRP.
            El cálculo del precio del alfajor no cumple con el criterio expert, ya que sería la clase Alfajor la que debería encargarse de esta función */
            Double pesos = Dinero.ConvertirAPesos(dinero, moneda);
            //return pesos >= a.PrecioDulce + a.PrecioMasa;//
            return pesos >=a.PrecioFinal();
        }
        
    }
}