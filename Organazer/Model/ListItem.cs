namespace Organazer.Model
{
    public class ListItem
    {
        public string Task { get; set; }
        public override string ToString()
        {
            return Task;
        }
    }
}