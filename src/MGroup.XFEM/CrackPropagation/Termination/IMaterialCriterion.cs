namespace MGroup.XFEM.CrackPropagation.Termination
{
    interface IMaterialCriterion
    {
        bool Terminate(double sifMode1, double sifMode2);
    }
}
