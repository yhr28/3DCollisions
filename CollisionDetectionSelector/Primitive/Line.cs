﻿using System;
using OpenTK.Graphics.OpenGL;
using Math_Implementation;

namespace CollisionDetectionSelector.Primitive {
    class Line {
        public Point Start;
        public Point End;
        public float Length {
            get {
                return (float)Math.Sqrt(Vector3.Dot(new Vector3(Start.X, Start.Y, Start.Z), new Vector3(End.X, End.Y, End.Z)));
            }
        }
        public float LengthSq {
            get {
                return Vector3.Dot(new Vector3(Start.X, Start.Y, Start.Z), new Vector3(End.X, End.Y, End.Z));
            }
        }
        public Line(Line copy) {
            Start = copy.Start;
            End = copy.End;
        }
        public Line(Point p1, Point p2) {
            Start = new Point(p1);
            End = new Point(p2);
        }
        public Vector3 ToVector() {
            return new Vector3(End.X - Start.X, End.Y - Start.Y, End.Z - Start.Z);
        }
        public void Render() {
            GL.Begin(PrimitiveType.Lines);
            GL.Vertex3(Start.X, Start.Y, Start.Z);
            GL.Vertex3(End.X, End.Y, End.Z);
            GL.End();
        }
        public override string ToString() {
            string result = "Start: (" + Start.X + ", " + Start.Y + ", " + Start.Z + "), ";
            result += "End: ( " + End.X + ", " + End.Y + ", " + End.Z + ")";
            return result;
        }
    }
}