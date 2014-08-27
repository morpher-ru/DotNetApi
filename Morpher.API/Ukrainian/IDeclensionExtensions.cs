namespace Morpher.Ukrainian
{
    public static class IDeclensionExtensions
    {
        public static IParse Parse (this IDeclension declension, string s, Gender gender)
        {
            return declension.Parse (s, new ParseArgs {Gender = gender});
        }
    }
}