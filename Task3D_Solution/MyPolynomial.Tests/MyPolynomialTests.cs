using Xunit;
using Task3D; // This must match the "namespace" line in your main Program.cs!

namespace Task3D.Tests
{
    public class MyPolynomialTests
    {
        [Fact]
        public void Evaluate_CalculatesCorrectValue()
        {

            double[] coeffs = { 1, 2, 3, 4 }; 
            MyPolynomial poly = new MyPolynomial(coeffs);
            

            double inputX = 2;
            double expected = 26;


            double actual = poly.Evaluate(inputX);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Add_SumsPolynomialsOfDifferentLengths()
        {

            var p1 = new MyPolynomial(new double[] { 1, 1 });
            var p2 = new MyPolynomial(new double[] { 2, 0, 0 });


            MyPolynomial result = p1.Add(p2);


            Assert.Equal(3, result.Coeffs.Length);
            Assert.Equal(2, result.Coeffs[0]);     
            Assert.Equal(1, result.Coeffs[1]);     
            Assert.Equal(1, result.Coeffs[2]);     
        }
    }
}