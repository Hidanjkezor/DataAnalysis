using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZedGraph;

namespace GraphDataAnalysis.MyClasses
{
 static class Wav
    {
        static double Bytes_to_double(byte first, byte second)  // convert 2 bytes to short
        {
            return (short)((second << 8) | first)/32768.0;
        }
        static byte[] Double_to_bytes(double data)  // sum of frequencies
        {
            short k = (short) (data * 32768.0);
            return new []{(byte)(k >> 8), (byte)(k % 256)};
        }
        public static PointPairList Wav_ReadFile(string filename)
        {
            var wav = File.ReadAllBytes(filename);
            int count_c = wav[22];
            var dt = 1.0/BitConverter.ToInt32(new []{wav[24], wav[25], wav[26], wav[27] },0);    // 24-27 sample rate

            var res = new PointPairList();
            for (int i = 44; i < wav.Length; i += 2)
            {
                res.Add(res.Count*dt, Bytes_to_double(wav[i],wav[i+1]));
                if (count_c > 1)
                {
                    i += (count_c - 1) * 2 ;
                }
            }
            return res;
        }
        public static void WritePplToWav(string path, PointPairList data)
        {
            var info = new byte[44 + data.Count * 2];

            //ChunkID = "RIFF"
            info[0] = 0x52;
            info[1] = 0x49;
            info[2] = 0x46;
            info[3] = 0x46;

            //ChunkSize = fileSize - 8
            var size = info.Length - 8;
            info[4] = (byte)(size % 256);
            size >>= 8;
            info[5] = (byte)(size % 256);
            size >>= 8;
            info[6] = (byte)(size % 256);
            size >>= 8;
            info[7] = (byte)(size % 256);

            //Format = "WAVE"
            info[8] = 0x57;
            info[9] = 0x41;
            info[10] = 0x56;
            info[11] = 0x45;

            //Subchunk1ID = "fmt "
            info[12] = 0x66;
            info[13] = 0x6d;
            info[14] = 0x74;
            info[15] = 0x20;

            //16
            info[16] = 0x10;
            info[17] = 0x00;
            info[18] = 0x00;
            info[19] = 0x00;

            //No compression (1)
            info[20] = 0x01;
            info[21] = 0x00;

            //Channels (1)
            info[22] = 0x01;
            info[23] = 0x00;

            //SampleRate
            var sampleRate = (int)(1.0 / (data[1].X - data[0].X));
            var sRateCopy = sampleRate;
            info[24] = (byte)(sRateCopy % 256);
            sRateCopy >>= 8;
            info[25] = (byte)(sRateCopy % 256);
            sRateCopy >>= 8;
            info[26] = (byte)(sRateCopy % 256);
            sRateCopy >>= 8;
            info[27] = (byte)(sRateCopy % 256);

            //ByteRate
            var byteRate = sampleRate * 1 * 16 / 8;
            info[28] = (byte)(byteRate % 256);
            byteRate >>= 8;
            info[29] = (byte)(byteRate % 256);
            byteRate >>= 8;
            info[30] = (byte)(byteRate % 256);
            byteRate >>= 8;
            info[31] = (byte)(byteRate % 256);

            //Block Align
            var blockAlign = 1 * 16 / 8;
            info[32] = (byte)(blockAlign % 256);
            blockAlign >>= 8;
            info[33] = (byte)(blockAlign % 256);

            //BitsPerSample = 16
            info[34] = 0x10;
            info[35] = 0x00;

            //"data"
            info[36] = 0x64;
            info[37] = 0x61;
            info[38] = 0x74;
            info[39] = 0x61;

            //Subchunk2Size
            var subchunk2Size = data.Count * 1 * 16 / 8;
            info[40] = (byte)(subchunk2Size % 256);
            subchunk2Size >>= 8;
            info[41] = (byte)(subchunk2Size % 256);
            subchunk2Size >>= 8;
            info[42] = (byte)(subchunk2Size % 256);
            subchunk2Size >>= 8;
            info[43] = (byte)(subchunk2Size % 256);

            var pos = 44;
            foreach (var d in data)
            {
                var l = Double_to_bytes(d.Y);
                info[pos++] = l[1];
                info[pos++] = l[0];
            }

            File.WriteAllBytes(path, info);
        }
    }
}
