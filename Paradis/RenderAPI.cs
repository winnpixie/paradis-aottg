
namespace Paradis
{
    internal class RenderAPI
    {
        public readonly string Name;
        public readonly string Command;

        public RenderAPI(string name, string command)
        {
            this.Name = name;
            this.Command = command;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
