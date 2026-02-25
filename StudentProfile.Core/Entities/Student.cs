using StudentProfile.Core.Command;
using StudentProfile.Core.ValueObjects;

namespace StudentProfile.Core.Entities
{
    public class Student
    {
        private const string ErrorMessage = "URL Invalid";

        public Student(Url url, Email email)
        {
            Url = url;
            Email = email;
        }

        public Url Url { get; set; }
        public Email Email { get; set; }

        public string ProfileUrl => $"{Url.Address}{Email.User}";

        public CommandResult<Student> CreateUrl(string address, string value)
        {
            var url = ProfileUrl;
            if (url.StartsWith(address) || url.EndsWith(value))
                return CommandResult<Student>.Sucess();

            return CommandResult<Student>.Failure(ErrorMessage);
        }
    }
}
