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

        double[] coefficients2 = {1,2,3,4,5,6};
        MyPolynomial another = new MyPolynomial(coefficients2);
        
        MyPolynomial trial = polynomialOne.Add(another);
        Console.WriteLine(trial.ToString());

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

    public MyPolynomial Add(MyPolynomial another)
    {
        int lengthOriginal = Coeffs.Length;
        int lengthNew = another.Coeffs.Length;
        int greaterLength = Math.Max(lengthOriginal, lengthNew);

        double[] addedPolynomials = new double[greaterLength];

        double[] longArray;
        double[] shorterArray;

        if(lengthOriginal >= lengthNew)
        {
            longArray = Coeffs;
            shorterArray = another.Coeffs;
        }
        else
        {
            shorterArray = Coeffs;
            longArray = another.Coeffs;  
        }

        for(int i = 0; i < longArray.Length; i++)
        {
            addedPolynomials[i] = longArray[i];
        }

        int indexOffset = longArray.Length - shorterArray.Length;
        for(int i = indexOffset; i < longArray.Length; i++)
        {
            addedPolynomials[i] += shorterArray[i - indexOffset];
        }

        MyPolynomial afterAdding = new MyPolynomial(addedPolynomials);
        return afterAdding;
    }
}