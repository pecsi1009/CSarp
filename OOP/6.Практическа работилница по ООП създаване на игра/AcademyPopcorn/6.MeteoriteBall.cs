/*
    6.Implement a MeteoriteBall. It should inherit the Ball class and should leave a trail of TrailObject
objects. Each trail objects should last for 3 "turns". Other than that, the Meteorite ball should behave the
same way as the normal ball. You must NOT edit any existing .cs file.
 */
using System.Collections.Generic;

namespace AcademyPopcorn
{
    public class MeteoriteBall : Ball
    {
        private char[,] trailObjectBody = new char[,] { { '+' } };
        private int trailObjectLifeTime;

        public MeteoriteBall(MatrixCoords topLeft, MatrixCoords speed, int trailObjectLifeTime)
            : base(topLeft, speed)
        {
            this.trailObjectLifeTime = trailObjectLifeTime;
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<TrailObject> tail = new List<TrailObject>();

            // add a new trail object at the current position
            TrailObject trailObject = new TrailObject(this.TopLeft, this.trailObjectBody, this.trailObjectLifeTime);
            tail.Add(trailObject);

            return tail;
        }
    }
}

