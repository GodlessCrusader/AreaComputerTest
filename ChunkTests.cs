namespace AreaComputer.Test
{
    [TestClass]
    public class ChunkTests
    {
        [TestMethod]
        public void Area_x0Is0xIs3dxIs0001F1Is4F2is2_Returned6()
        {
            //arrange
            double x0 = 0;
            double x = 3;
            double dx = 0.001;
            Func<double, double> F1 = (x) => { return 4; };
            Func<double, double> F2 = (x) => { return 2; };
            double expected = 6;
            Chunk chunk;
            
            //act
            chunk = new Chunk(x0, x, dx, F1, F2);
            
            //assert
           
            Assert.AreEqual(expected, chunk.Area);
            
        }
    }
}