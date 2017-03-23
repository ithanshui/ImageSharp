﻿namespace ImageSharp
{
    using System;

    /// <summary>
    /// A parametric curve
    /// </summary>
    internal sealed class IccParametricCurve : IEquatable<IccParametricCurve>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IccParametricCurve"/> class.
        /// </summary>
        /// <param name="g">G curve parameter</param>
        public IccParametricCurve(double g)
            : this(0, g, 0, 0, 0, 0, 0, 0)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IccParametricCurve"/> class.
        /// </summary>
        /// <param name="g">G curve parameter</param>
        /// <param name="a">A curve parameter</param>
        /// <param name="b">B curve parameter</param>
        public IccParametricCurve(double g, double a, double b)
            : this(1, g, a, b, 0, 0, 0, 0)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IccParametricCurve"/> class.
        /// </summary>
        /// <param name="g">G curve parameter</param>
        /// <param name="a">A curve parameter</param>
        /// <param name="b">B curve parameter</param>
        /// <param name="c">C curve parameter</param>
        public IccParametricCurve(double g, double a, double b, double c)
            : this(2, g, a, b, c, 0, 0, 0)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IccParametricCurve"/> class.
        /// </summary>
        /// <param name="g">G curve parameter</param>
        /// <param name="a">A curve parameter</param>
        /// <param name="b">B curve parameter</param>
        /// <param name="c">C curve parameter</param>
        /// <param name="d">D curve parameter</param>
        public IccParametricCurve(double g, double a, double b, double c, double d)
            : this(3, g, a, b, c, d, 0, 0)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IccParametricCurve"/> class.
        /// </summary>
        /// <param name="g">G curve parameter</param>
        /// <param name="a">A curve parameter</param>
        /// <param name="b">B curve parameter</param>
        /// <param name="c">C curve parameter</param>
        /// <param name="d">D curve parameter</param>
        /// <param name="e">E curve parameter</param>
        /// <param name="f">F curve parameter</param>
        public IccParametricCurve(double g, double a, double b, double c, double d, double e, double f)
            : this(4, g, a, b, c, d, e, f)
        {
        }

        private IccParametricCurve(ushort type, double g, double a, double b, double c, double d, double e, double f)
        {
            Guard.MustBeBetweenOrEqualTo(type, 0, 4, nameof(type));

            this.Type = type;
            this.G = g;
            this.A = a;
            this.B = b;
            this.C = c;
            this.D = d;
            this.E = e;
            this.F = f;
        }

        /// <summary>
        /// Gets the type of this curve
        /// </summary>
        public ushort Type { get; }

        /// <summary>
        /// Gets the G curve parameter
        /// </summary>
        public double G { get; }

        /// <summary>
        /// Gets the A curve parameter
        /// </summary>
        public double A { get; }

        /// <summary>
        /// Gets the B curve parameter
        /// </summary>
        public double B { get; }

        /// <summary>
        /// Gets the C curve parameter
        /// </summary>
        public double C { get; }

        /// <summary>
        /// Gets the D curve parameter
        /// </summary>
        public double D { get; }

        /// <summary>
        /// Gets the E curve parameter
        /// </summary>
        public double E { get; }

        /// <summary>
        /// Gets the F curve parameter
        /// </summary>
        public double F { get; }

        /// <inheritdoc/>
        public bool Equals(IccParametricCurve other)
        {
            if (other == null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Type == other.Type
                && this.G == other.G
                && this.A == other.A
                && this.B == other.B
                && this.C == other.C
                && this.D == other.D
                && this.E == other.E
                && this.F == other.F;
        }
    }
}