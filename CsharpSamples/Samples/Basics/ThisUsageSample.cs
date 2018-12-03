using CsharpSamples.Common.Interfaces;
using System;

namespace CsharpSamples.Samples.Basics
{
    public class ThisUsageSample : ISample
    {
        public void Run()
        {
            var builder = new Builder();
            builder.Height(10).Width(5).Depth(66);
            builder.PrintDimensions();

            var anotherBuilder = new Builder();
            anotherBuilder.Height(10).Depth(5);
            anotherBuilder.PrintDimensions();

            // OUTPUT
            // W/H/D 5/10/66
            // W/H/D 0/10/5
        }
    }

    class Builder
    {
        int _width;

        int _height;

        int _depth;

        public Builder Width(int width)
        {
            _width = width;
            return this;
        }

        public Builder Height(int height)
        {
            _height = height;
            return this;
        }

        public Builder Depth(int depth)
        {
            _depth = depth;
            return this;
        }

        public void PrintDimensions()
        {
            Console.WriteLine($"W/H/D {this._width}/{this._height}/{this._depth}");
        }
    }
}
