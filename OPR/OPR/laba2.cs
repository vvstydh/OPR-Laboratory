using System.Security.Cryptography;
using System.Text;

class doc
{
    public void create(string path)
    {
        using (StreamWriter fs = new StreamWriter(path)) { }
    }
    public void write(string path, string text)
    {
        using (StreamWriter fs = new StreamWriter(path))
            fs.Write(text);
    }
    public void move(string path, string newpath)
    {
        FileInfo move = new FileInfo(path);
        if (move.Exists)
            move.MoveTo(newpath);
    }
    public void copy(string path, string newpath)
    {
        FileInfo move = new FileInfo(path);
        if (move.Exists)
            move.CopyTo(newpath, true);
    }
    public void del(string path)
    {
        FileInfo move = new FileInfo(path);
        if (move.Exists)
            move.Delete();
    }
}
class crypto : doc
{
    private byte[] key = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
    private byte[] iv = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
    public void code(string path)
    {
        byte[] data1 = Encoding.UTF8.GetBytes(data(path));
        using (SymmetricAlgorithm alg = Aes.Create())
        using (ICryptoTransform cryptoTransform = alg.CreateEncryptor(key, iv))
        using (FileStream st = new FileStream(path, FileMode.OpenOrCreate))
        using (CryptoStream cr = new CryptoStream(st, cryptoTransform, CryptoStreamMode.Write))
            cr.Write(data1, 0, data1.Length);
    }
    public void encode(string path, string newpath)
    {
        StreamReader sr = null;
        using (SymmetricAlgorithm alg = Aes.Create())
        using (ICryptoTransform cryptoTransform = alg.CreateDecryptor(key, iv))
        using (FileStream st = new FileStream(path, FileMode.OpenOrCreate))
        using (CryptoStream cr = new CryptoStream(st, cryptoTransform, CryptoStreamMode.Read))
        {
            sr = new StreamReader(cr);
            write(newpath, sr.ReadToEnd());
        }
    }
    private string data(string path)
    {
        using (StreamReader read = new StreamReader(path))
            return read.ReadToEnd();
    }
}