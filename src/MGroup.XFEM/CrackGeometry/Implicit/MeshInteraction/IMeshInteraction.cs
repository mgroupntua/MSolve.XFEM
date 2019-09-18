using MGroup.XFEM.Elements;

namespace MGroup.XFEM.CrackGeometry.Implicit.MeshInteraction
{
    interface IMeshInteraction
    {
        CrackElementPosition FindRelativePositionOf(XContinuumElement2D element);
    }
}
