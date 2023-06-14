using System;


namespace R5T.S0076
{
    public class CodeSyntaxGenerationScripts : ICodeSyntaxGenerationScripts
    {
        #region Infrastructure

        public static ICodeSyntaxGenerationScripts Instance { get; } = new CodeSyntaxGenerationScripts();


        private CodeSyntaxGenerationScripts()
        {
        }

        #endregion
    }
}
