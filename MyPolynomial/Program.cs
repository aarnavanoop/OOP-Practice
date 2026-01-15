namespace Task3D;


class Program
{
    static void Main(string[] args)
    {
        double[] coefficients = {1,2,3,4};
        MyPolynomial polynomialOne = new MyPolynomial(coefficients);
        Console.WriteLine(polynomialOne.ToString());

        double evaluatedPolynomial = polynomialOne.Evaluate(4);
        Console.WriteLine(evaluatedPolynomial);

    }
}
class MyPolynomial
{
    public double[] Coeffs {get;set;}


    public MyPolynomial(double[] coeffs)
    {
        Coeffs = coeffs;
    }

    public int GetDegree()
    {
        return Coeffs.Length - 1;
    }

    public string[] ConvertArray()
    {
        string[] ConvertedArray = new string[Coeffs.Length];

        for(int i = 0; i < Coeffs.Length; i++)
        {
            string stringVersion = Coeffs[i].ToString();
            ConvertedArray[i] = stringVersion + $"x^{Coeffs.Length - 1 - i}";
        }

        return ConvertedArray;
    }
    public override string ToString()
    {
        return String.Join(" + ", ConvertArray());
    }

    public double Evaluate(double x)
    {
        double valueOfPolynomial = 0;
        for(int i = 0; i < Coeffs.Length; i++)
        {
            double c = Coeffs[i];
            int power = Coeffs.Length - 1 - i;

            valueOfPolynomial += c * Math.Pow(x,power);
        }

        return valueOfPolynomial;
    }

}