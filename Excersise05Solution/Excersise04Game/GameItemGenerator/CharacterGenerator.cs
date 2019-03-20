using System;
using System.Windows.Forms;

namespace Excersise04Game.GameItemGenerator
{
    public class CharacterGenerator : IGameItemGenerator
    {
        private Random random = new Random(DateTime.Now.Millisecond);

        public object Next()
        {
            return random.Next(1, 3) == 1 ? (Keys)random.Next(48, 58) : (Keys)random.Next(65, 91);
        }
    }
}
