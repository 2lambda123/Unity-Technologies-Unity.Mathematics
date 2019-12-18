//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using NUnit.Framework;
using Unity.PerformanceTesting;
using Unity.Burst;

namespace Unity.Mathematics.PerformanceTests
{
    public partial class TestTrig
    {
        [BurstCompile]
        public class float_sincos
        {
            public struct Arguments
            {
                public float sin;
                public float cos;

                public void Init()
                {
                    sin = 0.0f;
                    cos = 1.0f;
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 10000; ++i)
                {
                    math.sincos(args.sin, out args.sin, out args.cos);
                }
            }

            public static void MonoTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            [BurstCompile]
            public static void BurstTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            public delegate void TestFunction(ref Arguments args);
        }

        [Test, Performance]
        public void float_sincos_mono()
        {
            float_sincos.TestFunction testFunction = float_sincos.MonoTestFunction;
            var args = new float_sincos.Arguments();
            args.Init();

            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .Definition(sampleUnit: SampleUnit.Microsecond)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
        }

        [Test, Performance]
        public void float_sincos_burst()
        {
            FunctionPointer<float_sincos.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<float_sincos.TestFunction>(float_sincos.BurstTestFunction);
            var args = new float_sincos.Arguments();
            args.Init();

            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .Definition(sampleUnit: SampleUnit.Microsecond)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
        }
        [BurstCompile]
        public class float2_sincos
        {
            public struct Arguments
            {
                public float2 sin;
                public float2 cos;

                public void Init()
                {
                    sin = new float2(0.0f);
                    cos = new float2(1.0f);
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 10000; ++i)
                {
                    math.sincos(args.sin, out args.sin, out args.cos);
                }
            }

            public static void MonoTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            [BurstCompile]
            public static void BurstTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            public delegate void TestFunction(ref Arguments args);
        }

        [Test, Performance]
        public void float2_sincos_mono()
        {
            float2_sincos.TestFunction testFunction = float2_sincos.MonoTestFunction;
            var args = new float2_sincos.Arguments();
            args.Init();

            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .Definition(sampleUnit: SampleUnit.Microsecond)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
        }

        [Test, Performance]
        public void float2_sincos_burst()
        {
            FunctionPointer<float2_sincos.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<float2_sincos.TestFunction>(float2_sincos.BurstTestFunction);
            var args = new float2_sincos.Arguments();
            args.Init();

            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .Definition(sampleUnit: SampleUnit.Microsecond)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
        }
        [BurstCompile]
        public class float3_sincos
        {
            public struct Arguments
            {
                public float3 sin;
                public float3 cos;

                public void Init()
                {
                    sin = new float3(0.0f);
                    cos = new float3(1.0f);
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 10000; ++i)
                {
                    math.sincos(args.sin, out args.sin, out args.cos);
                }
            }

            public static void MonoTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            [BurstCompile]
            public static void BurstTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            public delegate void TestFunction(ref Arguments args);
        }

        [Test, Performance]
        public void float3_sincos_mono()
        {
            float3_sincos.TestFunction testFunction = float3_sincos.MonoTestFunction;
            var args = new float3_sincos.Arguments();
            args.Init();

            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .Definition(sampleUnit: SampleUnit.Microsecond)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
        }

        [Test, Performance]
        public void float3_sincos_burst()
        {
            FunctionPointer<float3_sincos.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<float3_sincos.TestFunction>(float3_sincos.BurstTestFunction);
            var args = new float3_sincos.Arguments();
            args.Init();

            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .Definition(sampleUnit: SampleUnit.Microsecond)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
        }
        [BurstCompile]
        public class float4_sincos
        {
            public struct Arguments
            {
                public float4 sin;
                public float4 cos;

                public void Init()
                {
                    sin = new float4(0.0f);
                    cos = new float4(1.0f);
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 10000; ++i)
                {
                    math.sincos(args.sin, out args.sin, out args.cos);
                }
            }

            public static void MonoTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            [BurstCompile]
            public static void BurstTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            public delegate void TestFunction(ref Arguments args);
        }

        [Test, Performance]
        public void float4_sincos_mono()
        {
            float4_sincos.TestFunction testFunction = float4_sincos.MonoTestFunction;
            var args = new float4_sincos.Arguments();
            args.Init();

            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .Definition(sampleUnit: SampleUnit.Microsecond)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
        }

        [Test, Performance]
        public void float4_sincos_burst()
        {
            FunctionPointer<float4_sincos.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<float4_sincos.TestFunction>(float4_sincos.BurstTestFunction);
            var args = new float4_sincos.Arguments();
            args.Init();

            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .Definition(sampleUnit: SampleUnit.Microsecond)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
        }
    }
}
