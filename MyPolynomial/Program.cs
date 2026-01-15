namespace Task3D;


class Program
{
    static void Main(string[] args)
    {
        double[] coefficients = {1,2,3,4};
        MyPolynomial polynomialOne = new MyPolynomial(coefficients);
        Console.WriteLine(polynomialOne.ToString());
        Console.WriteLine(polynomialOne.ToString());

        /*double evaluatedPolynomial = polynomialOne.Evaluate(4);
        Console.WriteLine(evaluatedPolynomial);*/

    }
}
class MyPolynomial
{
    public double[] Coeffs {get;set;}
    //public int arrayLength {get;set;}
    //public string[] ConvertedArray{get;set;}

    public MyPolynomial(double[] coeffs)
    {
        Coeffs = coeffs;
        //arrayLength = coeffs.Length;
        //ConvertedArray = new string[arrayLength];

    }

    public int GetDegree()
    {
        return Coeffs.Length - 1;
    }

    public bool CheckReverse(double[] coeffs)
    {
        if(coeffs[0] < coeffs[coeffs.Length - 1])
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public string[] ConvertArray()
    {
        string[] ConvertedArray = new string[Coeffs.Length];
        if (!CheckReverse(Coeffs))
        {
            Array.Reverse(Coeffs);
        }

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

    /*public double Evaluate(double x)
    {
        double valueOfPolynomial = 0;
        double currentTerm = 0;
        for(int i = 0; i < arrayLength; i++)
        {
            if(i == 0)
            {
              valueOfPolynomial += Coeffs[i];  
            }
            else
            {
                currentTerm = Math.Pow(x,i) * Coeffs[i];
                valueOfPolynomial += currentTerm;
            }
        }

        return valueOfPolynomial;
    }*/
}