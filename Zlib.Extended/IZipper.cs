using System.IO;
using System.Threading.Tasks;

namespace Zlib.Extended;

public interface IZipper
{
    /// <summary>
    /// Decompresses compressed data. The returned array is the size specified.
    /// </summary>
    /// <param name="compressedData">Data that has previously been compressed by zlib.</param>
    /// <param name="decompressedSize">Size of the output array.</param>
    /// <returns>Array of decompressed data.</returns>
    Task<byte[]> DecompressAsync(Stream compressedData, int decompressedSize);

    /// <summary>
    /// Decompresses compressed data. The returned array is the size specified.
    /// </summary>
    /// <param name="compressedData">Data that has previously been compressed by zlib.</param>
    /// <param name="decompressedSize">Size of the output array.</param>
    /// <returns>Array of decompressed data.</returns>
    Task<byte[]> DecompressAsync(byte[] compressedData, int decompressedSize);
}
