using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Domain.Identity
{
    public class User:AggregateRoot
    {
        protected User()
        {

        }
        public User(Guid userId,string name, string lastName)
        {
            UserId = userId;
            Name = name;
            LastName = lastName;
        }

        public Guid UserId { get;private set; }
        [Required]
        public string Name { get; private set; }
        [Required]
        public string LastName { get; private set; }
        public Guid AccountId { get; private set; }
    }
}
