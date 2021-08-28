using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime naci = new DateTime(1997, 06, 12);
            DateTime entre = new DateTime(2005, 06, 30);
            Empleado nuevo = new Empleado("Matias","Martinez","jc 364",naci,entre);

            
        }
    }

    public class Empleado {
        private static float salarioBasico = 5000;
        private static float descuento = 0.15f;

        private string nombre;
        private string apellido;
        private string direccion;
        private DateTime fechaNacimiento;
        private int edad;
        private DateTime fechaIngreso;
        private int antiguedad;
        private float salario;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public int Antiguedad { get => antiguedad; set => antiguedad = value; }
        public int Edad { get => edad; set => edad = value; }
        public float Salario { get => salario; set => salario = value; }

        public Empleado(string _Nombre, string _Apellido, string _Direccion, DateTime _FechaNacimiento, DateTime _FechaIngreso)
        {
            nombre = _Nombre;
            apellido = _Apellido;
            direccion = _Direccion;
            fechaNacimiento = _FechaNacimiento;
            fechaIngreso = _FechaIngreso;
            antiguedad = CalcularAntiguedad();
            edad = CalcularEdad();
            salario = CalcularSalario();
        }

        private int CalcularAntiguedad(){return (DateTime.Now - this.fechaIngreso).Days / 365;}

        private int CalcularEdad() { return (DateTime.Now - this.fechaNacimiento).Days / 365; }

        private float CalcularSalario(){
            float adicional = 0;
            if (antiguedad < 20) 
            {
                adicional = salarioBasico * (antiguedad / 100f); 
            }
            else
            {
                adicional = salarioBasico * 0.25f;
            }
            float salario = (salarioBasico + adicional) - (salarioBasico * -descuento);
            return salario;
        }
    }
}
