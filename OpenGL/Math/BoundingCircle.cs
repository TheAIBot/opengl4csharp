using System;

#if USE_NUMERICS
using System.Numerics;
#endif

namespace OpenGL
{
    public readonly struct BoundingCircle
    {
        public readonly Vector3 Center;
        public readonly float Radius;

        public BoundingCircle(Vector3 center, float radius)
        {
            this.Center = center;
            this.Radius = radius;
        }

        public BoundingCircle AddBoundingCircle(BoundingCircle circleBox)
        {
            return new BoundingCircle(Center, MathF.Max(Radius, Vector3.Distance(Center, circleBox.Center) + circleBox.Radius - Radius));
        }
    }
}