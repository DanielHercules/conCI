namespace conCI
{
    public interface IAccessData
    {
        void ReadData();
        void WriteData(string name);
        void Insert();
        void UpdateById();
    }
}