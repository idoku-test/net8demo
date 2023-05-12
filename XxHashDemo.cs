using System;
using System.Security.Cryptography;
using System.Text;
using System.IO.Hashing;
using BenchmarkDotNet.Attributes;

public class XxHashBenchmark
{

     [Params(100, 1000,10000)]
    public int Max { get; set; }

    public byte[] bytes{get;set;}

    [GlobalSetup]
    public void Setup()
    {
        ReadOnlySpan<char> text = "ABCDEFGHIJKLMN";
        char[] thisRound = Random.Shared.GetItems(text, Max);
      
        bytes = Encoding.UTF8.GetBytes(thisRound);
    }

    
[Benchmark]
public void XxHashTest()
{
     XxHash(bytes);
}

[Benchmark]
public void Sha1Test(){
    Sha1(bytes);
}

[Benchmark]
public void Sha256Test(){
    Sha256(bytes);
}


    public static string XxHash(byte[] bytes)
    {
        var digest = XxHash3.Hash(bytes);
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < digest.Length; i++)
        {
            sb.Append(digest[i].ToString("x2"));
        }
        return sb.ToString().ToLowerInvariant();
    }

    public static string Sha1(byte[] bytes)
    {
        using (var sha1 = SHA1.Create())
        {
            byte[] retVal = sha1.ComputeHash(bytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < retVal.Length; i++)
            {
                sb.Append(retVal[i].ToString("x2"));
            }
            return sb.ToString().ToLowerInvariant();
        }
    }

    public static string Sha256(byte[] bytes)
    {
        using (var sha1 = SHA256.Create())
        {
            byte[] retVal = sha1.ComputeHash(bytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < retVal.Length; i++)
            {
                sb.Append(retVal[i].ToString("x2"));
            }
            return sb.ToString().ToLowerInvariant();
        }
    }
}