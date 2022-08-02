public class Frame
{
    public int Role1 { get; set; }
    public int Role2 { get; set; }
    public int Role3 { get; set; }
    public int Total => Role1+Role2+Role3;
}