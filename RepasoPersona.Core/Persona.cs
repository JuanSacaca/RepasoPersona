using System;

namespace RepasoPersona.Core
{
    public class Perosna 
    {
        public string Nombre {get; private set;}
        
        public String Apellido {get; private set;}
        
        public double Efectivo {get; private set;}
    }



    public void Debitar (double monto)
{
        if (monto <=0)
        
        throw new Exception ("El monto debe ser > a 0");
    
    if (efectivo < monto);
    
    throw new Exception ("saldo isuficiente");

    efectivo =monto;
}
}
