using System.Drawing;

namespace Template
{
    class MyApplication
    {
        // member variables
        public Surface screen;

        // constructor
        public MyApplication(Surface screen)
        {
            this.screen = screen;
        }

        // initialize
        public void Init()
        {
            // No additional initialization needed
        }

        // tick: renders one frame
        public void Tick()
        {
            // Clear the screen to black
            screen.Clear(0);

            // Print "hello world" in white at (2, 2)
            screen.Print("hello worlde", 2, 2, 0xffffff);

            // Draw a red line from (2, 20) to (160, 20)
            screen.Line(2, 20, 160, 20, 0xff0000);

            for (int a = 20, i=0; a<255 && i<40; a = a + 3, i++)
            {
                Color blueColor = Color.FromArgb(255, a, a, 0);
                screen.Line(2, 100 + i, 639, 100 + i, blueColor.ToArgb());
            }
            for (int a = 140, i = 0; a >0 && i < 40; a = a - 3, i++)
            {
                Color blueColor = Color.FromArgb(255, a, a, 0);
                screen.Line(2, 140 + i, 639, 140 + i, blueColor.ToArgb());
            }

            float x1 = -100, y1 = 50; 
            float x2 = 100, y2 = 50;
            float x3 = -100, y3 = -50;
            float x4 = 100, y4 = -50;

            for (float a=0; a<6.28; a += 0.1f)
            {
                float rx1 = (float)(x1 * Math.Cos(a) - y1 * Math.Sin(a));
                float ry1 = (float)(x1 * Math.Sin(a) + y1 * Math.Cos(a));
                float rx2 = (float)(x2 * Math.Cos(a) - y2 * Math.Sin(a));
                float ry2 = (float)(x2 * Math.Sin(a) + y2 * Math.Cos(a));
                float rx3 = (float)(x3 * Math.Cos(a) - y3 * Math.Sin(a));
                float ry3 = (float)(x3 * Math.Sin(a) + y3 * Math.Cos(a));
                float rx4 = (float)(x4 * Math.Cos(a) - y4 * Math.Sin(a));
                float ry4 = (float)(x4 * Math.Sin(a) + y4 * Math.Cos(a));
                screen.Line((int)rx1+320, (int)ry1+200, (int)rx2 + 320, (int)ry2 + 200, 0xffffff);
                screen.Line((int)rx1 + 320, (int)ry1 + 200, (int)rx3 + 320, (int)ry3 + 200, 0xffffff);
                screen.Line((int)rx3 + 320, (int)ry3 + 200, (int)rx4 + 320, (int)ry4 + 200, 0xffffff);
                screen.Line((int)rx2 + 320, (int)ry2 + 200, (int)rx4 + 320, (int)ry4 + 200, 0xffffff);
            }





        }
    }
}