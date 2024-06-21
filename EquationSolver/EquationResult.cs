using System;

namespace EquationSolver
{
    public class EquationResult
    {
        public EquationResultEnum EquationResultType { get; set; }
        private double x1, x2;
        public double X1
        {
            get
            {
                if (EquationResultType == EquationResultEnum.Infinity
                    || EquationResultType == EquationResultEnum.NoSolution)
                {
                    throw new Exception("Invalid Value");
                }
                return x1;

            }
            set
            {
                x1 = value;
            }
        }

        public double X2
        {
            get
            {
                if (EquationResultType == EquationResultEnum.Infinity
                    || EquationResultType == EquationResultEnum.NoSolution)
                {
                    throw new Exception("Invalid Value");
                }
                return x2;

            }
            set
            {
                x2 = value;
            }
        }
    }

    public enum EquationResultEnum
    {
        NoSolution,
        OneSolution,
        TwoSolutions,
        Infinity
    }
}
