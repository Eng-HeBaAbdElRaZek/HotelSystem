namespace ExaminantionSystem_R3.Models
{
    public class BaseModel
    {
        public int Id { get; set; }
        public bool Deleted { get; set; } = false;
        public DateTime Date { get; set; }  = DateTime.Now;

    }
}
