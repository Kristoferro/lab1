using Knapsack; 

namespace UnitTests
{
    
    [TestClass] 
    public class UnitTestProblem
    {
      
        [TestMethod] 
        public void TestAtLeastOneItem() //przynajmniej jeden przedmiot
        {
            var problem = new Problem(10, 1);
            var result = problem.Solve(10); 
            Assert.IsTrue(result.ItemIds.Count >= 1);
        }


        [TestMethod] 
        public void TestEmptySolution() //co jak jest pusto
        {
            var problem = new Problem(10, 1);
            var result = problem.Solve(0); 
            Assert.AreEqual(0, result.ItemIds.Count);
        }


        [TestMethod] 
        public void TestSpecificInstance()// czy dziala po prostu na jednym przypadku
        {
            var problem = new Problem(10, 1);
            var result = problem.Solve(50);
      
            Assert.IsTrue(result.TotalWeight <= 50);
        }

      
        [TestMethod] 
        public void TestItemCount() //czy jest tyle przedmiotów ile powinno
        {
            int n = 15;
            var problem = new Problem(n, 1);
            Assert.AreEqual(n, problem.Items.Count);
        }

      
        [TestMethod] 
        public void TestSeedDeterminism() // czy seed daje to samo
        {
            var p1 = new Problem(5, 123);
            var p2 = new Problem(5, 123);
            Assert.AreEqual(p1.Items[0].Value, p2.Items[0].Value);
        }
    }
}