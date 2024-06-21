using System;

namespace EquationSolver
{
    public class Equation
    {
        public EquationResult Solve(int a, int b, int c)
        {
            var result = new EquationResult();

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        result.EquationResultType = EquationResultEnum.Infinity;
                    }
                    else
                    {
                        result.EquationResultType = EquationResultEnum.NoSolution;
                    }
                }
                else
                {
                    result.EquationResultType = EquationResultEnum.OneSolution;
                    result.X1 = -1.0 * c / b;
                }
            }
            else
            {
                double delta = b * b - 4 * a * c;

                if (delta > 0)
                {
                    result.EquationResultType = EquationResultEnum.TwoSolutions;
                    result.X1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    result.X2 = (-b - Math.Sqrt(delta)) / (2 * a);
                }
                else if (delta == 0)
                {
                    result.EquationResultType = EquationResultEnum.OneSolution;
                    result.X1 = -b / (2 * a);
                }
                else
                {
                    result.EquationResultType = EquationResultEnum.NoSolution;
                }
            }

            return result;
        }
    }
}
