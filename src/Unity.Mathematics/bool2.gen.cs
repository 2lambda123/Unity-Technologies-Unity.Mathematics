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
using System.Runtime.InteropServices;
using System.Diagnostics;
using Unity.IL2CPP.CompilerServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [DebuggerTypeProxy(typeof(bool2.DebuggerProxy))]
    [System.Serializable]
    [Il2CppEagerStaticClassConstruction]
    public partial struct bool2 : System.IEquatable<bool2>
    {
        /// <summary>x component of the vector.</summary>
        [MarshalAs(UnmanagedType.U1)]
        public bool x;
        /// <summary>y component of the vector.</summary>
        [MarshalAs(UnmanagedType.U1)]
        public bool y;


        /// <summary>Constructs a bool2 vector from two bool values.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="y">The constructed vector's y component will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool2(bool x, bool y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>Constructs a bool2 vector from a bool2 vector.</summary>
        /// <param name="xy">The constructed vector's xy components will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool2(bool2 xy)
        {
            this.x = xy.x;
            this.y = xy.y;
        }

        /// <summary>Constructs a bool2 vector from a single bool value by assigning it to every component.</summary>
        /// <param name="v">bool to convert to bool2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool2(bool v)
        {
            this.x = v;
            this.y = v;
        }


        /// <summary>Implicitly converts a single bool value to a bool2 vector by assigning it to every component.</summary>
        /// <param name="v">bool to convert to bool2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator bool2(bool v) { return new bool2(v); }


        /// <summary>Returns the result of a componentwise equality operation on two bool2 vectors.</summary>
        /// <param name="lhs">Left hand side bool2 to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side bool2 to use to compute componentwise equality.</param>
        /// <returns>bool2 result of the componentwise equality.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator == (bool2 lhs, bool2 rhs) { return new bool2 (lhs.x == rhs.x, lhs.y == rhs.y); }

        /// <summary>Returns the result of a componentwise equality operation on a bool2 vector and a bool value.</summary>
        /// <param name="lhs">Left hand side bool2 to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side bool to use to compute componentwise equality.</param>
        /// <returns>bool2 result of the componentwise equality.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator == (bool2 lhs, bool rhs) { return new bool2 (lhs.x == rhs, lhs.y == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a bool value and a bool2 vector.</summary>
        /// <param name="lhs">Left hand side bool to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side bool2 to use to compute componentwise equality.</param>
        /// <returns>bool2 result of the componentwise equality.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator == (bool lhs, bool2 rhs) { return new bool2 (lhs == rhs.x, lhs == rhs.y); }


        /// <summary>Returns the result of a componentwise not equal operation on two bool2 vectors.</summary>
        /// <param name="lhs">Left hand side bool2 to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side bool2 to use to compute componentwise not equal.</param>
        /// <returns>bool2 result of the componentwise not equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator != (bool2 lhs, bool2 rhs) { return new bool2 (lhs.x != rhs.x, lhs.y != rhs.y); }

        /// <summary>Returns the result of a componentwise not equal operation on a bool2 vector and a bool value.</summary>
        /// <param name="lhs">Left hand side bool2 to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side bool to use to compute componentwise not equal.</param>
        /// <returns>bool2 result of the componentwise not equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator != (bool2 lhs, bool rhs) { return new bool2 (lhs.x != rhs, lhs.y != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a bool value and a bool2 vector.</summary>
        /// <param name="lhs">Left hand side bool to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side bool2 to use to compute componentwise not equal.</param>
        /// <returns>bool2 result of the componentwise not equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator != (bool lhs, bool2 rhs) { return new bool2 (lhs != rhs.x, lhs != rhs.y); }


        /// <summary>Returns the result of a componentwise not operation on a bool2 vector.</summary>
        /// <param name="val">Value to use when computing the componentwise not.</param>
        /// <returns>bool2 result of the componentwise not.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator ! (bool2 val) { return new bool2 (!val.x, !val.y); }


        /// <summary>Returns the result of a componentwise bitwise and operation on two bool2 vectors.</summary>
        /// <param name="lhs">Left hand side bool2 to use to compute componentwise bitwise and.</param>
        /// <param name="rhs">Right hand side bool2 to use to compute componentwise bitwise and.</param>
        /// <returns>bool2 result of the componentwise bitwise and.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator & (bool2 lhs, bool2 rhs) { return new bool2 (lhs.x & rhs.x, lhs.y & rhs.y); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a bool2 vector and a bool value.</summary>
        /// <param name="lhs">Left hand side bool2 to use to compute componentwise bitwise and.</param>
        /// <param name="rhs">Right hand side bool to use to compute componentwise bitwise and.</param>
        /// <returns>bool2 result of the componentwise bitwise and.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator & (bool2 lhs, bool rhs) { return new bool2 (lhs.x & rhs, lhs.y & rhs); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a bool value and a bool2 vector.</summary>
        /// <param name="lhs">Left hand side bool to use to compute componentwise bitwise and.</param>
        /// <param name="rhs">Right hand side bool2 to use to compute componentwise bitwise and.</param>
        /// <returns>bool2 result of the componentwise bitwise and.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator & (bool lhs, bool2 rhs) { return new bool2 (lhs & rhs.x, lhs & rhs.y); }


        /// <summary>Returns the result of a componentwise bitwise or operation on two bool2 vectors.</summary>
        /// <param name="lhs">Left hand side bool2 to use to compute componentwise bitwise or.</param>
        /// <param name="rhs">Right hand side bool2 to use to compute componentwise bitwise or.</param>
        /// <returns>bool2 result of the componentwise bitwise or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator | (bool2 lhs, bool2 rhs) { return new bool2 (lhs.x | rhs.x, lhs.y | rhs.y); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a bool2 vector and a bool value.</summary>
        /// <param name="lhs">Left hand side bool2 to use to compute componentwise bitwise or.</param>
        /// <param name="rhs">Right hand side bool to use to compute componentwise bitwise or.</param>
        /// <returns>bool2 result of the componentwise bitwise or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator | (bool2 lhs, bool rhs) { return new bool2 (lhs.x | rhs, lhs.y | rhs); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a bool value and a bool2 vector.</summary>
        /// <param name="lhs">Left hand side bool to use to compute componentwise bitwise or.</param>
        /// <param name="rhs">Right hand side bool2 to use to compute componentwise bitwise or.</param>
        /// <returns>bool2 result of the componentwise bitwise or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator | (bool lhs, bool2 rhs) { return new bool2 (lhs | rhs.x, lhs | rhs.y); }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two bool2 vectors.</summary>
        /// <param name="lhs">Left hand side bool2 to use to compute componentwise bitwise exclusive or.</param>
        /// <param name="rhs">Right hand side bool2 to use to compute componentwise bitwise exclusive or.</param>
        /// <returns>bool2 result of the componentwise bitwise exclusive or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator ^ (bool2 lhs, bool2 rhs) { return new bool2 (lhs.x ^ rhs.x, lhs.y ^ rhs.y); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a bool2 vector and a bool value.</summary>
        /// <param name="lhs">Left hand side bool2 to use to compute componentwise bitwise exclusive or.</param>
        /// <param name="rhs">Right hand side bool to use to compute componentwise bitwise exclusive or.</param>
        /// <returns>bool2 result of the componentwise bitwise exclusive or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator ^ (bool2 lhs, bool rhs) { return new bool2 (lhs.x ^ rhs, lhs.y ^ rhs); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a bool value and a bool2 vector.</summary>
        /// <param name="lhs">Left hand side bool to use to compute componentwise bitwise exclusive or.</param>
        /// <param name="rhs">Right hand side bool2 to use to compute componentwise bitwise exclusive or.</param>
        /// <returns>bool2 result of the componentwise bitwise exclusive or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator ^ (bool lhs, bool2 rhs) { return new bool2 (lhs ^ rhs.x, lhs ^ rhs.y); }




        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 xxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(x, x, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 xxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(x, x, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 xxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(x, x, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 xxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(x, x, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 xyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(x, y, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 xyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(x, y, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 xyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(x, y, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 xyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(x, y, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 yxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(y, x, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 yxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(y, x, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 yxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(y, x, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 yxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(y, x, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 yyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(y, y, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 yyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(y, y, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 yyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(y, y, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 yyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(y, y, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool3 xxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool3(x, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool3 xxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool3(x, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool3 xyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool3(x, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool3 xyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool3(x, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool3 yxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool3(y, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool3 yxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool3(y, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool3 yyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool3(y, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool3 yyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool3(y, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool2 xx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool2(x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool2 xy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool2(x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool2 yx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool2(y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool2 yy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool2(y, y); }
        }



        /// <summary>Returns the bool element at a specified index.</summary>
        unsafe public bool this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (bool2* array = &this) { return ((bool*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (bool* array = &x) { array[index] = value; }
            }
        }

        /// <summary>Returns true if the bool2 is equal to a given bool2, false otherwise.</summary>
        /// <param name="rhs">Right hand side argument to compare equality with.</param>
        /// <returns>The result of the equality comparison.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(bool2 rhs) { return x == rhs.x && y == rhs.y; }

        /// <summary>Returns true if the bool2 is equal to a given bool2, false otherwise.</summary>
        /// <param name="o">Right hand side argument to compare equality with.</param>
        /// <returns>The result of the equality comparison.</returns>
        public override bool Equals(object o) { return o is bool2 converted && Equals(converted); }


        /// <summary>Returns a hash code for the bool2.</summary>
        /// <returns>The computed hash code.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        /// <summary>Returns a string representation of the bool2.</summary>
        /// <returns>String representation of the value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("bool2({0}, {1})", x, y);
        }

        internal sealed class DebuggerProxy
        {
            public bool x;
            public bool y;
            public DebuggerProxy(bool2 v)
            {
                x = v.x;
                y = v.y;
            }
        }

    }

    public static partial class math
    {
        /// <summary>Returns a bool2 vector constructed from two bool values.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="y">The constructed vector's y component will be set to this value.</param>
        /// <returns>bool2 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 bool2(bool x, bool y) { return new bool2(x, y); }

        /// <summary>Returns a bool2 vector constructed from a bool2 vector.</summary>
        /// <param name="xy">The constructed vector's xy components will be set to this value.</param>
        /// <returns>bool2 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 bool2(bool2 xy) { return new bool2(xy); }

        /// <summary>Returns a bool2 vector constructed from a single bool value by assigning it to every component.</summary>
        /// <param name="v">bool to convert to bool2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 bool2(bool v) { return new bool2(v); }

        /// <summary>Returns a uint hash code of a bool2 vector.</summary>
        /// <param name="v">Vector value to hash.</param>
        /// <returns>uint hash of the argument.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(bool2 v)
        {
            return csum(select(uint2(0x90A285BBu, 0x5D19E1D5u), uint2(0xFAAF07DDu, 0x625C45BDu), v));
        }

        /// <summary>
        /// Returns a uint2 vector hash code of a bool2 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        /// <param name="v">Vector value to hash.</param>
        /// <returns>uint2 hash of the argument.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 hashwide(bool2 v)
        {
            return (select(uint2(0xC9F27FCBu, 0x6D2523B1u), uint2(0x6E2BF6A9u, 0xCC74B3B7u), v));
        }

        /// <summary>Returns the result of specified shuffling of the components from two bool2 vectors into a bool value.</summary>
        /// <param name="left">bool2 to use as the left argument of the shuffle operation.</param>
        /// <param name="right">bool2 to use as the right argument of the shuffle operation.</param>
        /// <param name="x">The ShuffleComponent to use when setting the resulting bool.</param>
        /// <returns>bool result of the shuffle operation.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool shuffle(bool2 left, bool2 right, ShuffleComponent x)
        {
            return select_shuffle_component(left, right, x);
        }

        /// <summary>Returns the result of specified shuffling of the components from two bool2 vectors into a bool2 vector.</summary>
        /// <param name="left">bool2 to use as the left argument of the shuffle operation.</param>
        /// <param name="right">bool2 to use as the right argument of the shuffle operation.</param>
        /// <param name="x">The ShuffleComponent to use when setting the resulting bool2 x component.</param>
        /// <param name="y">The ShuffleComponent to use when setting the resulting bool2 y component.</param>
        /// <returns>bool2 result of the shuffle operation.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 shuffle(bool2 left, bool2 right, ShuffleComponent x, ShuffleComponent y)
        {
            return bool2(
                select_shuffle_component(left, right, x),
                select_shuffle_component(left, right, y));
        }

        /// <summary>Returns the result of specified shuffling of the components from two bool2 vectors into a bool3 vector.</summary>
        /// <param name="left">bool2 to use as the left argument of the shuffle operation.</param>
        /// <param name="right">bool2 to use as the right argument of the shuffle operation.</param>
        /// <param name="x">The ShuffleComponent to use when setting the resulting bool3 x component.</param>
        /// <param name="y">The ShuffleComponent to use when setting the resulting bool3 y component.</param>
        /// <param name="z">The ShuffleComponent to use when setting the resulting bool3 z component.</param>
        /// <returns>bool3 result of the shuffle operation.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 shuffle(bool2 left, bool2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z)
        {
            return bool3(
                select_shuffle_component(left, right, x),
                select_shuffle_component(left, right, y),
                select_shuffle_component(left, right, z));
        }

        /// <summary>Returns the result of specified shuffling of the components from two bool2 vectors into a bool4 vector.</summary>
        /// <param name="left">bool2 to use as the left argument of the shuffle operation.</param>
        /// <param name="right">bool2 to use as the right argument of the shuffle operation.</param>
        /// <param name="x">The ShuffleComponent to use when setting the resulting bool4 x component.</param>
        /// <param name="y">The ShuffleComponent to use when setting the resulting bool4 y component.</param>
        /// <param name="z">The ShuffleComponent to use when setting the resulting bool4 z component.</param>
        /// <param name="w">The ShuffleComponent to use when setting the resulting bool4 w component.</param>
        /// <returns>bool4 result of the shuffle operation.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 shuffle(bool2 left, bool2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w)
        {
            return bool4(
                select_shuffle_component(left, right, x),
                select_shuffle_component(left, right, y),
                select_shuffle_component(left, right, z),
                select_shuffle_component(left, right, w));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static bool select_shuffle_component(bool2 a, bool2 b, ShuffleComponent component)
        {
            switch(component)
            {
                case ShuffleComponent.LeftX:
                    return a.x;
                case ShuffleComponent.LeftY:
                    return a.y;
                case ShuffleComponent.RightX:
                    return b.x;
                case ShuffleComponent.RightY:
                    return b.y;
                default:
                    throw new System.ArgumentException("Invalid shuffle component: " + component);
            }
        }

    }
}
