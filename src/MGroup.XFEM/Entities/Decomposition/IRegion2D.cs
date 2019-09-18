

// TODO: Should this be here or in Geometry?
namespace MGroup.XFEM.Entities.Decomposition
{
    public enum NodePosition
    {
        Internal, Boundary, External
    }

    interface IRegion2D
    {
        NodePosition FindRelativePosition(XNode node);
    }
}
