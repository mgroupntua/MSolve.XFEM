using MGroup.MSolve.Geometry.Coordinates;
using MGroup.XFEM.CrackGeometry.CrackTip;

namespace MGroup.XFEM.CrackPropagation.Jintegral
{
    public interface IAuxiliaryStates
    {
        AuxiliaryStatesTensors ComputeTensorsAt(CartesianPoint globalIntegrationPoint, 
            TipCoordinateSystem tipCoordinateSystem);
    }
}
