//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [System.Serializable]
    [Il2CppEagerStaticClassConstruction]
    public partial struct double2x2 : System.IEquatable<double2x2>, IFormattable
    {
        public double2 c0;
        public double2 c1;

        /// <summary>double2x2 identity transform.</summary>
        public static readonly double2x2 identity = new double2x2(1.0, 0.0,   0.0, 1.0);

        /// <summary>double2x2 zero value.</summary>
        public static readonly double2x2 zero;

        /// <summary>Constructs a double2x2 matrix from two double2 vectors.</summary>
        /// <param name="c0">The matrix column c0 will be set to this value.</param>
        /// <param name="c1">The matrix column c1 will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2x2(double2 c0, double2 c1)
        {
            this.c0 = c0;
            this.c1 = c1;
        }

        /// <summary>Constructs a double2x2 matrix from 4 double values given in row-major order.</summary>
        /// <param name="m00">The matrix at row 0, column 0 will be set to this value.</param>
        /// <param name="m01">The matrix at row 0, column 1 will be set to this value.</param>
        /// <param name="m10">The matrix at row 1, column 0 will be set to this value.</param>
        /// <param name="m11">The matrix at row 1, column 1 will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2x2(double m00, double m01,
                         double m10, double m11)
        {
            this.c0 = new double2(m00, m10);
            this.c1 = new double2(m01, m11);
        }

        /// <summary>Constructs a double2x2 matrix from a single double value by assigning it to every component.</summary>
        /// <param name="v">double to convert to double2x2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2x2(double v)
        {
            this.c0 = v;
            this.c1 = v;
        }

        /// <summary>Constructs a double2x2 matrix from a single bool value by converting it to double and assigning it to every component.</summary>
        /// <param name="v">bool to convert to double2x2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2x2(bool v)
        {
            this.c0 = math.select(new double2(0.0), new double2(1.0), v);
            this.c1 = math.select(new double2(0.0), new double2(1.0), v);
        }

        /// <summary>Constructs a double2x2 matrix from a bool2x2 matrix by componentwise conversion.</summary>
        /// <param name="v">bool2x2 to convert to double2x2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2x2(bool2x2 v)
        {
            this.c0 = math.select(new double2(0.0), new double2(1.0), v.c0);
            this.c1 = math.select(new double2(0.0), new double2(1.0), v.c1);
        }

        /// <summary>Constructs a double2x2 matrix from a single int value by converting it to double and assigning it to every component.</summary>
        /// <param name="v">int to convert to double2x2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2x2(int v)
        {
            this.c0 = v;
            this.c1 = v;
        }

        /// <summary>Constructs a double2x2 matrix from a int2x2 matrix by componentwise conversion.</summary>
        /// <param name="v">int2x2 to convert to double2x2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2x2(int2x2 v)
        {
            this.c0 = v.c0;
            this.c1 = v.c1;
        }

        /// <summary>Constructs a double2x2 matrix from a single uint value by converting it to double and assigning it to every component.</summary>
        /// <param name="v">uint to convert to double2x2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2x2(uint v)
        {
            this.c0 = v;
            this.c1 = v;
        }

        /// <summary>Constructs a double2x2 matrix from a uint2x2 matrix by componentwise conversion.</summary>
        /// <param name="v">uint2x2 to convert to double2x2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2x2(uint2x2 v)
        {
            this.c0 = v.c0;
            this.c1 = v.c1;
        }

        /// <summary>Constructs a double2x2 matrix from a single float value by converting it to double and assigning it to every component.</summary>
        /// <param name="v">float to convert to double2x2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2x2(float v)
        {
            this.c0 = v;
            this.c1 = v;
        }

        /// <summary>Constructs a double2x2 matrix from a float2x2 matrix by componentwise conversion.</summary>
        /// <param name="v">float2x2 to convert to double2x2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2x2(float2x2 v)
        {
            this.c0 = v.c0;
            this.c1 = v.c1;
        }


        /// <summary>Implicitly converts a single double value to a double2x2 matrix by assigning it to every component.</summary>
        /// <param name="v">double to convert to double2x2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2x2(double v) { return new double2x2(v); }

        /// <summary>Explicitly converts a single bool value to a double2x2 matrix by converting it to double and assigning it to every component.</summary>
        /// <param name="v">bool to convert to double2x2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double2x2(bool v) { return new double2x2(v); }

        /// <summary>Explicitly converts a bool2x2 matrix to a double2x2 matrix by componentwise conversion.</summary>
        /// <param name="v">bool2x2 to convert to double2x2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double2x2(bool2x2 v) { return new double2x2(v); }

        /// <summary>Implicitly converts a single int value to a double2x2 matrix by converting it to double and assigning it to every component.</summary>
        /// <param name="v">int to convert to double2x2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2x2(int v) { return new double2x2(v); }

        /// <summary>Implicitly converts a int2x2 matrix to a double2x2 matrix by componentwise conversion.</summary>
        /// <param name="v">int2x2 to convert to double2x2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2x2(int2x2 v) { return new double2x2(v); }

        /// <summary>Implicitly converts a single uint value to a double2x2 matrix by converting it to double and assigning it to every component.</summary>
        /// <param name="v">uint to convert to double2x2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2x2(uint v) { return new double2x2(v); }

        /// <summary>Implicitly converts a uint2x2 matrix to a double2x2 matrix by componentwise conversion.</summary>
        /// <param name="v">uint2x2 to convert to double2x2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2x2(uint2x2 v) { return new double2x2(v); }

        /// <summary>Implicitly converts a single float value to a double2x2 matrix by converting it to double and assigning it to every component.</summary>
        /// <param name="v">float to convert to double2x2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2x2(float v) { return new double2x2(v); }

        /// <summary>Implicitly converts a float2x2 matrix to a double2x2 matrix by componentwise conversion.</summary>
        /// <param name="v">float2x2 to convert to double2x2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2x2(float2x2 v) { return new double2x2(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two double2x2 matrices.</summary>
        /// <param name="lhs">Left hand side double2x2 to use to compute componentwise multiplication.</param>
        /// <param name="rhs">Right hand side double2x2 to use to compute componentwise multiplication.</param>
        /// <returns>double2x2 result of the componentwise multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 operator * (double2x2 lhs, double2x2 rhs) { return new double2x2 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1); }

        /// <summary>Returns the result of a componentwise multiplication operation on a double2x2 matrix and a double value.</summary>
        /// <param name="lhs">Left hand side double2x2 to use to compute componentwise multiplication.</param>
        /// <param name="rhs">Right hand side double to use to compute componentwise multiplication.</param>
        /// <returns>double2x2 result of the componentwise multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 operator * (double2x2 lhs, double rhs) { return new double2x2 (lhs.c0 * rhs, lhs.c1 * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on a double value and a double2x2 matrix.</summary>
        /// <param name="lhs">Left hand side double to use to compute componentwise multiplication.</param>
        /// <param name="rhs">Right hand side double2x2 to use to compute componentwise multiplication.</param>
        /// <returns>double2x2 result of the componentwise multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 operator * (double lhs, double2x2 rhs) { return new double2x2 (lhs * rhs.c0, lhs * rhs.c1); }


        /// <summary>Returns the result of a componentwise addition operation on two double2x2 matrices.</summary>
        /// <param name="lhs">Left hand side double2x2 to use to compute componentwise addition.</param>
        /// <param name="rhs">Right hand side double2x2 to use to compute componentwise addition.</param>
        /// <returns>double2x2 result of the componentwise addition.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 operator + (double2x2 lhs, double2x2 rhs) { return new double2x2 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1); }

        /// <summary>Returns the result of a componentwise addition operation on a double2x2 matrix and a double value.</summary>
        /// <param name="lhs">Left hand side double2x2 to use to compute componentwise addition.</param>
        /// <param name="rhs">Right hand side double to use to compute componentwise addition.</param>
        /// <returns>double2x2 result of the componentwise addition.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 operator + (double2x2 lhs, double rhs) { return new double2x2 (lhs.c0 + rhs, lhs.c1 + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on a double value and a double2x2 matrix.</summary>
        /// <param name="lhs">Left hand side double to use to compute componentwise addition.</param>
        /// <param name="rhs">Right hand side double2x2 to use to compute componentwise addition.</param>
        /// <returns>double2x2 result of the componentwise addition.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 operator + (double lhs, double2x2 rhs) { return new double2x2 (lhs + rhs.c0, lhs + rhs.c1); }


        /// <summary>Returns the result of a componentwise subtraction operation on two double2x2 matrices.</summary>
        /// <param name="lhs">Left hand side double2x2 to use to compute componentwise subtraction.</param>
        /// <param name="rhs">Right hand side double2x2 to use to compute componentwise subtraction.</param>
        /// <returns>double2x2 result of the componentwise subtraction.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 operator - (double2x2 lhs, double2x2 rhs) { return new double2x2 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1); }

        /// <summary>Returns the result of a componentwise subtraction operation on a double2x2 matrix and a double value.</summary>
        /// <param name="lhs">Left hand side double2x2 to use to compute componentwise subtraction.</param>
        /// <param name="rhs">Right hand side double to use to compute componentwise subtraction.</param>
        /// <returns>double2x2 result of the componentwise subtraction.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 operator - (double2x2 lhs, double rhs) { return new double2x2 (lhs.c0 - rhs, lhs.c1 - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on a double value and a double2x2 matrix.</summary>
        /// <param name="lhs">Left hand side double to use to compute componentwise subtraction.</param>
        /// <param name="rhs">Right hand side double2x2 to use to compute componentwise subtraction.</param>
        /// <returns>double2x2 result of the componentwise subtraction.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 operator - (double lhs, double2x2 rhs) { return new double2x2 (lhs - rhs.c0, lhs - rhs.c1); }


        /// <summary>Returns the result of a componentwise division operation on two double2x2 matrices.</summary>
        /// <param name="lhs">Left hand side double2x2 to use to compute componentwise division.</param>
        /// <param name="rhs">Right hand side double2x2 to use to compute componentwise division.</param>
        /// <returns>double2x2 result of the componentwise division.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 operator / (double2x2 lhs, double2x2 rhs) { return new double2x2 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1); }

        /// <summary>Returns the result of a componentwise division operation on a double2x2 matrix and a double value.</summary>
        /// <param name="lhs">Left hand side double2x2 to use to compute componentwise division.</param>
        /// <param name="rhs">Right hand side double to use to compute componentwise division.</param>
        /// <returns>double2x2 result of the componentwise division.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 operator / (double2x2 lhs, double rhs) { return new double2x2 (lhs.c0 / rhs, lhs.c1 / rhs); }

        /// <summary>Returns the result of a componentwise division operation on a double value and a double2x2 matrix.</summary>
        /// <param name="lhs">Left hand side double to use to compute componentwise division.</param>
        /// <param name="rhs">Right hand side double2x2 to use to compute componentwise division.</param>
        /// <returns>double2x2 result of the componentwise division.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 operator / (double lhs, double2x2 rhs) { return new double2x2 (lhs / rhs.c0, lhs / rhs.c1); }


        /// <summary>Returns the result of a componentwise modulus operation on two double2x2 matrices.</summary>
        /// <param name="lhs">Left hand side double2x2 to use to compute componentwise modulus.</param>
        /// <param name="rhs">Right hand side double2x2 to use to compute componentwise modulus.</param>
        /// <returns>double2x2 result of the componentwise modulus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 operator % (double2x2 lhs, double2x2 rhs) { return new double2x2 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1); }

        /// <summary>Returns the result of a componentwise modulus operation on a double2x2 matrix and a double value.</summary>
        /// <param name="lhs">Left hand side double2x2 to use to compute componentwise modulus.</param>
        /// <param name="rhs">Right hand side double to use to compute componentwise modulus.</param>
        /// <returns>double2x2 result of the componentwise modulus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 operator % (double2x2 lhs, double rhs) { return new double2x2 (lhs.c0 % rhs, lhs.c1 % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on a double value and a double2x2 matrix.</summary>
        /// <param name="lhs">Left hand side double to use to compute componentwise modulus.</param>
        /// <param name="rhs">Right hand side double2x2 to use to compute componentwise modulus.</param>
        /// <returns>double2x2 result of the componentwise modulus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 operator % (double lhs, double2x2 rhs) { return new double2x2 (lhs % rhs.c0, lhs % rhs.c1); }


        /// <summary>Returns the result of a componentwise increment operation on a double2x2 matrix.</summary>
        /// <param name="val">Value to use when computing the componentwise increment.</param>
        /// <returns>double2x2 result of the componentwise increment.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 operator ++ (double2x2 val) { return new double2x2 (++val.c0, ++val.c1); }


        /// <summary>Returns the result of a componentwise decrement operation on a double2x2 matrix.</summary>
        /// <param name="val">Value to use when computing the componentwise decrement.</param>
        /// <returns>double2x2 result of the componentwise decrement.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 operator -- (double2x2 val) { return new double2x2 (--val.c0, --val.c1); }


        /// <summary>Returns the result of a componentwise less than operation on two double2x2 matrices.</summary>
        /// <param name="lhs">Left hand side double2x2 to use to compute componentwise less than.</param>
        /// <param name="rhs">Right hand side double2x2 to use to compute componentwise less than.</param>
        /// <returns>bool2x2 result of the componentwise less than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator < (double2x2 lhs, double2x2 rhs) { return new bool2x2 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1); }

        /// <summary>Returns the result of a componentwise less than operation on a double2x2 matrix and a double value.</summary>
        /// <param name="lhs">Left hand side double2x2 to use to compute componentwise less than.</param>
        /// <param name="rhs">Right hand side double to use to compute componentwise less than.</param>
        /// <returns>bool2x2 result of the componentwise less than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator < (double2x2 lhs, double rhs) { return new bool2x2 (lhs.c0 < rhs, lhs.c1 < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on a double value and a double2x2 matrix.</summary>
        /// <param name="lhs">Left hand side double to use to compute componentwise less than.</param>
        /// <param name="rhs">Right hand side double2x2 to use to compute componentwise less than.</param>
        /// <returns>bool2x2 result of the componentwise less than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator < (double lhs, double2x2 rhs) { return new bool2x2 (lhs < rhs.c0, lhs < rhs.c1); }


        /// <summary>Returns the result of a componentwise less or equal operation on two double2x2 matrices.</summary>
        /// <param name="lhs">Left hand side double2x2 to use to compute componentwise less or equal.</param>
        /// <param name="rhs">Right hand side double2x2 to use to compute componentwise less or equal.</param>
        /// <returns>bool2x2 result of the componentwise less or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator <= (double2x2 lhs, double2x2 rhs) { return new bool2x2 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1); }

        /// <summary>Returns the result of a componentwise less or equal operation on a double2x2 matrix and a double value.</summary>
        /// <param name="lhs">Left hand side double2x2 to use to compute componentwise less or equal.</param>
        /// <param name="rhs">Right hand side double to use to compute componentwise less or equal.</param>
        /// <returns>bool2x2 result of the componentwise less or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator <= (double2x2 lhs, double rhs) { return new bool2x2 (lhs.c0 <= rhs, lhs.c1 <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on a double value and a double2x2 matrix.</summary>
        /// <param name="lhs">Left hand side double to use to compute componentwise less or equal.</param>
        /// <param name="rhs">Right hand side double2x2 to use to compute componentwise less or equal.</param>
        /// <returns>bool2x2 result of the componentwise less or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator <= (double lhs, double2x2 rhs) { return new bool2x2 (lhs <= rhs.c0, lhs <= rhs.c1); }


        /// <summary>Returns the result of a componentwise greater than operation on two double2x2 matrices.</summary>
        /// <param name="lhs">Left hand side double2x2 to use to compute componentwise greater than.</param>
        /// <param name="rhs">Right hand side double2x2 to use to compute componentwise greater than.</param>
        /// <returns>bool2x2 result of the componentwise greater than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator > (double2x2 lhs, double2x2 rhs) { return new bool2x2 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1); }

        /// <summary>Returns the result of a componentwise greater than operation on a double2x2 matrix and a double value.</summary>
        /// <param name="lhs">Left hand side double2x2 to use to compute componentwise greater than.</param>
        /// <param name="rhs">Right hand side double to use to compute componentwise greater than.</param>
        /// <returns>bool2x2 result of the componentwise greater than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator > (double2x2 lhs, double rhs) { return new bool2x2 (lhs.c0 > rhs, lhs.c1 > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on a double value and a double2x2 matrix.</summary>
        /// <param name="lhs">Left hand side double to use to compute componentwise greater than.</param>
        /// <param name="rhs">Right hand side double2x2 to use to compute componentwise greater than.</param>
        /// <returns>bool2x2 result of the componentwise greater than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator > (double lhs, double2x2 rhs) { return new bool2x2 (lhs > rhs.c0, lhs > rhs.c1); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two double2x2 matrices.</summary>
        /// <param name="lhs">Left hand side double2x2 to use to compute componentwise greater or equal.</param>
        /// <param name="rhs">Right hand side double2x2 to use to compute componentwise greater or equal.</param>
        /// <returns>bool2x2 result of the componentwise greater or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator >= (double2x2 lhs, double2x2 rhs) { return new bool2x2 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a double2x2 matrix and a double value.</summary>
        /// <param name="lhs">Left hand side double2x2 to use to compute componentwise greater or equal.</param>
        /// <param name="rhs">Right hand side double to use to compute componentwise greater or equal.</param>
        /// <returns>bool2x2 result of the componentwise greater or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator >= (double2x2 lhs, double rhs) { return new bool2x2 (lhs.c0 >= rhs, lhs.c1 >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a double value and a double2x2 matrix.</summary>
        /// <param name="lhs">Left hand side double to use to compute componentwise greater or equal.</param>
        /// <param name="rhs">Right hand side double2x2 to use to compute componentwise greater or equal.</param>
        /// <returns>bool2x2 result of the componentwise greater or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator >= (double lhs, double2x2 rhs) { return new bool2x2 (lhs >= rhs.c0, lhs >= rhs.c1); }


        /// <summary>Returns the result of a componentwise unary minus operation on a double2x2 matrix.</summary>
        /// <param name="val">Value to use when computing the componentwise unary minus.</param>
        /// <returns>double2x2 result of the componentwise unary minus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 operator - (double2x2 val) { return new double2x2 (-val.c0, -val.c1); }


        /// <summary>Returns the result of a componentwise unary plus operation on a double2x2 matrix.</summary>
        /// <param name="val">Value to use when computing the componentwise unary plus.</param>
        /// <returns>double2x2 result of the componentwise unary plus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 operator + (double2x2 val) { return new double2x2 (+val.c0, +val.c1); }


        /// <summary>Returns the result of a componentwise equality operation on two double2x2 matrices.</summary>
        /// <param name="lhs">Left hand side double2x2 to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side double2x2 to use to compute componentwise equality.</param>
        /// <returns>bool2x2 result of the componentwise equality.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator == (double2x2 lhs, double2x2 rhs) { return new bool2x2 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1); }

        /// <summary>Returns the result of a componentwise equality operation on a double2x2 matrix and a double value.</summary>
        /// <param name="lhs">Left hand side double2x2 to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side double to use to compute componentwise equality.</param>
        /// <returns>bool2x2 result of the componentwise equality.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator == (double2x2 lhs, double rhs) { return new bool2x2 (lhs.c0 == rhs, lhs.c1 == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a double value and a double2x2 matrix.</summary>
        /// <param name="lhs">Left hand side double to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side double2x2 to use to compute componentwise equality.</param>
        /// <returns>bool2x2 result of the componentwise equality.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator == (double lhs, double2x2 rhs) { return new bool2x2 (lhs == rhs.c0, lhs == rhs.c1); }


        /// <summary>Returns the result of a componentwise not equal operation on two double2x2 matrices.</summary>
        /// <param name="lhs">Left hand side double2x2 to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side double2x2 to use to compute componentwise not equal.</param>
        /// <returns>bool2x2 result of the componentwise not equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator != (double2x2 lhs, double2x2 rhs) { return new bool2x2 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1); }

        /// <summary>Returns the result of a componentwise not equal operation on a double2x2 matrix and a double value.</summary>
        /// <param name="lhs">Left hand side double2x2 to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side double to use to compute componentwise not equal.</param>
        /// <returns>bool2x2 result of the componentwise not equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator != (double2x2 lhs, double rhs) { return new bool2x2 (lhs.c0 != rhs, lhs.c1 != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a double value and a double2x2 matrix.</summary>
        /// <param name="lhs">Left hand side double to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side double2x2 to use to compute componentwise not equal.</param>
        /// <returns>bool2x2 result of the componentwise not equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator != (double lhs, double2x2 rhs) { return new bool2x2 (lhs != rhs.c0, lhs != rhs.c1); }



        /// <summary>Returns the double2 element at a specified index.</summary>
        unsafe public ref double2 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (double2x2* array = &this) { return ref ((double2*)array)[index]; }
            }
        }

        /// <summary>Returns true if the double2x2 is equal to a given double2x2, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(double2x2 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1); }

        /// <summary>Returns true if the double2x2 is equal to a given double2x2, false otherwise.</summary>
        public override bool Equals(object o) { return o is double2x2 converted && Equals(converted); }


        /// <summary>Returns a hash code for the double2x2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        /// <summary>Returns a string representation of the double2x2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("double2x2({0}, {1},  {2}, {3})", c0.x, c1.x, c0.y, c1.y);
        }

        /// <summary>Returns a string representation of the double2x2 using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("double2x2({0}, {1},  {2}, {3})", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider));
        }

    }

    public static partial class math
    {
        /// <summary>Returns a double2x2 matrix constructed from two double2 vectors.</summary>
        /// <param name="c0">The matrix column c0 will be set to this value.</param>
        /// <param name="c1">The matrix column c1 will be set to this value.</param>
        /// <returns>double2x2 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 double2x2(double2 c0, double2 c1) { return new double2x2(c0, c1); }

        /// <summary>Returns a double2x2 matrix constructed from from 4 double values given in row-major order.</summary>
        /// <param name="m00">The matrix at row 0, column 0 will be set to this value.</param>
        /// <param name="m01">The matrix at row 0, column 1 will be set to this value.</param>
        /// <param name="m10">The matrix at row 1, column 0 will be set to this value.</param>
        /// <param name="m11">The matrix at row 1, column 1 will be set to this value.</param>
        /// <returns>double2x2 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 double2x2(double m00, double m01,
                                          double m10, double m11)
        {
            return new double2x2(m00, m01,
                                 m10, m11);
        }

        /// <summary>Returns a double2x2 matrix constructed from a single double value by assigning it to every component.</summary>
        /// <param name="v">double to convert to double2x2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 double2x2(double v) { return new double2x2(v); }

        /// <summary>Returns a double2x2 matrix constructed from a single bool value by converting it to double and assigning it to every component.</summary>
        /// <param name="v">bool to convert to double2x2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 double2x2(bool v) { return new double2x2(v); }

        /// <summary>Return a double2x2 matrix constructed from a bool2x2 matrix by componentwise conversion.</summary>
        /// <param name="v">bool2x2 to convert to double2x2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 double2x2(bool2x2 v) { return new double2x2(v); }

        /// <summary>Returns a double2x2 matrix constructed from a single int value by converting it to double and assigning it to every component.</summary>
        /// <param name="v">int to convert to double2x2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 double2x2(int v) { return new double2x2(v); }

        /// <summary>Return a double2x2 matrix constructed from a int2x2 matrix by componentwise conversion.</summary>
        /// <param name="v">int2x2 to convert to double2x2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 double2x2(int2x2 v) { return new double2x2(v); }

        /// <summary>Returns a double2x2 matrix constructed from a single uint value by converting it to double and assigning it to every component.</summary>
        /// <param name="v">uint to convert to double2x2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 double2x2(uint v) { return new double2x2(v); }

        /// <summary>Return a double2x2 matrix constructed from a uint2x2 matrix by componentwise conversion.</summary>
        /// <param name="v">uint2x2 to convert to double2x2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 double2x2(uint2x2 v) { return new double2x2(v); }

        /// <summary>Returns a double2x2 matrix constructed from a single float value by converting it to double and assigning it to every component.</summary>
        /// <param name="v">float to convert to double2x2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 double2x2(float v) { return new double2x2(v); }

        /// <summary>Return a double2x2 matrix constructed from a float2x2 matrix by componentwise conversion.</summary>
        /// <param name="v">float2x2 to convert to double2x2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 double2x2(float2x2 v) { return new double2x2(v); }

        /// <summary>Return the double2x2 transpose of a double2x2 matrix.</summary>
        /// <param name="v">Value to transpose.</param>
        /// <returns>Transposed value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 transpose(double2x2 v)
        {
            return double2x2(
                v.c0.x, v.c0.y,
                v.c1.x, v.c1.y);
        }

        /// <summary>Returns the double2x2 full inverse of a double2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 inverse(double2x2 m)
        {
            double a = m.c0.x;
            double b = m.c1.x;
            double c = m.c0.y;
            double d = m.c1.y;

            double det = a * d - b * c;

            return double2x2(d, -b, -c, a) * (1.0 / det);
        }

        /// <summary>Returns the determinant of a double2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double determinant(double2x2 m)
        {
            double a = m.c0.x;
            double b = m.c1.x;
            double c = m.c0.y;
            double d = m.c1.y;

            return a * d - b * c;
        }

        /// <summary>Returns a uint hash code of a double2x2 matrix.</summary>
        /// <param name="v">Matrix value to hash.</param>
        /// <returns>uint hash of the argument.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(double2x2 v)
        {
            return csum(fold_to_uint(v.c0) * uint2(0xFD80290Bu, 0x8B65ADB7u) +
                        fold_to_uint(v.c1) * uint2(0xDFF4F563u, 0x7069770Du)) + 0xD1224537u;
        }

        /// <summary>
        /// Returns a uint2 vector hash code of a double2x2 matrix.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        /// <param name="v">Matrix value to hash.</param>
        /// <returns>uint2 hash of the argument.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 hashwide(double2x2 v)
        {
            return (fold_to_uint(v.c0) * uint2(0xE99ED6F3u, 0x48125549u) +
                    fold_to_uint(v.c1) * uint2(0xEEE2123Bu, 0xE3AD9FE5u)) + 0xCE1CF8BFu;
        }

    }
}
