namespace ShopRu.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public Role Role { get; set; }
        public DateTime RegisterAt { get; set; }
    }
}