using MGroup.LinearAlgebra.Vectors;
using MGroup.XFEM.FreedomDegrees.Ordering;

namespace MGroup.XFEM.Output.VTK
{
    interface IXfemOutput
    {
        void WriteOutputData(IDofOrderer dofOrderer, Vector freeDisplacements, Vector constrainedDisplacements, int step);
    }
}
