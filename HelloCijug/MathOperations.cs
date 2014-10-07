namespace HelloCijug
{
    using System.Collections.Generic;
    using System.Linq;

    public class MathOperations
    {
        public MathOperations(List<IMathOperator> samples)
        {
            Samples = samples;
        }

        private List<IMathOperator> Samples { get; set; }

        public IEnumerable<int> PerformAll(int firstValue, int secondValue)
        {
            return Samples.Select(mathOperator => mathOperator.PerformOperation(firstValue, secondValue)).ToList();
        }
    }
}