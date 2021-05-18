namespace Contribuintes.Entites
{
    class PessoaFisica :Contribuinte
    {
        public double Saude { get; set; }
        public PessoaFisica(string name, double rendaAnual, double saude)
            :base(name,rendaAnual)
        {
            Saude = saude;
        }

        public sealed override double Impostos()
        {

            if (RendaAnual < 20000.00)
            {
                return (0.15 * RendaAnual) - (0.50 * Saude);
            }
            else
            {
                return (0.25 * RendaAnual) - (0.50 * Saude);
            }
        }
    }
}
