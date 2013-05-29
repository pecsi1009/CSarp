/*
    1.The AcademyPopcorn class contains an IndestructibleBlock class. Use it to create side and ceiling walls
to the game. You can ONLY edit the AcademyPopcornMain.cs file.
    5.Implement a TrailObject class. It should inherit the GameObject class and should have a constructor
 which takes an additional "lifetime" integer. The TrailObject should disappear after a "lifetime" amount of
 turns. You must NOT edit any existing .cs file. Then test the TrailObject by adding an instance of it in the
 engine through the AcademyPopcornMain.cs file.
    6.Implement a MeteoriteBall. It should inherit the Ball class and should leave a trail of TrailObject
objects. Each trail objects should last for 3 "turns". Other than that, the Meteorite ball should behave the
same way as the normal ball. You must NOT edit any existing .cs file.
    7.Test the MeteoriteBall by replacing the normal ball in the AcademyPopcornMain.cs file.
    9.Test the UnpassableBlock and the UnstoppableBall by adding them to the engine in AcademyPopcornMain.cs 
file.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class AcademyPopcornMain
    {
        const int WorldRows = 23;
        const int WorldCols = 40;
        const int RacketLength = 6;


        static void Initialize(Engine engine)
        {
            int startRow = 3;
            int startCol = 2;
            int endCol = WorldCols - 2;

            for (int i = startCol; i < endCol; i++)
            {
                Block currBlock = new Block(new MatrixCoords(startRow, i));
                // <Task 1>

                IndestructibleBlock ceilingBlock = new IndestructibleBlock(new MatrixCoords(startRow - 1, i));
                IndestructibleBlock leftSideBlock = new IndestructibleBlock(new MatrixCoords(i, startCol - 1));
                IndestructibleBlock rightSideBlock = new IndestructibleBlock(new MatrixCoords(i, endCol));

                engine.AddObject(ceilingBlock);
                engine.AddObject(leftSideBlock);
                engine.AddObject(rightSideBlock);
                engine.AddObject(currBlock);

            }
            //<Task 5>
            TrailObject trailBlock = new TrailObject(new MatrixCoords(WorldRows / 2, WorldCols / 2), new char[,] { { '&' } }, 30);

            engine.AddObject(trailBlock);

            /* <Task 6>
            MeteoriteBall mBall = new MeteoriteBall(new MatrixCoords(10, 10), new MatrixCoords(1, 1), 3);
            engine.AddObject(mBall);

            <Task9> Test UnstoppableBall
            Ball theUnstopableBall = new UnstoppableBall(new MatrixCoords(WorldRows / 2, 0), new MatrixCoords(-1, 1));
            engine.AddObject(theUnstopableBall);

            for (int i = 2; i < WorldCols/2; i+=4)
            {
                engine.AddObject(new UnpassableBlock(new MatrixCoords(4, i)));
            }
             */

            Ball theBall = new Ball(new MatrixCoords(WorldRows / 2, 0),
                new MatrixCoords(-1, 1));

            engine.AddObject(theBall);

            Racket theRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);

            engine.AddObject(theRacket);
        }

        static void Main()
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();

            Engine gameEngine = new Engine(renderer, keyboard, 200);

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };

            Initialize(gameEngine);
            gameEngine.Run();
        }
    }
}
