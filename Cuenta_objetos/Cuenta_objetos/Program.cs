using System;

namespace Cuenta_objetos
{
    class Cuenta_bancaria
    {
        private double numCuenta;
        private string nombre;
        private double saldo;
        private int tipoInteres;

        public Cuenta_bancaria()
        {
            this.numCuenta = 0;
            this.nombre = "";
            this.saldo = 0;
            this.tipoInteres = 0;
        }

        public double getNumCuenta()
        {
            return numCuenta;
        }
        public string getNombre()
        {
            return nombre;
        }
        public double getSaldo()
        {
            return saldo;
        }
        public double getTipoInteres()
        {
            return tipoInteres;
        }

        public void setNumCuenta(double num)
        {
            this.numCuenta = num;
        }
        
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void setSaldo(double saldo)
        {
            this.saldo = saldo;
        }
        public void setTipoInteres(int tipo)
        {
            this.tipoInteres = tipo;
        }

        public void estado()
        {
            Console.WriteLine("Numero de cuenta:" + getNumCuenta());
            Console.WriteLine("Nombre:" + getNombre());
            Console.WriteLine("Saldo:" + getSaldo());
            Console.WriteLine("Tipo de Interés:" + getTipoInteres() + "\n");
            
        }
        static void Main(string[] args)
        {
            Cuenta_bancaria micuenta = new Cuenta_bancaria();
            micuenta.setNumCuenta(3500);
            micuenta.setNombre("Caja Rural");
            micuenta.setSaldo(1000);
            micuenta.setTipoInteres(21);
            micuenta.estado();

            Cuenta_ahorro miahorro = new Cuenta_ahorro();
            miahorro.setNumCuenta(5000);
            miahorro.setNombre("Caixa");
            miahorro.setSaldo(3000);
            miahorro.setTipoInteres(12);
            miahorro.estado();

        }
    }
    class Cuenta_ahorro:Cuenta_bancaria
    {
        private int cuotaMantenimiento;

    }

    
}
