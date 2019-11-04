namespace ConnectApp.API.Models
{
    public class Like
    {
        public int LikerId { get; set; } // user likes other users
        public int LikeeId { get; set; } // user being liked by another user
        public User Liker { get; set; }
        public User Likee { get; set; }
    }
}