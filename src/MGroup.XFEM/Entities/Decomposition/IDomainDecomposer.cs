namespace MGroup.XFEM.Entities.Decomposition
{
    interface IDomainDecomposer
    {
        XCluster2D CreateSubdomains();
        void UpdateSubdomains(XCluster2D cluster);
    }
}
