

using codigo_tecsup;

class Program
{
    static void Main(string[] args)
    {
        // Creamos un objeto Rectangulo con las coordenadas de sus vertices
        Rectangulo rectangulo = new Rectangulo(0, 0, 0, 3, 4, 3, 4, 0);

        //Podemos cambiar los datos de la coordenada
        rectangulo.X1 = 2;


        // Calculamos y mostramos el area y el perimetro del rectangulo
        // Para mostrar debemos usar el objeto.Metodo
        Console.WriteLine("Area del rectangulo: " + rectangulo.CalcularArea());
        Console.WriteLine("Perímetro del rectangulo: " + rectangulo.CalcularPerimetro());
        Console.WriteLine("Coordenada X4: " + rectangulo.X4);

    }
}