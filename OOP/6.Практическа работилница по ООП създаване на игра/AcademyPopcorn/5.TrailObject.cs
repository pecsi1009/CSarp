﻿/*
    5.Implement a TrailObject class. It should inherit the GameObject class and should have a constructor
which takes an additional "lifetime" integer. The TrailObject should disappear after a "lifetime" amount of
turns. You must NOT edit any existing .cs file. Then test the TrailObject by adding an instance of it in the
engine through the AcademyPopcornMain.cs file.
 */
namespace AcademyPopcorn
{
    public class TrailObject : GameObject
    {
        private int lifeTime;

        public TrailObject(MatrixCoords topLeft, char[,] body, int lifeTime)
            : base(topLeft, body)
        {
            this.lifeTime = lifeTime;
        }

        public override void Update()
        {
            if (lifeTime > 0)
            {
                lifeTime--;
            }
            else
            {
                this.IsDestroyed = true;
            }
        }
    }
}
