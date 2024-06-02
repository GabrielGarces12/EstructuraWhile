

namespace EstructuraWhile.Class
{
    internal class Calcular
    {
        public void SumaPromedioValores() 
        {
            int contador = 0;
            double suma = 0;
            int totalValores = 10;
           
            while (contador < totalValores) 
            {
                    Console.WriteLine("Digite el numero: ");

                 try
                 {
                   int valor = Convert.ToInt32(Console.ReadLine());
                  
                   suma += valor;
                     
                 }
                 catch (Exception excep)
                 {

                    Console.WriteLine($"Hubo un error: { excep.Message }");
                 }
                
                contador++;
              
            }
            double promedio = suma / totalValores;

            Console.WriteLine($"La suma de los valores es: { suma }");
            Console.WriteLine($"El promedio de la suma de los valores es: { promedio }");
        }
        public void PlantaDePiezas() 
        {
            int piezasAptas = 0;

            int contador = 0;

            Console.WriteLine("Ingrese la cantidad de piezas a procesar: ");
            try
            {
                int cantidadPiezas = Convert.ToInt32(Console.ReadLine());

                while (contador < cantidadPiezas) 
                {
                    contador++;

                    Console.WriteLine("Ingrese la longitud de la pieza: ");

                    double longitud = Convert.ToDouble(Console.ReadLine());

                    if (longitud >= 1.20 && longitud <= 1.30) 
                    {
                        piezasAptas++;
                    }   
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio un error. { ex.Message}");
            }

            Console.WriteLine($"La cantidad de piezas aptas: {piezasAptas}");
        }

        public void NotasAlumnos() 
        {

            int cantidadNotas = 10;
            int contador = 0;
            int notasMayoresDeSiete = 0;
            int notasMenoresDeSiete = 0;

            try
            {
                while (contador < cantidadNotas) 
                {

                  Console.WriteLine("Ingrese la nota: ");

                  double notas = Convert.ToDouble(Console.ReadLine());

                    if(notas < 0) Console.WriteLine("Numero no valido. Solo se aceptan numeros mayores de cero");

                    if (notas >= 7)
                  {
                    notasMayoresDeSiete++;
                  }
                  else if (notas < 7 && notas > 0)
                  {
                    notasMenoresDeSiete++;
                  }

                  contador++;

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hubo un error: { ex.Message }");
            }

            Console.WriteLine($"La cantidad de notas mayor o igual a siete: { notasMayoresDeSiete}");
            Console.WriteLine($"La cantidad de notas menores de siete: { notasMenoresDeSiete}");
            
        }

        public void SueldosEmpleados() 
        {
            int empleados = 7;
            int contador = 1;
            double sueldoMayorATrescientos = 0;
            double sueldoEntreCienYTrescientos = 0;
            int gastoPersonal = 0;

            try
            {
                while (contador <= empleados) 
                {
                  Console.WriteLine($"Digite el sueldo del empleado { contador}: ");
                  double sueldo = Convert.ToDouble(Console.ReadLine());

                  
                    if (sueldo >= 100 && sueldo <= 300) 
                    {
                        sueldoEntreCienYTrescientos++;
                    }
                    else if (sueldo > 300) 
                    {
                        sueldoMayorATrescientos++;
                    }

                    gastoPersonal += (int)sueldo;

                    contador++;

                }
            }
            catch (Exception exe)
            {

                Console.WriteLine($"Hubo un error: { exe.Message}");
            }
            Console.WriteLine($"\nEmpleados que cobran entre 100 y 300: { sueldoEntreCienYTrescientos}");
            Console.WriteLine($"Empleados que cobran mas de 300: { sueldoMayorATrescientos}");
            Console.WriteLine($"El gasto total de la empresa en sueldos: { gastoPersonal}");
        }
    }
}
