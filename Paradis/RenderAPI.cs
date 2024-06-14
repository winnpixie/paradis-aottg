
namespace Paradis
{
    internal class RenderApi
    {
        public static readonly RenderApi D3D9 = new RenderApi("Direct3D 9", "-force-d3d9");
        public static readonly RenderApi D3D11 = new RenderApi("Direct3D 11", "-force-d3d11");
        public static readonly RenderApi OpenGL = new RenderApi("OpenGL", "-force-opengl");

        public readonly string Name;
        public readonly string Command;

        public RenderApi(string name, string command)
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
