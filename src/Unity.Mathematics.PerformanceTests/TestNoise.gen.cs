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
    public partial class TestNoise
    {
        [BurstCompile]
        public class snoise2D
        {
            public struct Arguments
            {
                public float2 v;

                public void Init()
                {
                    v = new float2();
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 10000; ++i)
                {
                    args.v.x = noise.snoise(args.v);
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
        public void snoise2D_mono()
        {
            snoise2D.TestFunction testFunction = snoise2D.MonoTestFunction;
            var args = new snoise2D.Arguments();
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
        public void snoise2D_burst()
        {
            FunctionPointer<snoise2D.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<snoise2D.TestFunction>(snoise2D.BurstTestFunction);
            var args = new snoise2D.Arguments();
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
        public class snoise3D
        {
            public struct Arguments
            {
                public float3 v;

                public void Init()
                {
                    v = new float3();
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 10000; ++i)
                {
                    args.v.x = noise.snoise(args.v);
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
        public void snoise3D_mono()
        {
            snoise3D.TestFunction testFunction = snoise3D.MonoTestFunction;
            var args = new snoise3D.Arguments();
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
        public void snoise3D_burst()
        {
            FunctionPointer<snoise3D.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<snoise3D.TestFunction>(snoise3D.BurstTestFunction);
            var args = new snoise3D.Arguments();
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
        public class snoise4D
        {
            public struct Arguments
            {
                public float4 v;

                public void Init()
                {
                    v = new float4();
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 10000; ++i)
                {
                    args.v.x = noise.snoise(args.v);
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
        public void snoise4D_mono()
        {
            snoise4D.TestFunction testFunction = snoise4D.MonoTestFunction;
            var args = new snoise4D.Arguments();
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
        public void snoise4D_burst()
        {
            FunctionPointer<snoise4D.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<snoise4D.TestFunction>(snoise4D.BurstTestFunction);
            var args = new snoise4D.Arguments();
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
        public class snoise3Dgrad
        {
            public struct Arguments
            {
                public float3 v;
                public float3 gradient;

                public void Init()
                {
                    v = new float3();
                    gradient = new float3();
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 10000; ++i)
                {
                    args.v.x = noise.snoise(args.v, out args.gradient);
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
        public void snoise3Dgrad_mono()
        {
            snoise3Dgrad.TestFunction testFunction = snoise3Dgrad.MonoTestFunction;
            var args = new snoise3Dgrad.Arguments();
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
        public void snoise3Dgrad_burst()
        {
            FunctionPointer<snoise3Dgrad.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<snoise3Dgrad.TestFunction>(snoise3Dgrad.BurstTestFunction);
            var args = new snoise3Dgrad.Arguments();
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
        public class cnoise2D
        {
            public struct Arguments
            {
                public float2 v;

                public void Init()
                {
                    v = new float2();
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 10000; ++i)
                {
                    args.v.x = noise.cnoise(args.v);
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
        public void cnoise2D_mono()
        {
            cnoise2D.TestFunction testFunction = cnoise2D.MonoTestFunction;
            var args = new cnoise2D.Arguments();
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
        public void cnoise2D_burst()
        {
            FunctionPointer<cnoise2D.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<cnoise2D.TestFunction>(cnoise2D.BurstTestFunction);
            var args = new cnoise2D.Arguments();
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
        public class cnoise3D
        {
            public struct Arguments
            {
                public float3 v;

                public void Init()
                {
                    v = new float3();
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 10000; ++i)
                {
                    args.v.x = noise.cnoise(args.v);
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
        public void cnoise3D_mono()
        {
            cnoise3D.TestFunction testFunction = cnoise3D.MonoTestFunction;
            var args = new cnoise3D.Arguments();
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
        public void cnoise3D_burst()
        {
            FunctionPointer<cnoise3D.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<cnoise3D.TestFunction>(cnoise3D.BurstTestFunction);
            var args = new cnoise3D.Arguments();
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
        public class cnoise4D
        {
            public struct Arguments
            {
                public float4 v;

                public void Init()
                {
                    v = new float4();
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 10000; ++i)
                {
                    args.v.x = noise.cnoise(args.v);
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
        public void cnoise4D_mono()
        {
            cnoise4D.TestFunction testFunction = cnoise4D.MonoTestFunction;
            var args = new cnoise4D.Arguments();
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
        public void cnoise4D_burst()
        {
            FunctionPointer<cnoise4D.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<cnoise4D.TestFunction>(cnoise4D.BurstTestFunction);
            var args = new cnoise4D.Arguments();
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
        public class pnoise2D
        {
            public struct Arguments
            {
                public float2 v;

                public void Init()
                {
                    v = new float2();
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 10000; ++i)
                {
                    args.v.x = noise.pnoise(args.v, args.v);
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
        public void pnoise2D_mono()
        {
            pnoise2D.TestFunction testFunction = pnoise2D.MonoTestFunction;
            var args = new pnoise2D.Arguments();
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
        public void pnoise2D_burst()
        {
            FunctionPointer<pnoise2D.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<pnoise2D.TestFunction>(pnoise2D.BurstTestFunction);
            var args = new pnoise2D.Arguments();
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
        public class pnoise3D
        {
            public struct Arguments
            {
                public float3 v;

                public void Init()
                {
                    v = new float3();
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 10000; ++i)
                {
                    args.v.x = noise.pnoise(args.v, args.v);
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
        public void pnoise3D_mono()
        {
            pnoise3D.TestFunction testFunction = pnoise3D.MonoTestFunction;
            var args = new pnoise3D.Arguments();
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
        public void pnoise3D_burst()
        {
            FunctionPointer<pnoise3D.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<pnoise3D.TestFunction>(pnoise3D.BurstTestFunction);
            var args = new pnoise3D.Arguments();
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
        public class pnoise4D
        {
            public struct Arguments
            {
                public float4 v;

                public void Init()
                {
                    v = new float4();
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 10000; ++i)
                {
                    args.v.x = noise.pnoise(args.v, args.v);
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
        public void pnoise4D_mono()
        {
            pnoise4D.TestFunction testFunction = pnoise4D.MonoTestFunction;
            var args = new pnoise4D.Arguments();
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
        public void pnoise4D_burst()
        {
            FunctionPointer<pnoise4D.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<pnoise4D.TestFunction>(pnoise4D.BurstTestFunction);
            var args = new pnoise4D.Arguments();
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
        public class cellular2D
        {
            public struct Arguments
            {
                public float2 v;

                public void Init()
                {
                    v = new float2();
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 10000; ++i)
                {
                    args.v = noise.cellular(args.v);
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
        public void cellular2D_mono()
        {
            cellular2D.TestFunction testFunction = cellular2D.MonoTestFunction;
            var args = new cellular2D.Arguments();
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
        public void cellular2D_burst()
        {
            FunctionPointer<cellular2D.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<cellular2D.TestFunction>(cellular2D.BurstTestFunction);
            var args = new cellular2D.Arguments();
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
        public class cellular3D
        {
            public struct Arguments
            {
                public float3 v;

                public void Init()
                {
                    v = new float3();
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 10000; ++i)
                {
                    args.v.xy = noise.cellular(args.v);
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
        public void cellular3D_mono()
        {
            cellular3D.TestFunction testFunction = cellular3D.MonoTestFunction;
            var args = new cellular3D.Arguments();
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
        public void cellular3D_burst()
        {
            FunctionPointer<cellular3D.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<cellular3D.TestFunction>(cellular3D.BurstTestFunction);
            var args = new cellular3D.Arguments();
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
        public class cellular2x2
        {
            public struct Arguments
            {
                public float2 v;

                public void Init()
                {
                    v = new float2();
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 10000; ++i)
                {
                    args.v = noise.cellular2x2(args.v);
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
        public void cellular2x2_mono()
        {
            cellular2x2.TestFunction testFunction = cellular2x2.MonoTestFunction;
            var args = new cellular2x2.Arguments();
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
        public void cellular2x2_burst()
        {
            FunctionPointer<cellular2x2.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<cellular2x2.TestFunction>(cellular2x2.BurstTestFunction);
            var args = new cellular2x2.Arguments();
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
        public class cellular2x2x2
        {
            public struct Arguments
            {
                public float3 v;

                public void Init()
                {
                    v = new float3();
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 10000; ++i)
                {
                    args.v.xy = noise.cellular2x2x2(args.v);
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
        public void cellular2x2x2_mono()
        {
            cellular2x2x2.TestFunction testFunction = cellular2x2x2.MonoTestFunction;
            var args = new cellular2x2x2.Arguments();
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
        public void cellular2x2x2_burst()
        {
            FunctionPointer<cellular2x2x2.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<cellular2x2x2.TestFunction>(cellular2x2x2.BurstTestFunction);
            var args = new cellular2x2x2.Arguments();
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
        public class psrdnoise
        {
            public struct Arguments
            {
                public float2 v;

                public void Init()
                {
                    v = new float2();
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 10000; ++i)
                {
                    args.v = noise.psrdnoise(args.v, args.v, args.v.y).xy;
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
        public void psrdnoise_mono()
        {
            psrdnoise.TestFunction testFunction = psrdnoise.MonoTestFunction;
            var args = new psrdnoise.Arguments();
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
        public void psrdnoise_burst()
        {
            FunctionPointer<psrdnoise.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<psrdnoise.TestFunction>(psrdnoise.BurstTestFunction);
            var args = new psrdnoise.Arguments();
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
        public class psrnoise
        {
            public struct Arguments
            {
                public float2 v;

                public void Init()
                {
                    v = new float2();
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 10000; ++i)
                {
                    args.v.x = noise.psrnoise(args.v, args.v, args.v.y);
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
        public void psrnoise_mono()
        {
            psrnoise.TestFunction testFunction = psrnoise.MonoTestFunction;
            var args = new psrnoise.Arguments();
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
        public void psrnoise_burst()
        {
            FunctionPointer<psrnoise.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<psrnoise.TestFunction>(psrnoise.BurstTestFunction);
            var args = new psrnoise.Arguments();
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
        public class srdnoise
        {
            public struct Arguments
            {
                public float2 v;

                public void Init()
                {
                    v = new float2();
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 10000; ++i)
                {
                    args.v = noise.srdnoise(args.v, args.v.y).xy;
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
        public void srdnoise_mono()
        {
            srdnoise.TestFunction testFunction = srdnoise.MonoTestFunction;
            var args = new srdnoise.Arguments();
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
        public void srdnoise_burst()
        {
            FunctionPointer<srdnoise.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<srdnoise.TestFunction>(srdnoise.BurstTestFunction);
            var args = new srdnoise.Arguments();
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
        public class srnoise
        {
            public struct Arguments
            {
                public float2 v;

                public void Init()
                {
                    v = new float2();
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 10000; ++i)
                {
                    args.v.x = noise.srnoise(args.v, args.v.y);
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
        public void srnoise_mono()
        {
            srnoise.TestFunction testFunction = srnoise.MonoTestFunction;
            var args = new srnoise.Arguments();
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
        public void srnoise_burst()
        {
            FunctionPointer<srnoise.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<srnoise.TestFunction>(srnoise.BurstTestFunction);
            var args = new srnoise.Arguments();
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
