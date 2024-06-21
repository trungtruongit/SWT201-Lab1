using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EquationSolver.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1_A0B0C0_Infinity()
        {
            var equation = new Equation();
            var result = equation.Solve(0, 0, 0);
            Assert.AreEqual(EquationResultEnum.Infinity, result.EquationResultType);
        }

        [TestMethod]
        public void Test2_A0B0CNot0_NoSolution()
        {
            var equation = new Equation();
            var result = equation.Solve(0, 0, 1);
            Assert.AreEqual(EquationResultEnum.NoSolution, result.EquationResultType);
        }

        [TestMethod]
        public void Test3_A0BNot0_OneSolutionLinear()
        {
            var equation = new Equation();
            var result = equation.Solve(0, 2, -4);
            Assert.AreEqual(EquationResultEnum.OneSolution, result.EquationResultType);
            Assert.AreEqual(2, result.X1, 1e-6);
        }

        [TestMethod]
        public void Test4_ANot0DeltaSmaller0_NoSolution()
        {
            var equation = new Equation();
            var result = equation.Solve(1, 0, 1);
            Assert.AreEqual(EquationResultEnum.NoSolution, result.EquationResultType);
        }

        [TestMethod]
        public void Test5_ANot0DeltaEqual0_OneSolutionQuadratic()
        {
            var equation = new Equation();
            var result = equation.Solve(1, -2, 1);
            Assert.AreEqual(EquationResultEnum.OneSolution, result.EquationResultType);
            Assert.AreEqual(1, result.X1, 1e-6);
        }

        [TestMethod]
        public void Test6_ANot0DeltaLarger0_TwoSolutions()
        {
            var equation = new Equation();
            var result = equation.Solve(1, -3, 2);
            Assert.AreEqual(EquationResultEnum.TwoSolutions, result.EquationResultType);
            Assert.AreEqual(2, result.X1, 1e-6);
            Assert.AreEqual(1, result.X2, 1e-6);
        }
    }
}
