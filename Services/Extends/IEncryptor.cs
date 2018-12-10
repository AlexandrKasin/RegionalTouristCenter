namespace Services.Extends
{
    public interface IEncryptor
    {
        string GetHash(string input);
    }
}
