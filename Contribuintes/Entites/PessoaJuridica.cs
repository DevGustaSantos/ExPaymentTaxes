namespace Contribuintes.Entites
{
    class PessoaJuridica :Contribuinte
    {
        public int QtdFuncionarios { get; set; }

        public PessoaJuridica(string name, double rendaAnual, int qtdFuncionarios)
            :base(name,rendaAnual)
        {
            QtdFuncionarios = qtdFuncionarios;
        }

        public override double Impostos()
        {
            if (QtdFuncionarios > 10)
            {
                return RendaAnual * 0.14;                
            }
            else
            {
                return RendaAnual * 0.16;
            }
        }
    }
}
