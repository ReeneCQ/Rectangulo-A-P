using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codigo_tecsup
{
    public class Rectangulo
    {
        // Definimos las propiedades para los vértices del rectangulo
        public double X1 { get; set; }
        public double Y1 { get; set; }
        public double X2 { get; set; }
        public double Y2 { get; set; }
        public double X3 { get; set; }
        public double Y3 { get; set; }
        public double X4 { get; set; }
        public double Y4 { get; set; }

        // Constructor que recibe las coordenadas de los vertices
        public Rectangulo(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
            X3 = x3;
            Y3 = y3;
            X4 = x4;
            Y4 = y4;
        }

        // Metodo para calcular el area del rectangulo
        public double CalcularArea()
        {
            // Calculamos la base y la altura del rectangulo
            double baseRectangulo = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
            double alturaRectangulo = Math.Sqrt(Math.Pow(X3 - X2, 2) + Math.Pow(Y3 - Y2, 2));

            // El area del rectangulo es la base por la altura
            double areaRectangulo = baseRectangulo * alturaRectangulo;
            return areaRectangulo;
        }

        // Metodo para calcular el perimetro del rectangulo
        public double CalcularPerimetro()
        {
            // Calculamos la distancia entre los vertices del rectangulo
            double lado1 = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
            double lado2 = Math.Sqrt(Math.Pow(X3 - X2, 2) + Math.Pow(Y3 - Y2, 2));

            // El perimetro es la suma de todos los lados
            double perimetroRectangulo = 2 * (lado1 + lado2);
            return perimetroRectangulo;
        }
    }
}
