using System.IO;
using System.Threading.Tasks;
using Zlib.Extended.Enumerations;

namespace Zlib.Extended;
public class Zipper : IZipper
{
    /// <inheritdoc/>
    public async Task<byte[]> DecompressAsync(Stream compressedData, int decompressedSize)
    {
        using var memoryStream = new MemoryStream();
        compressedData.CopyTo(memoryStream);

        return await this.DecompressAsync(memoryStream.ToArray(), decompressedSize);
    }

    /// <inheritdoc/>
    public async Task<byte[]> DecompressAsync(byte[] compressedData, int decompressedSize)
    {
        var buffer = new byte[decompressedSize];

        if (Compressor.Decompress(compressedData, ref buffer) != ReturnCode.Z_STREAM_END)
        {
            throw new InvalidDataException("Error. Unable to decompress data correctly.");
        }

        return await Task.FromResult(buffer);
    }
}