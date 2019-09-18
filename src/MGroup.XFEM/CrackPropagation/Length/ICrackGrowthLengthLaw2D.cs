namespace MGroup.XFEM.CrackPropagation.Length
{
    // TODO: Not sure what arguments must be used tbh. Using Paris's law for the increment needs the SIFs.
    public interface ICrackGrowthLengthLaw2D
    {
        /// <summary>
        /// Computes the length of the next crack growth increment.
        /// </summary>
        /// <param name="sif1">The stress intensity factor of crack mode I (opening mode)</param>
        /// <param name="sif2">The stress intensity factor of crack mode II (sliding mode)</param>
        /// <returns>A positive double value</returns>
        double ComputeGrowthLength(double sif1, double sif2);
    }
}
