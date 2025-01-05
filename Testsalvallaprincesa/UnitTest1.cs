namespace ArmesEnBatalla.Tests
{
    public class SalvarPrincesaTests
    {
        [Theory]
        [InlineData(new string[] { }, new int[] { 0, 0, 0 })]
        [InlineData(new string[] { "Llança", "Casc", "Espasa", "Escut", "Armadura" }, new int[] { 0, 0, 1 })]
        [InlineData(new string[] { "Llança", "Llança", "Casc", "Casc" }, new int[] { 2, 0, 0 })]
        public void TestCalcularResultatsLimits(string[] armes, int[] expectedResults)
        {
            var nw = new SalvarPrincesa();
            int[] result = nw.CalcularResultats(armes);
            Assert.Equal(expectedResults, result);
        }
    }
}