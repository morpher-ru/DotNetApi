namespace Morpher.WebService.V3
{
    public class Client
        : Russian.IDeclension
        , Ukrainian.IDeclension
        , Russian.INumberSpelling
        , Ukrainian.INumberSpelling
    {
        public Russian.IParse Parse(string s, Russian.ParseArgs args = null)
        {
            throw new System.NotImplementedException();
        }

        public Ukrainian.IParse Parse(string s, Ukrainian.ParseArgs args = null)
        {
            throw new System.NotImplementedException();
        }

        public string Spell(decimal n, ref string unit, ICase<Russian.IParadigm> @case)
        {
            throw new System.NotImplementedException();
        }

        public string Spell(decimal n, ref string unit, ICase<Ukrainian.IParadigm> @case)
        {
            throw new System.NotImplementedException();
        }
    }
}
