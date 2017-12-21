namespace Morpher.WebService.V3
{
    public class Client
        : Morpher.Russian.IDeclension
        , Morpher.Ukrainian.IDeclension
        , Morpher.Russian.INumberSpelling
        , Morpher.Ukrainian.INumberSpelling
    {
        private readonly MorpherClient _morpherClient;

        public Client()
        {
            _morpherClient = new MorpherClient();
        }

        Morpher.Russian.IParse Morpher.Russian.IDeclension.Parse(
            string s,
            Morpher.Russian.ParseArgs args)
            => new Russian.Parse(_morpherClient.Russian.Parse(s));

        Morpher.Ukrainian.IParse Morpher.Ukrainian.IDeclension.Parse(
            string s,
            Morpher.Ukrainian.ParseArgs args) 
            => new Ukrainian.Parse(_morpherClient.Ukrainian.Parse(s));

        string Morpher.Russian.INumberSpelling.Spell(
            decimal n,
            ref string unit,
            ICase<Morpher.Russian.IParadigm> @case)
        {
            var result = _morpherClient.Russian.Spell(n, unit);
            unit = new Russian.UnitParadigm(result.UnitDeclension).Get(@case);
            return new Russian.UnitParadigm(result.NumberDeclension).Get(@case);
        }

        string Morpher.Ukrainian.INumberSpelling.Spell(
            decimal n,
            ref string unit,
            ICase<Morpher.Ukrainian.IParadigm> @case)
        {
            var result = _morpherClient.Ukrainian.Spell(n, unit);
            unit = new Ukrainian.Paradigm(result.UnitDeclension).Get(@case);
            return new Ukrainian.Paradigm(result.NumberDeclension).Get(@case);
        }
    }
}
