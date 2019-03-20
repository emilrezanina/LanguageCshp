using System;
using System.Windows.Forms;

namespace Excersise04Game.GameItemGenerator
{
    public class LetterGenerator : IGameItemGenerator
    {
        private Random random = new Random(DateTime.Now.Millisecond);

        public object Next()
        {
            return (Keys)random.Next(65, 91);
        }
    }
}
