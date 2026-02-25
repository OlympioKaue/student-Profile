using StudentProfile.Core.Command;
using System.Text.RegularExpressions;

namespace StudentProfile.Core.ValueObjects
{
    public partial class Url
    {
        private const string DefaultUrl = "Invalid URL";

        public Url(string address)
        {
            Address = address;
        }

        public string Address { get; set; }

        public CommandResult<Url> Create()
        {
            if (string.IsNullOrEmpty(Address))
                return CommandResult<Url>.Failure(DefaultUrl);

            if (!UrlRegex().IsMatch(Address))
               return CommandResult<Url>.Failure(DefaultUrl);

            return CommandResult<Url>.Sucess();
        }

        [GeneratedRegex("^(http|https):(\\/\\/www\\.|\\/\\/www\\.|\\/\\/|\\/\\/)[a-z0-9]+([\\-\\.]{1}[a-z0-9]+)*\\.[a-z]{2,5}(:[0-9]{1,5})?(\\/.*)?$|(http|https):(\\/\\/localhost:\\d*|\\/\\/127\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]))(:[0-9]{1,5})?(\\/.*)?$")]
        private static partial Regex UrlRegex();
    }
}
