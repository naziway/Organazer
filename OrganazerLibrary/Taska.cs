namespace OrganazerLibrary
{
    public class Taska
    {
        public int Id { get; set; }
        public StatusTaska Status { get; set; }
        public string AttachmensFiles { get; set; }
        public int Subject { get; set; }
        public System.DateTime DataFinish { get; set; }
        public override string ToString()
        {
            return $"{Status} {AttachmensFiles} {DataFinish}";
        }
    }
}