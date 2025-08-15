using UserManagementAPI.Models;

namespace UserManagementAPI.Services
{
    public class UserService
    {
        private readonly List<User> _users = new();

        public List<User> GetAll() => _users;

        public User? GetById(int id) => _users.FirstOrDefault(u => u.Id == id);

        public List<User> GetPaged(int page = 1, int pageSize = 10)
        {
            return _users
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        public void Add(User user) => _users.Add(user);

        public bool Update(int id, User updatedUser)
        {
            var user = GetById(id);
            if (user == null) return false;

            user.Name = updatedUser.Name;
            user.Email = updatedUser.Email;
            user.Department = updatedUser.Department;
            return true;
        }

        public bool Delete(int id)
        {
            var user = GetById(id);
            if (user == null) return false;

            _users.Remove(user);
            return true;
        }
    }
}
