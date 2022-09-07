namespace AreaComputer.Test
{
    [TestClass]
    public class ChunkTests
    {
        [TestMethod]
        public void Area_x0Is0xIs3dxIs0001F1Is4F2is2_DifferenceWithFormulaCountIsLessThanDx()
        {
            //arrange
            double x0 = 0;
            double x = 3;
            double dx = 0.001;
            double expectedArea = 6;
            Func<double, double> F1 = (x) => { return 4; };
            Func<double, double> F2 = (x) => { return 2; };
            
            bool expected = true;
            Chunk chunk;
            
            //act
            chunk = new Chunk(x0, x, dx, F1, F2);
            
            //assert
            Assert.AreEqual(expected, Math.Abs(chunk.Area - expectedArea) < dx);
            
        }
    }
}