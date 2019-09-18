using MGroup.FEM.Entities;
using MGroup.MSolve.Discretization.FreedomDegrees;

namespace MGroup.XFEM.Entities
{
    public class NodalLoad
    {
        public Node Node { get; }
        public StructuralDof DofType { get; }
        public double Value { get; }

        public NodalLoad(Node node, StructuralDof dofType, double value)
        {
            this.Node = node;
            this.DofType = dofType;
            this.Value = value;
        }
    }
}
