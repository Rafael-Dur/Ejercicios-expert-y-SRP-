using System;

namespace Expert_SRP
{
    public class Alfajor 
    {
        Alfajor  a=new Alfajor(12,4);
        Alfajor  b=new Alfajor(15,40);
    
        public Alfajor(double precioMasa, double precioDulce)
        {
            this.PrecioDulce = precioDulce;
            this.PrecioMasa = precioMasa;
            
        }
        public Double PrecioDulce {get;set;}
        public Double PrecioMasa {get; set;}

        	public Double PrecioFinal()
            {
                return PrecioDulce+PrecioMasa;
            }
    }
}