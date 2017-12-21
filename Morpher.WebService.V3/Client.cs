using System;

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
        {
            throw new NotImplementedException();
        }

        Morpher.Ukrainian.IParse Morpher.Ukrainian.IDeclension.Parse(
            string s,
            Morpher.Ukrainian.ParseArgs args)
        {
            throw new NotImplementedException();
        }

        string Morpher.Russian.INumberSpelling.Spell(
            decimal n,
            ref string unit,
            ICase<Morpher.Russian.IParadigm> @case)
        {
            throw new NotImplementedException();
        }

        string Morpher.Ukrainian.INumberSpelling.Spell(
            decimal n,
            ref string unit,
            ICase<Morpher.Ukrainian.IParadigm> @case)
        {
            throw new NotImplementedException();
        }
    }
}
