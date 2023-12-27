using System;
using System.Security.Cryptography;

class DSAParametersGenerator
{
    static void Main()
    {
        using (var dsa = new DSACryptoServiceProvider())
        {
            // Генерація параметрів
            var parameters = dsa.ExportParameters(true);

            Console.WriteLine("Generated DSA parameters:");
            Console.WriteLine("p: " + Convert.ToBase64String(parameters.P));
            Console.WriteLine("q: " + Convert.ToBase64String(parameters.Q));
            Console.WriteLine("g: " + Convert.ToBase64String(parameters.G));
        }
    }
}