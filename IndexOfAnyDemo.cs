using System.Buffers;
using BenchmarkDotNet.Attributes;

public class IndexOfAnyBenchmark
{
   [Params(10, 20)]
    public int Max { get; set; }
    private static string _text; 
   
    private static char[] _old;
    private static IndexOfAnyValues<char> _new;
    
     [GlobalSetup]
    public void Setup()
    {
          var chars =new string("aeiou");
           var rand = CreateLetters('a');
               _old = chars.ToCharArray();
                _new = IndexOfAnyValues.Create(chars);
          _text = new string(Random.Shared.GetItems(rand, Max));
          ReadOnlySpan<char> text2 = _text.AsSpan();
    }

 private static char[] CreateLetters(char c)
        => Enumerable
            .Range(c,26)
            .Select(c=>(char)c).ToArray();

    [Benchmark]
    public void Old()
    {
      
        _text.IndexOfAny(_old);
    }

    [Benchmark]
    public void New()
    {
         
          _text.AsSpan().IndexOfAny(_new);
    }
    
}