using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcpTest
{
    public class Player
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }

        public Player(string username, string password, int id)
        {
            Username = username;
            Password = password;
            Id = id;
        }

        public override string ToString()
        {
            return $"ID - {Id}/n Username - {Username}/n Password - {Password}".Replace("/n", Environment.NewLine);
        }
    }
}
