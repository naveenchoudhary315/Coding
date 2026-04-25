namespace SinggleResponsibiltyPrinciple_Problem
{
    public class UserServicen_Problem
    {
        public void Register(string email, string password)
        {
            // 1. Validation
            if (string.IsNullOrEmpty(email))
                throw new Exception("Email required");

            // 2. Save to DB
            Console.WriteLine("User saved to DB");

            // 3. Send Email
            Console.WriteLine("Email sent");

            // 4. Logging
            Console.WriteLine("Logged info");
        }
    }
}

namespace SingleResponsibiltyPrinciple_Solution
{
    public class UserValidator
    {
        public void Validate(string email, string password)
        {
            if (string.IsNullOrEmpty(email))
                throw new Exception("Email required");
        }
    }
    public class UserRepository
    {
        public void Save(string email, string password)
        {
            Console.WriteLine("User saved to DB");
        }
    }
    public class EmailService
    {
        public void Send(string email)
        {
            Console.WriteLine("Email sent");
        }
    }
    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class UserService
    {
        private readonly UserValidator _validator;
        private readonly UserRepository _repository;
        private readonly EmailService _emailService;
        private readonly Logger _logger;

        public UserService(
            UserValidator validator,
            UserRepository repository,
            EmailService emailService,
            Logger logger)
        {
            _validator = validator;
            _repository = repository;
            _emailService = emailService;
            _logger = logger;
        }

        public void Register(string email, string password)
        {
            _validator.Validate(email, password);
            _repository.Save(email, password);
            _emailService.Send(email);
            _logger.Log("User registered successfully");
        }
    }
}