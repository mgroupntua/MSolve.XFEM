using MGroup.LinearAlgebra.Vectors;

namespace MGroup.XFEM.Utilities
{
    /// <summary>
    /// Data transfer object to store and pass around the value and derivatives of a 2D function, evaluated at some 
    /// It mainly serves to avoid obscure Tuple<double, Tuple<double, double>> objects.
    /// </summary>
    public class EvaluatedFunction2D
    {
        public EvaluatedFunction2D(double value, Vector2 cartesianDerivatives)
        {
            this.Value = value;
            this.CartesianDerivatives = cartesianDerivatives;
        }

        public double Value { get; }
        public Vector2 CartesianDerivatives { get; }
    }
}
