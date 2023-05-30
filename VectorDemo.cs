
using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using BenchmarkDotNet.Attributes;

public class VectorBenchmark
{ 
    
     private int[] arrayData;
    private List<int> listData;
    private Vector<int> vectorData;
    private const int DataSize = 10000;
    
     [GlobalSetup]
    public void Setup()
    {
        arrayData = new int[DataSize];
        listData = new List<int>(DataSize);
        vectorData = new Vector<int>(arrayData);
        
        var random = new Random();
        for (int i = 0; i < DataSize; i++)
        {
            int value = random.Next();
            arrayData[i] = value;
            listData.Add(value);
        }
    }

     [Benchmark]
    public void ArraySum()
    {
        int sum = 0;
        for (int i = 0; i < arrayData.Length; i++)
        {
            sum += arrayData[i];
        }
    }


          [Benchmark]
    public void ListSum()
    {
        int sum = 0;
        for (int i = 0; i < listData.Count; i++)
        {
            sum += listData[i];
        }
    } 
    
      [Benchmark]
    public void VectorSum()
    {
        int sum = 0;
        int simdLength = Vector<int>.Count;
        int i = 0;

        for (; i <= arrayData.Length - simdLength; i += simdLength)
        {
            var vector = new Vector<int>(arrayData, i);
            sum += Vector.Dot(vector, Vector<int>.One);
        }

        // Handle remaining elements
        for (; i < arrayData.Length; i++)
        {
            sum += arrayData[i];
        }
    }
}

