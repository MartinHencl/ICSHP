using System.IO;

namespace Excersise07
{
    public class StreamExamples
    {
        public static void FileExample()
        {
            const string testPath01 = "d:\\test.txt";
            if (!File.Exists(testPath01))
            {
                FileStream test1 = File.Create(testPath01, sizeof(int)*100, FileOptions.Encrypted | FileOptions.Asynchronous);
                test1.Flush();
                using (StreamWriter sw = File.CreateText(testPath01))
                {
                    sw.Write("test text");
                };
            }

            FileInfo fileInfoTest01 = new FileInfo(testPath01);
            if (!fileInfoTest01.Exists)
            {
                var sw = fileInfoTest01.Create();
                sw.Close();
            }

            DriveInfo di = new DriveInfo("C");
            var free = di.TotalFreeSpace;
        }
    }
}
