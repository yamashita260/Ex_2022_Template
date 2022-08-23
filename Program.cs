using InputUtilitys;
namespace Ex_2022_Template
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var width = InputUtility.InputFloat("幅を入力");
            var height = InputUtility.InputFloat("高さを入力");
            var depth = InputUtility.InputFloat("奥行を入力");
            Box box = new Box(width, height, depth);
            Console.WriteLine($"boxの表面積は{box.GetSurface()}、boxの体積は{box.GetVolume()}");

        }
        class Box
        {
            private float width;
            private float height;
            private float depth;
            public Box(float w, float h, float d)
            {
                this.width = w;
                this.height = h;
                this.depth = d;
            }
            public Box(float w = 1)
            {
                this.width = w;
                this.height = w;
                this.depth = w;
            }
            public float GetVolume()
            {
                return width * height * depth;
            }
            public float GetSurface()
            {
                return (width * height + height * depth + depth * width) * 2;
            }


        }
    }
}

