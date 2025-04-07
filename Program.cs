using System;
using System.Collections.Generic;

namespace GuiaEjercicios
{
    // 1 y 2. Vehículo y Autobús
    class Vehiculo
    {
        public string Marca;
        public string Modelo;

        public void Arrancar() => Console.WriteLine("Vehículo arrancando...");
        public void Detener() => Console.WriteLine("Vehículo detenido.");
    }

    class Autobus : Vehiculo
    {
        public int CapacidadPasajeros;
        public int NumeroPuertas;

        public void CargarPasajeros() => Console.WriteLine("Cargando pasajeros...");
        public void DescargarPasajeros() => Console.WriteLine("Descargando pasajeros...");
    }

    class Auto : Vehiculo { }
    class Moto : Vehiculo { }
    class Camion : Vehiculo { }

    // 3. Animal y dos clases hijas
    class Animal
    {
        public string Especie;

        public void Alimentar() => Console.WriteLine("El animal se está alimentando.");
        public void HacerSonido() => Console.WriteLine("Sonido del animal...");
    }

    class Perro : Animal
    {
        public void Ladrar() => Console.WriteLine("Guau Guau!");
    }

    class Gato : Animal
    {
        public void Maullar() => Console.WriteLine("Miau Miau!");
    }

    // 4. Libro
    class Libro
    {
        public string Titulo;
        public string Autor;

        public void Abrir() => Console.WriteLine("Libro abierto.");
        public void Leer() => Console.WriteLine("Leyendo el libro...");
        public void Cerrar() => Console.WriteLine("Libro cerrado.");
    }

    // 5. Biblioteca
    class Biblioteca
    {
        public string Nombre;
        List<Libro> libros = new List<Libro>();

        public void AgregarLibro(Libro libro)
        {
            libros.Add(libro);
            Console.WriteLine("Libro agregado a la biblioteca.");
        }

        public void BuscarLibro(string titulo)
        {
            foreach (var libro in libros)
            {
                if (libro.Titulo == titulo)
                    Console.WriteLine("Libro encontrado: " + libro.Titulo);
            }
        }
    }

    // 6. Cajero automático
    class CajeroAutomatico
    {
        public double Saldo;

        public void Retirar(double monto)
        {
            if (Saldo >= monto)
            {
                Saldo -= monto;
                Console.WriteLine("Retiro exitoso.");
            }
            else
                Console.WriteLine("Saldo insuficiente.");
        }

        public void Depositar(double monto)
        {
            Saldo += monto;
            Console.WriteLine("Depósito exitoso.");
        }

        public void ConsultarSaldo() => Console.WriteLine("Saldo: $" + Saldo);
    }

    // 7. Empleado y gestión
    class Empleado
    {
        public string Nombre;
        public string Rol;
    }

    class Departamento
    {
        List<Empleado> empleados = new List<Empleado>();

        public void AgregarEmpleado(Empleado e)
        {
            empleados.Add(e);
            Console.WriteLine("Empleado agregado.");
        }

        public void MostrarEmpleados()
        {
            foreach (var e in empleados)
                Console.WriteLine(e.Nombre + " - " + e.Rol);
        }
    }

    // Clase principal para probar
    class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo Autobús
            Autobus bus = new Autobus();
            bus.Marca = "Mercedes";
            bus.CargarPasajeros();

            // Ejemplo Animal
            Perro perro = new Perro();
            perro.Ladrar();

            // Ejemplo Libro
            Libro libro = new Libro();
            libro.Titulo = "C# Básico";
            libro.Leer();

            // Ejemplo Cajero
            CajeroAutomatico cajero = new CajeroAutomatico();
            cajero.Depositar(1000);
            cajero.Retirar(200);
            cajero.ConsultarSaldo();

            // Ejemplo Empleados
            Empleado emp = new Empleado { Nombre = "Juan", Rol = "Programador" };
            Departamento depto = new Departamento();
            depto.AgregarEmpleado(emp);
            depto.MostrarEmpleados();
        }
    }
}
