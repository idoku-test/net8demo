
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using BenchmarkDotNet.Attributes;

class VectorBenchmark
{ 
        private const uint Vector256ByteCount = 32;
        private const int BitsPerInt32 = 32;
        private int[] m_array = Enumerable.Range(0, 512).ToArray();
        private bool[] boolArray = new bool[512 * 32];
        private int m_length = 512;

        [Benchmark]
        public void Vector256ShuffleConst()
        {
            Vector256<byte> bitMask = Vector256.Create(0x80402010_08040201).AsByte();
            Vector256<byte> ones = Vector256.Create((byte)1);

            ref byte destination = ref Unsafe.As<bool, byte>(ref MemoryMarshal.GetArrayDataReference<bool>(boolArray));

            for (uint i = 0; (i + Vector256ByteCount) <= (uint)m_length; i += Vector256ByteCount)
            {
                int bits = m_array[i / (uint)BitsPerInt32];
                Vector256<int> scalar = Vector256.Create(bits);
                Vector256<byte> shuffled = Vector256.Shuffle(scalar.AsByte(), Vector256.Create(0, 0x01010101_01010101, 0x02020202_02020202, 0x03030303_03030303).AsByte());

                Vector256<byte> extracted = shuffled & bitMask;
                Vector256<byte> normalized = Vector256.Min(extracted, ones);
                normalized.StoreUnsafe(ref destination, new UIntPtr(i));
            }
        }
    
}