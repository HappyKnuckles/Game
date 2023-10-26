using System.Numerics;

using Raylib_cs;  // BvRL: Fixed!

using static Raylib_cs.Raylib;

namespace Examples.Core;

public class Program
{
    // Constants:

    const int screenWidth = 800;
    const int screenHeight = 450;

    public static void Main()
    {
        // Initialization:

        InitWindow(screenWidth, screenHeight, "raylib [core] example - keyboard input [WASD version]");

        Vector2 ballPosition = new(screenWidth / 2.0f, screenHeight / 2.0f);

        SetTargetFPS(60);

        // Main game loop:

        while (!WindowShouldClose())
        {
            // Update:

            if (IsKeyDown(KeyboardKey.KEY_D))
            {
                ballPosition.X += 2.0f;
            }

            if (IsKeyDown(KeyboardKey.KEY_A))
            {
                ballPosition.X -= 2.0f;
            }

            if (IsKeyDown(KeyboardKey.KEY_W))
            {
                ballPosition.Y -= 2.0f;
            }

            if (IsKeyDown(KeyboardKey.KEY_S))
            {
                ballPosition.Y += 2.0f;
            }

            // Draw:

            BeginDrawing();

            ClearBackground(Color.RAYWHITE);

            DrawText("Move the ball with WASD keys", 10, 10, 20, Color.DARKGRAY);

            DrawCircleV(ballPosition, 50, Color.MAROON);

            EndDrawing();
        }

        // De-Initialization:

        CloseWindow();
    }
}