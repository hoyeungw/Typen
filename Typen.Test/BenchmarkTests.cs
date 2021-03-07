using System;
using System.Security.Cryptography;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;

namespace Typen.Test {
  [SimpleJob(RuntimeMoniker.Net472, baseline: true)]
  [SimpleJob(RuntimeMoniker.NetCoreApp30)]
  [SimpleJob(RuntimeMoniker.CoreRt30)]
  [SimpleJob(RuntimeMoniker.Mono)]
  [RPlotExporter]
  public class Md5VsSha256 {
    private SHA256 sha256 = SHA256.Create();
    private MD5 md5 = MD5.Create();
    private byte[] data;

    [Params(10, 20)] public int N;

    [GlobalSetup]
    public void Setup() {
      data = new byte[N];
      new Random(42).NextBytes(data);
    }

    [Benchmark]
    public byte[] Sha256() => sha256.ComputeHash(data);

    [Benchmark]
    public byte[] Md5() => md5.ComputeHash(data);
  }

  public class Program {
    public static void Main(string[] args) {
      var summary = BenchmarkRunner.Run<Md5VsSha256>();
    }
  }

  // [TestFixture]
  // public class BenchmarkTests {
  //   [Test]
  //   public void MainTest() {
  //     var summary = BenchmarkRunner.Run<Md5VsSha256>();
  //   }
  // }
}