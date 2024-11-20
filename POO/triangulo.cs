using System.Globalization;

class Triangulo
{
    public double A, B, C;
    public string name = "";
    public double area = 0;

    public Triangulo(string name){
        this.name = name;
    }

    public double calculaArea()
        {
            Console.WriteLine($"Entre com as medidas do triangulo {this.name}: ");
            A = double.Parse (Console.ReadLine (), CultureInfo.InvariantCulture);
            B = double.Parse (Console.ReadLine (), CultureInfo.InvariantCulture);
            C = double.Parse (Console.ReadLine (), CultureInfo.InvariantCulture);

            double p = (A + B + C) / 2.0;
            area = Math.Sqrt (p * (p - A) * (p - B) * (p - C));

            Console.WriteLine($"Área do triangulo{this.name} = {area.ToString("F4", CultureInfo.InvariantCulture)}");

            return area;
        }

        public string comparaArea(Triangulo triangulo1, Triangulo triangulo2){
            if (triangulo1.area > triangulo2.area)
        {
            string result = "O maior triangulo é o triangulo X";
            Console.WriteLine(result);
            return result;
        }else {
            string result = "O maior triangulo é o triangulo Y";
            Console.WriteLine(result);
            return result;
        }
    }
}

