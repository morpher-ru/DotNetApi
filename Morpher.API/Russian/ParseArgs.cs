namespace Morpher.Russian
{
    public class ParseArgs
    {
        public Category? Category {get; set;}

        /// <summary>
        /// Gender of the named person or enitity, if known.
        /// </summary>
        public Gender Gender {get; set;}

        /// <summary>
        /// Animacy of the named person or enitity, if known.
        /// </summary>
        public bool ? IsAnimate {get; set;}
    }
}