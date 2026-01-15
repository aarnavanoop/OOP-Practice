namespace Task3D;


class Program
{
    static void Main(string[] args)
    {
        double[] coefficients = {1,2,3,4};
        MyPolynomial polynomialOne = new MyPolynomial(coefficients);
        string[] convertedpolynomial = polynomialOne.ConvertArray(polynomialOne.Coeffs);
        Console.WriteLine(polynomialOne.ToString());

    }
}
class MyPolynomial
{
    public double[] Coeffs {get;set;}
    public int arrayLength {get;set;}

    public string[] ConvertedArray{get;set;}

    public MyPolynomial(double[] coeffs)
    {
        Coeffs = coeffs;
        arrayLength = coeffs.Length;
        ConvertedArray = new string[arrayLength];

    }

    public int GetDegree()
    {
        return arrayLength - 1;
    }

    public string[] ConvertArray(double[] coeffs)
    {
        //string[] ConvertedArray = new string[arrayLength];
        if(coeffs[0] < coeffs[arrayLength -1])
        {
            Array.Reverse(coeffs);
        }

        for(int i = 0; i < arrayLength; i++)
        {
            string stringVersion = Coeffs[i].ToString();
            ConvertedArray[i] = stringVersion + $"x^{arrayLength - 1 - i}";
        }

        return ConvertedArray;
    }
   public override string ToString()
    {
        return String.Join(" + ", ConvertedArray);
    }
    

}