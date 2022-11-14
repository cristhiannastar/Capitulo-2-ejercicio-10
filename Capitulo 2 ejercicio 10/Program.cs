namespace ejercicio10
{

    public class program
    {

        public static void Main()
        {
            double pulg = 0;
            double MT = 0.0254;
            double Cpulg = 0;
            double MeDados = 0;

            Console.WriteLine("digite la cantidad de metros necesarios de la tela:");
            MeDados = double.Parse(Console.ReadLine());
            Cpulg = MeDados / MT;

            Console.WriteLine($"la cantidad de pulgadas de la tela que debe pedir es :{pulg}");




        }
    }
}