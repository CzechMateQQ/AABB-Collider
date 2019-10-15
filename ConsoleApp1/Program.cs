using Raylib;
using rl = Raylib.Raylib;

namespace ConsoleApp1
{
    static class Program
    {
        public static int Main()
        {
            // Initialization
            //--------------------------------------------------------------------------------------
            int screenWidth = 800;
            int screenHeight = 450;

            rl.InitWindow(screenWidth, screenHeight, "raylib [core] example - basic window");

            rl.SetTargetFPS(60);
            //--------------------------------------------------------------------------------------
            MyShape triangle = new MyShape();
            triangle.MyPoints.Add(new Vector2(10, 10));
            triangle.MyPoints.Add(new Vector2(20, 30));
            triangle.MyPoints.Add(new Vector2(30, 10));
            triangle.MyPoints.Add(new Vector2(10, 10));
            triangle.MyPoints.Add(new Vector2(40, 30));
            triangle.MyPoints.Add(new Vector2(50, 10));
            triangle.position = new Vector2(100, 100);

            // Main game loop
            while (!rl.WindowShouldClose())    // Detect window close button or ESC key
            {
                // Update
                //----------------------------------------------------------------------------------
                // TODO: Update your variables here
                //----------------------------------------------------------------------------------

                // Draw
                //----------------------------------------------------------------------------------
                rl.BeginDrawing();

                rl.ClearBackground(Color.RAYWHITE);

                rl.DrawText("Congrats! You created your first window!", 190, 200, 20, Color.LIGHTGRAY);
                triangle.Draw();
                triangle.position.x += .2f;
                rl.EndDrawing();
                //----------------------------------------------------------------------------------
            }

            // De-Initialization
            //--------------------------------------------------------------------------------------
            rl.CloseWindow();        // Close window and OpenGL context
                                     //--------------------------------------------------------------------------------------

            return 0;
        }
    }
}
