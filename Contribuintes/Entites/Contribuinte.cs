namespace Contribuintes.Entites
{
    abstract class Contribuinte
    {
        public string Name { get; set; }
        public double RendaAnual { get; set; }

        protected Contribuinte(string name, double rendaAnual)
        {
            Name = name;
            RendaAnual = rendaAnual;
        }

        abstract public double Impostos();
    }
}