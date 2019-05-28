namespace DomainEntity.Entity.User
{
    public class UserRoles : BaseEntity
    {
        public Entity.User.User User { get; set; }

        public Role Role { get; set; }
    }
}