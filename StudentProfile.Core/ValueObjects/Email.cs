using StudentProfile.Core.Command;
using System.Text.RegularExpressions;

namespace StudentProfile.Core.ValueObjects
{
    public partial class Email
    {
        private const string DefaultEmail = "Invalid email";
        public Email(string value)
        {
            Value = value;
        }

        public string Value { get; }
        public string User => Value.Split('@')[0];

        public CommandResult<Email> Create()
        {
            if (string.IsNullOrEmpty(Value))
                return CommandResult<Email>.Failure(DefaultEmail);

            if (!EmailRegex().IsMatch(Value))
                return CommandResult<Email>.Failure(DefaultEmail);

            return CommandResult<Email>.Sucess();
        }

        [GeneratedRegex(@"^[a-zA-Z0-9._%+-]{3,}@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")]
        private static partial Regex EmailRegex();

    }
}
