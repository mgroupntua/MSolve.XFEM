using System.Collections.Generic;
using MGroup.MSolve.Discretization.Interfaces;
using MGroup.MSolve.Discretization.Mesh;
using MGroup.XFEM.Entities;

namespace MGroup.XFEM.Elements
{
    public interface IXFiniteElement : IElement, IElementType, ICell<XNode>
    {
        IReadOnlyList<XNode> Nodes { get; }
        XSubdomain Subdomain { get; set; }
    }
}