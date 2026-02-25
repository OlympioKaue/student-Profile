namespace StudentProfile.Core.Command
{
    public class CommandResult<T>
    {
        public bool IsSucess { get; private set; }
        public bool IsFailure { get; private set; }
        public string ErrorMessage { get; private set; }
        public T? Value { get; private set; }

        protected CommandResult(bool isSucess, T? value, string errorMessage)
        {
            IsSucess = isSucess;
            Value = value;
            ErrorMessage = errorMessage;
        }

        public static CommandResult<T> Sucess(T value = default!) =>
            new CommandResult<T>(true, value, null!);
        public static CommandResult<T> Failure(string errorMessage) =>
            new CommandResult<T>(false, default, errorMessage);
    }
}
